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

namespace AMANA.IFP.Client
{
    public class HttpProxySettings
    {
        public enum HttpProxyMode
        {
            NoProxy,
            SystemProxy,
            OwnProxy
        }

        public Uri ProxyAddresUri => new Uri(ProxyAddress);
        public string ProxyAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public HttpProxyMode ProxyMode { get; set; }

        public HttpProxySettings Copy()
        {
            return CopyTo(new HttpProxySettings());
        }

        public HttpProxySettings CopyTo(HttpProxySettings settings)
        {
            settings.ProxyAddress = ProxyAddress;
            settings.UserName = UserName;
            settings.Password = Password;
            settings.ProxyMode = ProxyMode;

            return settings;
        }
    }
}