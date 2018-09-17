// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public class ContactData : INotifyPropertyChanged
    {
        private string _phoneNumber;
        private string _email;
        public ContactPerson ContactPerson { get; set; }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value == _phoneNumber) return;
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (value == _email) return;
                _email = value;
                OnPropertyChanged();
            }
        }

        public ContactData()
        {
            ContactPerson = new ContactPerson();
        }

        public ns2KontaktdatenAbsenderTyp ToAbsenderElbaData()
        {
            ns2KontaktdatenAbsenderTyp kontaktdaten = new ns2KontaktdatenAbsenderTyp
            {
                Ansprechpartner = ContactPerson.ToElbaData(),
                Telefon = PhoneNumber,
                Email = Email
            };

            return kontaktdaten;
        }

        public ns4KontaktdatenTyp ToKontaktElbaData()
        {
            ns4KontaktdatenTyp kontaktdaten = new ns4KontaktdatenTyp
            {
                Ansprechpartner = ContactPerson.ToElbaData(),
                Telefon = PhoneNumber,
                Email = Email
            };

            return kontaktdaten;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}