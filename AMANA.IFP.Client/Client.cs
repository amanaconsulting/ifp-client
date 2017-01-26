// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System;
using System.IdentityModel.Tokens;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Client
{
    public class Client
    {
        private BilanzdatenELBAPortTypeClient _client;

        public ns3QuittungTyp SendElbaData(ns1ChannelHeaderTyp channel, ns2BilanzdatenTyp bilanzdaten,
            ns1IdentityHeaderTyp identity, Mapping mapping, Version version, HttpProxySettings httpProxySettings,
            CertificateSettings certificateSettings)
        {
            try
            {
                ns1ProtocolHeaderTyp protocol = new ns1ProtocolHeaderTyp();
                protocol.version = "IFP_1.6";
                protocol.engine = "Apache CXF 3.1.4";

                ns1ServiceHeaderTyp service = new ns1ServiceHeaderTyp();
                service.name = "BilanzdatenELBA";
                service.version = version.name;
                service.method = "uebernehmeELBADaten";

                ns1SessionHeaderTyp session = new ns1SessionHeaderTyp();

                ns1TargetHeaderTyp target = new ns1TargetHeaderTyp();
                target.institute = new ns1TargetHeaderTypInstitute();
                target.institute.id = mapping.BLZ;
                target.provider = mapping.IFPID;

                ns1TicketHeaderTyp ticket = new ns1TicketHeaderTyp();
                DateTime time = DateTime.Now;
                string ifpId = "IFP999nnnn";
                ticket.value =
                    $"{ifpId}_{time.Year.ToString("d4")}{time.Month.ToString("d2")}{time.Day.ToString("d2")}{time.Hour.ToString("d2")}{time.Minute.ToString("d2")}{time.Second.ToString("d2")}";

                WSHttpBinding binding = new WSHttpBinding {ReceiveTimeout = new TimeSpan(0, 0, 1, 0)};
                binding.Security.Mode = SecurityMode.TransportWithMessageCredential;
                binding.Security.Message.ClientCredentialType = MessageCredentialType.Certificate;
                binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;

                WebProxy httpProxy = null;
                if (httpProxySettings.ProxyMode == HttpProxySettings.HttpProxyMode.OwnProxy)
                {
                    httpProxy = new WebProxy(httpProxySettings.ProxyAddresUri);
                    httpProxy.UseDefaultCredentials = false;
                    httpProxy.Credentials = new NetworkCredential(httpProxySettings.UserName, httpProxySettings.Password);
                    binding.UseDefaultWebProxy = false;
                }
                else if (httpProxySettings.ProxyMode == HttpProxySettings.HttpProxyMode.SystemProxy)
                {
                    httpProxy = new WebProxy();
                    httpProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                    binding.UseDefaultWebProxy = true;
                }

                WebRequest.DefaultWebProxy = httpProxy;

                EndpointAddress address = new EndpointAddress(version.URL);
                _client = new BilanzdatenELBAPortTypeClient(binding, address);
                _client.ClientCredentials.ClientCertificate.SetCertificate(certificateSettings.StoreLocation,
                    certificateSettings.StoreName, certificateSettings.FindType, certificateSettings.FindValue);
                _client.ClientCredentials.ServiceCertificate.SetDefaultCertificate(certificateSettings.StoreLocation,
                    certificateSettings.StoreName, certificateSettings.FindType, certificateSettings.FindValue);

                ElbaEndpointBehavior endpointBehavior = new ElbaEndpointBehavior();

#if DEBUG
                endpointBehavior.IsDebugMode = true;
#endif

                _client.Endpoint.EndpointBehaviors.Add(endpointBehavior);

                X509Certificate2 certificate = null;
                X509Store store = new X509Store(certificateSettings.StoreName, certificateSettings.StoreLocation);
                store.Open(OpenFlags.ReadOnly);
                X509Certificate2Collection certificates = store.Certificates.Find(certificateSettings.FindType, certificateSettings.FindValue, false);
                store.Close();
                if (certificates.Count > 0)
                    certificate = certificates[0];
                else
                    throw new ArgumentException($"No certificate found using the following settings: {certificateSettings}");

                X509SecurityToken token = new X509SecurityToken(certificate);

                ns3QuittungTyp quittung = _client.uebernehmeElbaDaten(
                    channel,
                    identity,
                    ref protocol,
                    service,
                    ref session,
                    ref target,
                    ref ticket,
                    bilanzdaten);

                _client.Close();
                return quittung;
            }
            catch (Exception)
            {
                _client?.Close();
                throw;
            }
        }
    }
}
