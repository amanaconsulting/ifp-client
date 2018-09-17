// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public class Software
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Version { get; set; }
        public string Manufacturer { get; set; }

        public ns2SoftwareTyp ToElbaData()
        {
            ns2SoftwareTyp elbaSoftware = new ns2SoftwareTyp
            {
                Name = Name,
                ID = Id,
                Version = Version,
                Hersteller = Manufacturer
            };

            return elbaSoftware;
        }

        public ns1ChannelHeaderTyp ToChannelData()
        {
            ns1ChannelHeaderTyp channel = new ns1ChannelHeaderTyp
            {
                idSoftwareProducer = Id,
                softwareProducer = Manufacturer,
                name = Name,
                version = Version
            };

            return channel;
        }

        public Software Copy()
        {
            return CopyTo(new Software());
        }

        public Software CopyTo(Software software)
        {
            software.Name = Name;
            software.Id = Id;
            software.Version = Version;
            software.Manufacturer = Manufacturer;

            return software;
        }
    }
}