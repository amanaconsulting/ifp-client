// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AMANA.IFP.Client
{
    [Serializable]
    public class CertificateSettings : INotifyPropertyChanged
    {
        private StoreLocation _storeLocation;
        private StoreName _storeName;
        private X509FindType _findType;
        private string _findValue;

        public StoreLocation StoreLocation
        {
            get { return _storeLocation; }
            set
            {
                if (value == _storeLocation) return;
                _storeLocation = value;
                OnPropertyChanged();
            }
        }

        public StoreName StoreName
        {
            get { return _storeName; }
            set
            {
                if (value == _storeName) return;
                _storeName = value;
                OnPropertyChanged();
            }
        }

        public X509FindType FindType
        {
            get { return _findType; }
            set
            {
                if (value == _findType) return;
                _findType = value;
                OnPropertyChanged();
            }
        }

        public string FindValue
        {
            get { return _findValue; }
            set
            {
                if (value == _findValue) return;
                _findValue = value;
                OnPropertyChanged();
            }
        }

        public CertificateSettings SetDefaultValues()
        {
            StoreLocation = StoreLocation.CurrentUser;
            StoreName = StoreName.My;
            FindType = X509FindType.FindByIssuerName;
            FindValue = "SCHUFA Holding AG - Zertifizierungsstelle";

            return this;
        }

        public CertificateSettings Copy()
        {
            return CopyTo(new CertificateSettings());
        }

        public CertificateSettings CopyTo(CertificateSettings settings)
        {
            settings.StoreLocation = StoreLocation;
            settings.StoreName = StoreName;
            settings.FindType = FindType;
            settings.FindValue = FindValue;

            return settings;
        }

        public override string ToString()
        {
            return
                $"Store Location: '{StoreLocation}', Store Name: '{StoreName}', Find Type: '{FindType}', Find Value: {FindValue}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}