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

namespace AMANA.IFP.Client
{
    [Serializable]
    public class IfpClientSettings : INotifyPropertyChanged
    {
        private bool _validateIfpData;
        private bool _validateGcdData;
        private string _routingTableFilePath;
        private readonly string _settingsFilePath;

        public bool ValidateIfpData
        {
            get { return _validateIfpData; }
            set
            {
                if (value == _validateIfpData) return;
                _validateIfpData = value;
                OnPropertyChanged();
            }
        }

        public bool ValidateGcdData
        {
            get { return _validateGcdData; }
            set
            {
                if (value == _validateGcdData) return;
                _validateGcdData = value;
                OnPropertyChanged();
            }
        }

        public string RoutingTableFilePath
        {
            get { return _routingTableFilePath; }
            set
            {
                if (value == _routingTableFilePath) return;
                _routingTableFilePath = value;
                OnPropertyChanged();
            }
        }

        public CertificateSettings CertificateSettings { get; set; }

        private void Load()
        {            
            var filename = PathHelper.GetAbsolutePath(_settingsFilePath);            

            if (File.Exists(filename))
            {
                using (Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(IfpClientSettings), typeof(IfpClientSettings).GetNestedTypes());
                    try
                    {
                        var settings = (IfpClientSettings) serializer.Deserialize(stream);
                        settings.CopyTo(this);
                    }
                    catch (Exception)
                    {
                        stream.Close();
                        throw;
                    }

                    stream.Close();
                }
            }
            else
            {
                ValidateIfpData = true;
                CertificateSettings.SetDefaultValues();
            }
        }

        private IfpClientSettings()
        {
            CertificateSettings = new CertificateSettings();
        }

        public IfpClientSettings(string settingsFilepath)
        {
            _settingsFilePath = settingsFilepath;
            Load();
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(IfpClientSettings), typeof(IfpClientSettings).GetNestedTypes());
            using (Stream stream = File.Open(_settingsFilePath, FileMode.Create))
            {
                serializer.Serialize(stream, this);
                stream.Close();
            }
        }

        public IfpClientSettings Copy()
        {
            return CopyTo(new IfpClientSettings());
        }

        public IfpClientSettings CopyTo(IfpClientSettings settings)
        {
            settings.ValidateIfpData = ValidateIfpData;
            settings.ValidateGcdData = ValidateGcdData;
            settings.RoutingTableFilePath = RoutingTableFilePath;
            settings.CertificateSettings = CertificateSettings.Copy();

            return settings;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}