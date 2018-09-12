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
using System.Linq;
using System.Runtime.CompilerServices;
using AMANA.IFP.Common;
using AMANA.IFP.Common.Helpers;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Client
{
    public class IfpDataContainer : INotifyPropertyChanged
    {
        
        private string _version;

        private readonly string currentDefaultInstituteMappingVersion = "2017_1_001";
        private readonly string _baseSettingsDirPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\AMANAconsulting";

        private readonly string _settingsFileName = "ifpSettings.xml";
        private readonly string _userSessionElabaInformationFileName = "elbaInformation.xml";
        private readonly string _userSessionHeaderIdentityFileName = "headerIdentity.xml";

        public ElbaInformation ElbaInformation { get; set; }
        public HeaderIdentity HeaderIdentity { get; set; }
        public Client Client { get; set; }
        public HttpProxySettings HttpProxySettings { get; set; }
        public IfpClientSettings IfpClientSettings { get; set; }

        public string Version
        {
            get { return _version; }
            set
            {
                if (!value.Equals(HeaderIdentity.MappingVersion, StringComparison.Ordinal))
                    HeaderIdentity.MappingVersion = value;
                if (value == _version) return;
                _version = value;
                OnPropertyChanged();
            }
        }                        

        public IfpDataContainer(bool userSessionLoadingEnabled = false)
        {
            var settingsFilePath = Path.Combine(_baseSettingsDirPath, _settingsFileName);

            var elbaInformationFilePath = Path.Combine(_baseSettingsDirPath, _userSessionElabaInformationFileName);
            var headerIdentityFilePath = Path.Combine(_baseSettingsDirPath, _userSessionHeaderIdentityFileName);

            ElbaInformation = new ElbaInformation(elbaInformationFilePath);
            HeaderIdentity = new HeaderIdentity(headerIdentityFilePath);
            Version = currentDefaultInstituteMappingVersion;
            
            if (userSessionLoadingEnabled)
            {
                ElbaInformation = ElbaInformation.Load();
                HeaderIdentity = HeaderIdentity.Load();
                
                Version = HeaderIdentity.MappingVersion;
            }            

            Client = new Client();
            HttpProxySettings = new HttpProxySettings();
            IfpClientSettings = new IfpClientSettings(settingsFilePath);
        }

        public RequestResult SendData(Software channelSoftware, bool isTest = false)
        {
            //if (RoutingTableReader.Mappings == null)
            RoutingTableReader.Read(IfpClientSettings.RoutingTableFilePath);

            if (RoutingTableReader.Mappings == null)
                throw new NullReferenceException("Die Routing-Tabelle konnte nicht ausgelesen werden. " +
                                                 "Bitte überprüfen Sie in den allgemeinen Einstellungen, " +
                                                 "ob der Pfad zur Mappingdatei korrekt gesetzt wurde.");

            if (!ElbaInformation.BalanceInformationList.Any()
                || ElbaInformation.BalanceInformationList.First().GetFirstXmlDocument() == null)
                throw new NullReferenceException("Keine XBRL-Datei zum Übermitteln gefunden. " +
                                                 "Bitte geben Sie unter den Abschlussinformationen eine XBRL-Instanz an.");

            ns2BilanzdatenTyp elbaData = ElbaInformation.ToElbaData();
            if (!elbaData.Abschluss.Any())
                throw new ArgumentException("Es wurden keine Abschlüsse zum Übermiteln gefudnen. " +
                                            "Bitte geben Sie mindestens einen Abschluss an.");
            
            if (IfpClientSettings.ValidateIfpData)
            {
                RequestValidator validator = new RequestValidator(elbaData);
                validator.Validate();
                if (!validator.AnfrageBearbeitet)
                    return new RequestResult(validator.CreateQuittung(), true);
            }
            
            if (IfpClientSettings.ValidateGcdData)
            {
                GcdDataValidator validator = new GcdDataValidator();
                if (!validator.Validate(elbaData))
                    return new RequestResult(validator.ResultMessages, true);
            }

            IfpMapping recieverMapping = null;
            Version recieverVersion = null;
            DateTime date = DateTime.Now.Date;
            string taxonomyName = elbaData.Abschluss.First().Taxonomie;

            foreach (IfpMapping mapping in RoutingTableReader.Mappings)
            {
                if (mapping.BLZ == ElbaInformation.RecieverInformation.BankId.Value
                    && mapping.ValidFrom <= date
                    && mapping.ValidTo >= date
                    && mapping.Umgebung == UmgebungType.test == isTest)
                {
                    foreach (Version version in mapping.Version)
                    {
                        foreach (Taxonomie taxonomy in version.Taxonomie)
                        {
                            if (taxonomy.name == taxonomyName
                                && (string.IsNullOrEmpty(taxonomy.Gueltig_ab) || DateTime.Parse(taxonomy.Gueltig_ab) <= date)
                                && (string.IsNullOrEmpty(taxonomy.Gueltig_bis) || DateTime.Parse(taxonomy.Gueltig_bis) >= date))
                            {
                                recieverMapping = mapping;
                                recieverVersion = version;
                                break;
                            }
                        }
                    }
                }
            }

            if (recieverMapping == null)
                throw new ArgumentException(
                    "In der Routing-Tabelle konnte kein Mapping " +
                    $"mit der Bank ID {ElbaInformation.RecieverInformation.BankId.Value} " +
                    $"und der Taxonomie {taxonomyName} gefunden werden." +
                    "Bitte überprüfen Sie, ob die angegebene Bank ID (BLZ) korrekt ist" +
                    "und ob die XBRL-Instanz mit einer unterstützten Taxonomieversion generiert wurde.");

            if (recieverVersion == null)
                throw new NullReferenceException("In der Routing-Tabelle konnte kein Eintrag " +
                                                 $"mit der Taxonomieversion '{Version}' gefunden werden. " +
                                                 "Bitte überprüfen Sie, ob die XBRL-Instanz " +
                                                 "mit einer unterstützen Taxonomieversion generiert wurde.");

            elbaData.Abschluss.First().Software.Erstellung = new ns2SoftwareTyp
            {
                Name = channelSoftware.Name,
                Hersteller = channelSoftware.Manufacturer,
                Version = channelSoftware.Version,
                ID = channelSoftware.Id
            };

            elbaData.Abschluss.First().Software.Versand = new ns2SoftwareTyp
            {
                Name = channelSoftware.Name,
                Hersteller = channelSoftware.Manufacturer,
                Version = channelSoftware.Version,
                ID = channelSoftware.Id
            };

            ns3QuittungTyp quittung = Client.SendElbaData(channelSoftware.ToChannelData(), elbaData,
                HeaderIdentity.ToElbaData(), recieverMapping, recieverVersion, HttpProxySettings, IfpClientSettings.CertificateSettings);

            return new RequestResult(quittung);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}