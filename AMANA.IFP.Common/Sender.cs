// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System.Collections.Generic;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public class Sender
    {
        public List<SenderIdentity> SenderIdentities { get; }
        public Address Address { get; set; }
        public Name SenderName { get; set; }
        public ContactData ContactData { get; set; }

        public Sender()
        {
            SenderIdentities = new List<SenderIdentity>();
            Address = new Address();
            SenderName = new Name();
            ContactData = new ContactData();
        }

        public ns2KanzleiTyp ToElbaData()
        {
            ns2KanzleiTyp kanzlei = new ns2KanzleiTyp
            {
                Identifikationen = new ns2IdentifikationSteuerberaterTypIdentifikation[SenderIdentities.Count]
            };

            kanzlei.Identifikationen = new ns2IdentifikationSteuerberaterTypIdentifikation[SenderIdentities.Count];

            for (int i = 0; i < SenderIdentities.Count; i++)
                kanzlei.Identifikationen[i] = SenderIdentities[i].ToElbaData();

            kanzlei.Adresse = Address.ToElbaData();
            kanzlei.NameAbsender = SenderName.ToElbaData();
            kanzlei.Kontaktdaten = ContactData.ToAbsenderElbaData();
            return kanzlei;
        }
    }
}