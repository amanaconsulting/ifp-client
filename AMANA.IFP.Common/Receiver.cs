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
    public class Receiver
    {
        public BankId BankId { get; set; }
        public Address Address { get; set; }
        public ContactPerson ContactPerson { get; set; }

        public Receiver()
        {
            BankId = new BankId();
            Address = new Address();
            ContactPerson = new ContactPerson();
        }

        public ns2EmpfaengerTyp ToElbaData()
        {
            ns2EmpfaengerTyp empfaenger = new ns2EmpfaengerTyp
            {
                BankID = BankId.ToElbaData(),
                Anschrift = Address.ToElbaData(),
                Ansprechpartner = ContactPerson.ToElbaData()
            };

            return empfaenger;
        }
    }
}