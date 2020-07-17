// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Client
{
    public class Client
    {
        private BilanzdatenELBAPortTypeClient _elbaClient;        

        public ns3QuittungTyp SendElbaData(ns1ChannelHeaderTyp channel, ns2BilanzdatenTyp bilanzdaten,
            ns1IdentityHeaderTyp identity, Mapping mapping, Version version, HttpProxySettings httpProxySettings,
            CertificateSettings certificateSettings)
        {
            try
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

                ns1ProtocolHeaderTyp protocol = new ns1ProtocolHeaderTyp();
                protocol.version = "IFP_1.6";
                protocol.engine = "Apache CXF 3.1.4";

                ns1ServiceHeaderTyp service = new ns1ServiceHeaderTyp();
                service.name = "BilanzdatenELBA";
                service.version = version.name;
                service.method = "uebernehmeElbaDaten";

                ns1SessionHeaderTyp session = new ns1SessionHeaderTyp();

                ns1TargetHeaderTyp target = new ns1TargetHeaderTyp();
                target.institute = new ns1TargetHeaderTypInstitute();
                target.institute.id = mapping.BLZ;
                target.provider = mapping.IFPID;

                ns1TicketHeaderTyp ticket = new ns1TicketHeaderTyp();
                DateTime time = DateTime.Now;
                
                ticket.value =
                    $"{identity.provider}{time.Year.ToString("d4")}{time.Month.ToString("d2")}{time.Day.ToString("d2")}{time.Hour.ToString("d2")}{time.Minute.ToString("d2")}{time.Second.ToString("d2")}";

                IWebProxy webProxy = WebRequest.DefaultWebProxy;
                WebProxy httpProxy = null;

                if (httpProxySettings.ProxyMode == HttpProxySettings.HttpProxyMode.OwnProxy)
                {
                    httpProxy = new WebProxy(httpProxySettings.HttpProxyAddresUri);
                    httpProxy.UseDefaultCredentials = false;
                    httpProxy.Credentials = new NetworkCredential(httpProxySettings.UserName, httpProxySettings.Password);                    
                    webProxy = httpProxy;
                }
                else if (httpProxySettings.ProxyMode == HttpProxySettings.HttpProxyMode.SystemProxy)
                {
                    httpProxy = new WebProxy();
                    httpProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                    webProxy = httpProxy;
                }

                WebRequest.DefaultWebProxy = webProxy;

                _elbaClient = new BilanzdatenELBAPortTypeClient("BilanzdatenELBAPortTestCertSecurityProfileStandardEndpoint");                

                var behavior = _elbaClient.Endpoint.Behaviors.Find<ClientCredentials>();
                behavior.ClientCertificate.SetCertificate(certificateSettings.StoreLocation, certificateSettings.StoreName, certificateSettings.FindType, certificateSettings.FindValue);

                if (behavior.ServiceCertificate.DefaultCertificate == null)
                    behavior.ServiceCertificate.SetDefaultCertificate(certificateSettings.StoreLocation, certificateSettings.StoreName, certificateSettings.FindType, certificateSettings.FindValue);

                _elbaClient.Endpoint.Address = new EndpointAddress(new Uri(version.URL), EndpointIdentity.CreateDnsIdentity(behavior.ServiceCertificate.DefaultCertificate.GetNameInfo(X509NameType.SimpleName, false)));
                
                ns3QuittungTyp quittung = _elbaClient.uebernehmeElbaDaten(
                    channel,
                    identity,
                    ref protocol,
                    service,
                    ref session,
                    ref target,
                    ref ticket,
                    bilanzdaten);

                _elbaClient.Close();

                return quittung;
            }
            catch (Exception)
            {
                if (_elbaClient != null)
                {
                    if (_elbaClient.State == CommunicationState.Faulted)
                    {
                        _elbaClient.Abort();
                        _elbaClient.ChannelFactory.Abort();
                    }
                    else if (_elbaClient.State == CommunicationState.Opened)
                    {
                        _elbaClient.Close();
                        _elbaClient.ChannelFactory.Close();
                    }
                }                      

                throw;
            }
        }
    }
}
