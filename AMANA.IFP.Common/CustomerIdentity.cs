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
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public enum IdentityTypes
    {
        Kundennummer
    }
    public class CustomerIdentity : INotifyPropertyChanged
    {
        private IdentityTypes _identityType;
        private string _value;        

        public IdentityTypes IdentityType
        {
            get { return _identityType; }
            set
            {
                if (value == _identityType) return;
                _identityType = value;
                OnPropertyChanged();
            }
        }

        public string Value
        {
            get { return _value; }
            set
            {
                if (value == _value) return;
                _value = value;
                OnPropertyChanged();
            }
        }

        public static string IdentityTypeToElbaString(IdentityTypes identityType)
        {
            switch (identityType)
            {
                case IdentityTypes.Kundennummer:
                    return "Kundennummer";
            }

            return string.Empty;
        }

        public CustomerIdentity Copy()
        {
            return CopyTo(new CustomerIdentity());
        }

        public CustomerIdentity CopyTo(CustomerIdentity identity)
        {
            identity.IdentityType = IdentityType;
            identity.Value = Value;

            return identity;
        }

        public static bool IsStringIdentityType(string possibleType)
        {
            IEnumerable<IdentityTypes> identityTypes = Enum.GetValues(typeof(IdentityTypes)).Cast<IdentityTypes>();
            return identityTypes.Any(identityType => string.Equals(IdentityTypeToElbaString(identityType), possibleType));
        }

        public ns2IdentifikationKundeTypIdentifikation ToElbaData()
        {
            ns2IdentifikationKundeTypIdentifikation identifikation = new ns2IdentifikationKundeTypIdentifikation
            {
                Art = IdentityTypeToElbaString(IdentityType),
                Wert = Value
            };

            return identifikation;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}