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
using System.Linq;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public class ElbaInformation
    {
        public Sender SenderInformation { get; set; }
        public Receiver RecieverInformation { get; set; }
        public Customer CustomerInformation { get; set; }
        public List<BalanceInformation> BalanceInformation { get; set; }

        public BalanceInformation PrimaryBalanceInformation
        {
            get { return BalanceInformation.FirstOrDefault(); }
            set
            {
                if (BalanceInformation.Any())
                    BalanceInformation.RemoveAt(0);

                BalanceInformation.Insert(0, value);
            }
        }

        public ElbaInformation()
        {
            SenderInformation = new Sender();
            RecieverInformation = new Receiver();
            CustomerInformation = new Customer();
            BalanceInformation = new List<BalanceInformation>();
            BalanceInformation.Add(new BalanceInformation());
        }

        public ns2BilanzdatenTyp ToElbaData()
        {
            ns2BilanzdatenTyp balanceData = new ns2BilanzdatenTyp
            {
                Absender = SenderInformation.ToElbaData(),
                Empfaenger = RecieverInformation.ToElbaData(),
                Kunde = CustomerInformation.ToElbaData(),
                Abschluss = new ns2AbschlussTyp[BalanceInformation.Count]
            };

            for (int i = 0; i < BalanceInformation.Count; i++)
                balanceData.Abschluss[i] = BalanceInformation[i].ToElbaData();

            return balanceData;
        }
    }
}
