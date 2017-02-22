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
using System.Linq;
using System.Runtime.CompilerServices;
using AMANA.IFP.Common;
using AMANA.IFP.Common.Helpers;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Client
{
    public class IfpDataContainer : INotifyPropertyChanged
    {
        private string _settingsFilePath;
        private string _version;

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
                if (value == _version) return;
                _version = value;
                OnPropertyChanged();
            }
        }


        public string SettingsFilePath
        {
            get
            {
                if (!string.IsNullOrEmpty(_settingsFilePath))
                    return _settingsFilePath;

                return
                    $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\AMANAconsulting\ifpSettings.xml";
            }
            set { _settingsFilePath = value; }
        }

        public IfpDataContainer(string settingsFilePath)
            : this()
        {
            
            SettingsFilePath = settingsFilePath;
            IfpClientSettings = IfpClientSettings.Load(SettingsFilePath);
        }

        public IfpDataContainer(IfpClientSettings settings)
            : this()
        {
            IfpClientSettings = settings;
        }

        private IfpDataContainer()
        {
            ElbaInformation = new ElbaInformation();
            HeaderIdentity = new HeaderIdentity();
            Client = new Client();
            HttpProxySettings = new HttpProxySettings();
            IfpClientSettings = new IfpClientSettings();
        }

        public RequestResult SendData(Software channelSoftware, bool isTest = false)
        {
            //if (RoutingTableReader.Mappings == null)
            RoutingTableReader.Read(IfpClientSettings.RoutingTableFilePath);

            if (RoutingTableReader.Mappings == null)
                throw new NullReferenceException("Die Routing-Tabelle konnte nicht ausgelesen werden. " +
                                                 "Bitte überprüfen Sie in den allgemeinen Einstellungen, " +
                                                 "ob der Pfad zur Mappingdatei korrekt gesetzt wurde.");

            if (!ElbaInformation.BalanceInformation.Any()
                || ElbaInformation.BalanceInformation.First().GetFirstXmlDocument() == null)
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