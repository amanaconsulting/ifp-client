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
    public class Address : INotifyPropertyChanged
    {
        private string _state;
        private string _country;
        private bool _hasPostOfficeBox;
        private bool _hasHomeAddress;
        public HomeAddress HomeAddress { get; set; }

        public bool HasHomeAddress
        {
            get { return _hasHomeAddress; }
            set { _hasHomeAddress = value; }
        }

        public PostOfficeBox PostOfficeBox { get; set; }

        public bool HasPostOfficeBox
        {
            get { return _hasPostOfficeBox; }
            set { _hasPostOfficeBox = value; }
        }

        public string Country
        {
            get { return _country; }
            set
            {
                if (value == _country) return;
                _country = value;
                OnPropertyChanged();
            }
        }

        public string State
        {
            get { return _state; }
            set
            {
                if (value == _state) return;
                _state = value;
                OnPropertyChanged();
            }
        }

        public Address()
        {
            HomeAddress = new HomeAddress();
            PostOfficeBox = new PostOfficeBox();
        }

        public ns4AdresseTyp ToElbaData()
        {
            ns4AdresseTyp adresse = new ns4AdresseTyp();
            if (HasHomeAddress)
                adresse.Hausanschrift = HomeAddress.ToElbaData();

            if (HasPostOfficeBox)
                adresse.Postfach = PostOfficeBox.ToElbaData();

            adresse.Land = Country;
            adresse.Bundesland = State;

            return adresse;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}