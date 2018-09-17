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
    public class BankId : INotifyPropertyChanged
    {
        private BankIdTypes _bankIdType;
        private string _value;
        private string _name;

        public enum BankIdTypes
        {
            BLZ,
            Provider,
            SpezialInstitut
        }

        public BankIdTypes BankIdType
        {
            get { return _bankIdType; }
            set
            {
                if (value == _bankIdType) return;
                _bankIdType = value;
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

        public static string BankIdToElbaString(BankIdTypes idType)
        {
            switch (idType)
            {
                case BankIdTypes.BLZ:
                    return "BLZ";
                case BankIdTypes.Provider:
                    return "Provider";
                case BankIdTypes.SpezialInstitut:
                    return "SpezialInstitut";
            }

            return string.Empty;
        }

        public static bool IsStringBankId(string possibleType)
        {
            IEnumerable<BankIdTypes> bankIdTypes = Enum.GetValues(typeof(BankIdTypes)).Cast<BankIdTypes>();
            return bankIdTypes.Any(bankIdType => string.Equals(BankIdToElbaString(bankIdType), possibleType));
        }

        public ns3BankIDTyp ToElbaData()
        {
            ns3BankIDTyp bankId = new ns3BankIDTyp
            {
                Art = BankIdToElbaString(BankIdType),
                Wert = Value,
                Name = Name
            };

            return bankId;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}