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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using WinSCP;

namespace AMANA.IFP.Common.Helpers
{
    public static class RoutingTableReader
    {
        public static List<IfpMapping> Mappings { get; set; }
        public static string SftpSchufaFileServerHostUrl = "file-port.schufa.de";
        public static string InstituteMappingProdFileName = "institutemapping-prod.xml";
        public static string InstituteMappingTestFileName = "institutemapping-test.xml";

        public static void Read(string relativePath)
        {
            string absolutePath = PathHelper.GetAbsolutePath(relativePath);

            Mappings = new List<IfpMapping>();

            XmlDocument doc = new XmlDocument();
            doc.Load(absolutePath);

            if (doc.DocumentElement != null)
            {
                foreach (XmlNode mappingNode in doc.DocumentElement.ChildNodes)
                {
                    if (mappingNode.Name == "Mapping")
                    {
                        IfpMapping mapping = BuildMapping(mappingNode);
                        Mappings.Add(mapping);
                    }
                }
            }
        }

        public static string DownloadInstituteMappingFileFromSftpServerIfNewer(string userName, string password, bool isTest, string localSaveDirPath, DateTime? downloadedRemoteFileLastWriteDate,  out DateTime? remoteFileLastWriteDate, Uri proxyUri = null, string proxyUserName = null, string proxyPassword = null)
        {
            remoteFileLastWriteDate = null;
            var remoteFileName = InstituteMappingTestFileName;
            if (!isTest)
                remoteFileName = InstituteMappingProdFileName;

            var localSaveFilePath = Path.Combine(localSaveDirPath, remoteFileName);            

            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = SftpSchufaFileServerHostUrl,
                UserName = userName,
                Password = password,
                GiveUpSecurityAndAcceptAnySshHostKey = true
            };

            if (proxyUri != null && !String.IsNullOrWhiteSpace(proxyUserName) && !String.IsNullOrWhiteSpace(proxyPassword))
            {
                //3 is Http Proxy Method s. https://winscp.net/eng/docs/rawsettings
                sessionOptions.AddRawSettings("ProxyMethod", "3");
                sessionOptions.AddRawSettings("ProxyHost", proxyUri.Host);
                sessionOptions.AddRawSettings("ProxyPort", proxyUri.Port.ToString());
                sessionOptions.AddRawSettings("ProxyUsername", proxyUserName);
                sessionOptions.AddRawSettings("ProxyPassword", proxyPassword);
            }

            using (Session session = new Session())
            {                
                // Connect - Open throws an internal exception which can be ignored
                session.Open(sessionOptions);
                var remoteFilePath = "/" + remoteFileName;

                if (session.FileExists(remoteFilePath))
                    remoteFileLastWriteDate = session.GetFileInfo(remoteFilePath).LastWriteTime.Date;              

                if (!downloadedRemoteFileLastWriteDate.HasValue || remoteFileLastWriteDate.HasValue && remoteFileLastWriteDate.Value > downloadedRemoteFileLastWriteDate)
                {                   
                    session.GetFiles(remoteFilePath, localSaveFilePath).Check();                    
                }
            }           

            return localSaveFilePath;
        }

        public static Mapping GetMappingForBlz(string blz, string routingTableFilePath, string taxonomyName, bool isTest = false)
        {
            DateTime date = DateTime.Now.Date;
            XmlNodeList blzNodes = GetBlzNode(blz, routingTableFilePath);
            Mapping blzMapping = null;

            foreach (XmlNode node in blzNodes)
            {
                IfpMapping mapping = BuildMapping(node.ParentNode);
                if (mapping.ValidFrom >= date
                    && mapping.ValidTo <= date
                    && mapping.Umgebung == UmgebungType.test == isTest)
                {
                    blzMapping = mapping;
                    break;
                }
            }

            if (blzMapping == null)
                throw new NullReferenceException($"BLZ {blz} not found in mapping table.");

            return blzMapping;
        }

        private static XmlNodeList GetBlzNode(string blz, string routingTableFilePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(routingTableFilePath);

            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(doc.NameTable);
            namespaceManager.AddNamespace("mappingFileDefaultNamespace", @"htt//www.ifp.de/namespace/mappings");

            return doc.SelectNodes($@"//mappingFileDefaultNamespace:BLZ[. = '{blz}']", namespaceManager);
        }

