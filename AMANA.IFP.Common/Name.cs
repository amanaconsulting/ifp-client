// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
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
    public class Name
    {
        public string FullName { get; set; }
        public string NameAffix { get; set; }
        public string NameAddition { get; set; }

        public ns4NameEinfachTyp ToElbaData()
        {
            ns4NameEinfachTyp name = new ns4NameEinfachTyp
            {
                Name = FullName,
                Namenszusatz = NameAffix,
                Namensergaenzung = NameAddition
            };

            return name;
        }
    }
}