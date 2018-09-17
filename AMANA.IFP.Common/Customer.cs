// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public class Customer : INotifyPropertyChanged
    {
        private string _name;
        public List<CustomerIdentity> Identities { get; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public Address Address { get; set; }
        public ContactData ContactData { get; set; }

        public Customer()
        {
            Identities = new List<CustomerIdentity>();
            Address = new Address();
            ContactData = new ContactData();
        }

        public ns2BilanzdatenTypKunde ToElbaData()
        {
            ns2BilanzdatenTypKunde kunde = new ns2BilanzdatenTypKunde
            {
                Identifikationen = new ns2IdentifikationKundeTypIdentifikation[Identities.Count]
            };

            for (int i = 0; i < Identities.Count; i++)
                kunde.Identifikationen[i] = Identities[i].ToElbaData();

            kunde.Name = Name;
            kunde.Adresse = Address.ToElbaData();
            kunde.Kontaktdaten = ContactData.ToKontaktElbaData();

            return kunde;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}