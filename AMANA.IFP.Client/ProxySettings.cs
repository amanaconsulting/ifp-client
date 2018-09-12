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
using System.IO;
using System.Xml.Serialization;
using AMANA.IFP.Common.Helpers;

namespace AMANA.IFP.Client
{
    [Serializable]
    public class HttpProxySettings
    {
        public enum HttpProxyMode
        {
            NoProxy,
            SystemProxy,
            OwnProxy
        }

        public HttpProxySettings()
        {
        }

        public HttpProxySettings(string settingsFilePath)
        {
            _settingsFilePath = settingsFilePath;
            Load();
        }

        public Uri HttpProxyAddresUri
        {
            get
            {
                Uri proxyUri = null;
                if (ProxyMode == HttpProxyMode.OwnProxy && !String.IsNullOrWhiteSpace(ProxyHost) && !String.IsNullOrWhiteSpace(ProxyPort))
                {
                    proxyUri = new Uri("http://" + ProxyHost + ":" + ProxyPort);
                }

                return proxyUri;
            }
        }

    public string ProxyHost { get; set; }
        public string ProxyPort { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public HttpProxyMode ProxyMode { get; set; }

        private readonly string _settingsFilePath;

        private void Load()
        {
            var filename = PathHelper.GetAbsolutePath(_settingsFilePath);

            if (File.Exists(filename))
            {
                using (Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(HttpProxySettings), typeof(HttpProxySettings).GetNestedTypes());
                    try
                    {
                        var settings = (HttpProxySettings)serializer.Deserialize(stream);
                        settings.CopyTo(this);
                    }
                    catch (Exception)
                    {
                        stream.Close();
                        throw;
                    }

                    stream.Close();
                }
            }           
        }

        public HttpProxySettings Copy()
        {
            return CopyTo(new HttpProxySettings());
        }

        public HttpProxySettings CopyTo(HttpProxySettings settings)
        {
            settings.ProxyHost = ProxyHost;
            settings.ProxyPort = ProxyPort;
            settings.UserName = UserName;
            settings.Password = Password;
            settings.ProxyMode = ProxyMode;

            return settings;
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(HttpProxySettings), typeof(HttpProxySettings).GetNestedTypes());
            using (Stream stream = File.Open(_settingsFilePath, FileMode.Create))
            {
                serializer.Serialize(stream, this);
                stream.Close();
            }
        }
    }
}