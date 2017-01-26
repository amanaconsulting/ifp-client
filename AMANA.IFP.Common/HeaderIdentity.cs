// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
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
    public class HeaderIdentity : INotifyPropertyChanged
    {
        private string _fipId;
        private string _instituteId;
        private string _client;
        private string _provider;

        public string FipId
        {
            get { return _fipId; }
            set
            {
                if (value == _fipId) return;
                _fipId = value;
                OnPropertyChanged();
            }
        }

        public string InstituteId
        {
            get { return _instituteId; }
            set
            {
                if (value == _instituteId) return;
                _instituteId = value;
                OnPropertyChanged();
            }
        }

        public string Client
        {
            get { return _client; }
            set
            {
                if (value == _client) return;
                _client = value;
                OnPropertyChanged();
            }
        }

        public string Provider
        {
            get { return _provider; }
            set
            {
                if (value == _provider) return;
                _provider = value;
                OnPropertyChanged();
            }
        }

        public ns1IdentityHeaderTyp ToElbaData()
        {
            ns1IdentityHeaderTyp headerIdentity = new ns1IdentityHeaderTyp
            {
                institute = GetHeaderInstitute(),
                userid = FipId,
                provider = Provider
            };

            return headerIdentity;
        }

        private ns1IdentityHeaderTypInstitute GetHeaderInstitute()
        {
            ns1IdentityHeaderTypInstitute institute = new ns1IdentityHeaderTypInstitute
            {
                client = Client,
                id = InstituteId
            };

            return institute;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}