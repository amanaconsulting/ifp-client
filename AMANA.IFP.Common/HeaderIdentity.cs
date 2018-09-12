// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt

using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using AMANA.IFP.Common.Helpers;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    [Serializable]
    public class HeaderIdentity : INotifyPropertyChanged
    {
        private string _userId;
        private string _instituteId;
        private string _instituteIdType;
        private string _client;
        private string _provider;
        private readonly string _serializedObjectFilePath;

        private HeaderIdentity()
        {
        }

        public HeaderIdentity(string serializedObjectFilePath):this()
        {
            _serializedObjectFilePath = serializedObjectFilePath;            
        }

        public string UserId
        {
            get { return _userId; }
            set
            {
                if (value == _userId) return;
                _userId = value;
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

        public string InstituteIdType
        {
            get { return _instituteIdType; }
            set
            {
                if (value == _instituteIdType) return;
                _instituteIdType = value;
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

        public string MappingVersion { get; set; }

        public ns1IdentityHeaderTyp ToElbaData()
        {
            ns1IdentityHeaderTyp headerIdentity = new ns1IdentityHeaderTyp
            {
                institute = GetHeaderInstitute(),
                userid = UserId,
                provider = Provider
            };

            return headerIdentity;
        }

        public HeaderIdentity Load()
        {            
            var desializedHeaderIdentity = GenericXmlSerializerHelper.DeserializeFromFile<HeaderIdentity>(_serializedObjectFilePath);
            if (desializedHeaderIdentity != null)
            {
                UserId = desializedHeaderIdentity.UserId;
                InstituteId = desializedHeaderIdentity.InstituteId;
                InstituteIdType = desializedHeaderIdentity.InstituteIdType;
                Client = desializedHeaderIdentity.Client;
                Provider = desializedHeaderIdentity.Provider;
            }

            return this;
        }

        public void Save()
        {
            GenericXmlSerializerHelper.SerializeToFile(_serializedObjectFilePath, this);
        }

        public bool IsStoredAsFile()
        {
            return File.Exists(_serializedObjectFilePath);
        }

        public void DeleteStoredFile()
        {
            File.Delete(_serializedObjectFilePath);
        }

        private ns1IdentityHeaderTypInstitute GetHeaderInstitute()
        {           
            ns1IdentityHeaderTypInstitute institute = new ns1IdentityHeaderTypInstitute
            {
                client = Client,
                id = InstituteId,
                idType = InstituteIdType
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