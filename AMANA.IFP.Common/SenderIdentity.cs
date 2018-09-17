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
    public enum SenderIdentityTypes
    {
        BeraterId,
        FirmenId,
        IfpIdBeauftragter,
        IfpIdFirma
    }

    public class SenderIdentity : INotifyPropertyChanged
    {
        private SenderIdentityTypes _identityType;
        private string _value;        

        public SenderIdentityTypes IdentityType
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

        public static string IdentityTypeToElbaString(SenderIdentityTypes identityType)
        {
            switch (identityType)
            {
                case SenderIdentityTypes.BeraterId:
                    return "Berater-ID";
                case SenderIdentityTypes.FirmenId:
                    return "Firmen-ID";
                case SenderIdentityTypes.IfpIdBeauftragter:
                    return "IFP-ID-BEAUF";
                case SenderIdentityTypes.IfpIdFirma:
                    return "IFP-ID-Firma";
            }

            return string.Empty;
        }

        public SenderIdentity Copy()
        {
            return CopyTo(new SenderIdentity());
        }

        public SenderIdentity CopyTo(SenderIdentity identity)
        {
            identity.IdentityType = IdentityType;
            identity.Value = Value;

            return identity;
        }

        public static bool IsStringIdentityType(string possibleType)
        {
            IEnumerable<SenderIdentityTypes> identityTypes = Enum.GetValues(typeof(SenderIdentityTypes)).Cast<SenderIdentityTypes>();
            return identityTypes.Any(identityType => string.Equals(IdentityTypeToElbaString(identityType), possibleType));
        }

        public ns2IdentifikationSteuerberaterTypIdentifikation ToElbaData()
        {
            ns2IdentifikationSteuerberaterTypIdentifikation identifikation =
                new ns2IdentifikationSteuerberaterTypIdentifikation
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