        private static IfpMapping BuildMapping(XmlNode mappingNode)
        {
            IfpMapping mapping = new IfpMapping
            {
                date = GetDateAttribute(mappingNode),
                ValidTo = DateTime.MaxValue
            };

            List<Version> mappingVersions = new List<Version>();
            foreach (XmlNode mappingDetails in mappingNode)
            {
                if (mappingDetails.Name == "Umgebung")
                {
                    mapping.Umgebung = GetEnvironment(mappingDetails);
                }
                else if (mappingDetails.Name == "Gueltig_ab")
                {
                    mapping.Gueltig_ab = mappingDetails.InnerText;
                    try
                    {
                        mapping.ValidFrom = XmlConvert.ToDateTime(mapping.Gueltig_ab, XmlDateTimeSerializationMode.Unspecified);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error while setting ValidFrom date: {ex.Message}{Environment.NewLine}{ex.StackTrace}.");
                    }
                }
                else if (mappingDetails.Name == "Gueltig_bis")
                {
                    mapping.Gueltig_bis = mappingDetails.InnerText;
                    try
                    {
                        mapping.ValidTo = XmlConvert.ToDateTime(mapping.Gueltig_bis, XmlDateTimeSerializationMode.Unspecified);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error while setting ValidFrom date: {ex.Message}{Environment.NewLine}{ex.StackTrace}.");
                    }
                }
                else if (mappingDetails.Name == "BLZ")
                {
                    mapping.BLZ = mappingDetails.InnerText;
                }
                else if (mappingDetails.Name == "BIC")
                {
                    mapping.BIC = mappingDetails.InnerText;
                }
                else if (mappingDetails.Name == "Kontakt")
                {
                    mapping.Kontakt = new Kontakt();
                    foreach (XmlNode kontaktDetails in mappingDetails)
                    {
                        if (kontaktDetails.Name == "Mail")
                        {
                            mapping.Kontakt.Mail = kontaktDetails.InnerText;
                        }
                        else if (kontaktDetails.Name == "Telefon")
                        {
                            mapping.Kontakt.Telefon = kontaktDetails.InnerText;
                        }
                    }
                }
                else if (mappingDetails.Name == "IFP-ID")
                {
                    mapping.IFPID = mappingDetails.InnerText;
                }
                else if (mappingDetails.Name == "Version")
                {
                    Version version = new Version
                    {
                        name = GetNameAttribute(mappingDetails)
                    };

                    List<Taxonomie> versionTaxonomies = new List<Taxonomie>();
                    foreach (XmlNode versionDetails in mappingDetails)
                    {
                        if (versionDetails.Name == "URL")
                        {
                            version.URL = versionDetails.InnerText;
                        }
                        else if (versionDetails.Name == "Taxonomie")
                        {
                            Taxonomie taxonomie = new Taxonomie
                            {
                                name = GetNameAttribute(versionDetails)
                            };

                            foreach (XmlNode taxonomieDetails in versionDetails)
                            {
                                if (taxonomieDetails.Name == "Gueltig_ab")
                                {
                                    taxonomie.Gueltig_ab = taxonomieDetails.InnerText;
                                }
                                else if (taxonomieDetails.Name == "Gueltig_bis")
                                {
                                    taxonomie.Gueltig_bis = taxonomieDetails.InnerText;
                                }
                            }

                            versionTaxonomies.Add(taxonomie);
                        }
                        else if (versionDetails.Name == "Verarbeitungsart")
                        {
                            version.Verarbeitungsart = versionDetails.InnerText;
                        }
                    }

                    version.Taxonomie = versionTaxonomies.ToArray();
                    mappingVersions.Add(version);
                    mapping.Version = mappingVersions.ToArray();
                }
            }

            return mapping;
        }

        private static UmgebungType GetEnvironment(XmlNode node)
        {
            List<UmgebungType> umgebungTypes = Enum.GetValues(typeof(UmgebungType)).Cast<UmgebungType>().ToList();
            return umgebungTypes.FirstOrDefault(ut => string.Equals(ut.ToString(), node.InnerText));
        }

        private static string GetNameAttribute(XmlNode node)
        {
            return node.Attributes?["name"] != null
                ? node.Attributes["name"].Value
                : string.Empty;
        }

        private static DateTime GetDateAttribute(XmlNode node)
        {
            return node.Attributes?["date"] != null
                ? DateTime.Parse(node.Attributes["date"].Value)
                : DateTime.MinValue;
        }
    }
}
