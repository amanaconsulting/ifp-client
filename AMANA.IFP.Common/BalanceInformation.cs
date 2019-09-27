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
using System.Xml;
using AMANA.IFP.Common.Helpers;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public enum BalanceTypes
    {
        HgbFinal,
        HgbVorlaufig,
        HgbZwischen,
        SteuerFinal,
        SteuerVorlaufig,
        SteuerZwischen,
        EurFinal,
        EurVorlaufig,
        EurZwischen,
        Bwa,
        Sonstige
    }

    public enum ConsolidationTypes
    {
        Einzel,
        Konzern,
        Teilkonzern
    }

    public enum TaxonomyTypes
    {
        Hgb62,
        Hgb61,
        Hgb60,
        Hgb54,
        Eur10
    }

    public enum IdentTypes
    {
        None = -1,
        NotIdentity = 0,
        TechnicalIdentity = 100,
        ManualIdentity = 200,
        ManualIdentityResubmission = 201
    }

    public class BalanceInformation : INotifyPropertyChanged
    {
        public const string XbrlGcdDataNamespacePrefix = "gcdData";
        public const string XbrlInstanceNamespacePrefix = "xbrlInstance";
        public const string XbrlLinkbaseNamespacePrefix = "xbrlLinkbase";

        private const string _conceptNameUserSpecificDocumentInformation = "genInfo.doc.userSpecific";

        private const string _xLinkNamespace = "http://www.w3.org/1999/xlink";
        private const string _gcdTaxonomyPrefix = "http://www.xbrl.de/taxonomies/de-gcd";

        private readonly string[] _Hgb_6_2 = new string[] { "http://www.xbrl.de/taxonomies/de-bra-2018-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-fi-2018-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-gaap-ci-2018-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-ins-2018-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-pi-2018-04-01"};

        private readonly string[] _Hgb_6_1 = new string[] { "http://www.xbrl.de/taxonomies/de-bra-2017-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-fi-2017-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-gaap-ci-2017-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-ins-2017-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-pi-2017-04-01"};

        private readonly string[] _Hgb_6_0 = new string[] { "http://www.xbrl.de/taxonomies/de-bra-2016-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-fi-2016-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-gaap-ci-2016-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-ins-2016-04-01",
                                                            "http://www.xbrl.de/taxonomies/de-pi-2016-04-01"};

        private readonly string[] _Hgb_5_4 = new string[] { "http://www.xbrl.de/taxonomies/de-bra-2015-04-03",
                                                            "http://www.xbrl.de/taxonomies/de-fi-2015-04-03",
                                                            "http://www.xbrl.de/taxonomies/de-gaap-ci-2015-04-03",
                                                            "http://www.xbrl.de/taxonomies/de-ins-2015-04-03",
                                                            "http://www.xbrl.de/taxonomies/de-pi-2015-04-03"};

        private const string _Eur_1_0 = "http://www.xbrl.de/taxonomies/de-euer-2015-12-03";

        private string _xbrlFilePath;
        private string _xbrlFileContent;
        private XmlDocument _xmlDocument;
        private XmlNamespaceManager _xmlDocNamespaceManager;
        private string _taxonomy;
        private string _accounts;
        private string _comment;
        private IdentTypes _identType;
        private ConsolidationTypes _consolidationType;
        private DateTime _dueDate;
        private BalanceTypes _balanceType;

       

        public static string GetSubmissionIdentType(IdentTypes type)
        {
            switch (type)
            {
                case IdentTypes.NotIdentity:
                    return "000";
                case IdentTypes.TechnicalIdentity:
                    return "100";
                case IdentTypes.ManualIdentity:
                    return "200";
                case IdentTypes.ManualIdentityResubmission:
                    return "201";
            }

            return null;
        }

        public Software SendingSoftware { get; set; }
        public Software CreationSoftware { get; set; }

        public BalanceTypes BalanceType
        {
            get { return _balanceType; }
            set
            {
                if (value == _balanceType) return;
                _balanceType = value;
                OnPropertyChanged();
            }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set
            {
                if (value.Equals(_dueDate)) return;
                _dueDate = value;
                OnPropertyChanged();
            }
        }

        public ConsolidationTypes ConsolidationType
        {
            get { return _consolidationType; }
            set
            {
                if (value == _consolidationType) return;
                _consolidationType = value;
                OnPropertyChanged();
            }
        }

        public string Taxonomy
        {
            get { return _taxonomy; }
            set
            {
                if (value == _taxonomy) return;
                _taxonomy = value;
                OnPropertyChanged();
            }
        }

        public string Accounts
        {
            get { return _accounts; }
            set
            {
                if (value == _accounts) return;
                _accounts = value;
                OnPropertyChanged();
            }
        }

        public IdentTypes IdentType
        {
            get { return _identType; }
            set
            {
                if (value == _identType) return;
                _identType = value;
                OnPropertyChanged();
            }
        }

        public string Comment
        {
            get { return _comment; }
            set
            {
                if (value == _comment) return;
                _comment = value;
                OnPropertyChanged();
            }
        }

        public List<Attachment> Attachments { get; set; }

        public string XbrlFilePath
        {
            get
            {
                if (!HasLocalFile)
                    return "Im Cache geladene XBRL-Instanz.";

                return _xbrlFilePath;
            }
            set
            {
                SetXbrlFilePath(value);
            }
        }

        /// <summary>
        /// The path to the XBRL-File. You can either define a path to a XBRL file
        /// or the content of the submitted XBRL.
        /// </summary>
        public BalanceInformation SetXbrlFilePath(string path)
        {
            ResetXmlDocument();
            _xbrlFileContent = string.Empty;
            _xbrlFilePath = path;
            return this;
        }

        /// <summary>
        /// The XBRL content. You can eithe define a path to a XBRL file
        /// or the content of the submitted XBRL.
        /// </summary>
        public BalanceInformation SetXbrlFileContent(string xmlFileContent)
        {
            ResetXmlDocument();
            _xbrlFilePath = string.Empty;
            _xbrlFileContent = xmlFileContent;
            return this;
        }

        public bool HasLocalFile => string.IsNullOrEmpty(_xbrlFileContent);

        public static string BalanceTypeToElbaString(BalanceTypes type)
        {
            switch (type)
            {
                case BalanceTypes.HgbFinal:
                    return "HGB_final";
                case BalanceTypes.HgbVorlaufig:
                    return "HGB_vorläufig";
                case BalanceTypes.HgbZwischen:
                    return "HGB_zwischen";
                case BalanceTypes.SteuerFinal:
                    return "Steuer_final";
                case BalanceTypes.SteuerVorlaufig:
                    return "Steuer_vorläufig";
                case BalanceTypes.SteuerZwischen:
                    return "Steuer_zwischen";
                case BalanceTypes.EurFinal:
                    return "EÜR_final";
                case BalanceTypes.EurVorlaufig:
                    return "EÜR_vorläufig";
                case BalanceTypes.EurZwischen:
                    return "EÜR_zwischen";
                case BalanceTypes.Bwa:
                    return "BWA";
                case BalanceTypes.Sonstige:
                    return "Sonstige";
            }

            return string.Empty;
        }

        public static XmlNamespaceManager SetupNamespaceManager(XmlDocument balanceDocument)
        {
            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(balanceDocument.NameTable);
            namespaceManager.AddNamespace(XbrlInstanceNamespacePrefix, @"http://www.xbrl.org/2003/instance");
            namespaceManager.AddNamespace(XbrlLinkbaseNamespacePrefix, @"http://www.xbrl.org/2003/linkbase");

            XmlNodeList schemaRefs = GetSchemaRefNodes(balanceDocument, namespaceManager);
            namespaceManager.AddNamespace(XbrlGcdDataNamespacePrefix, GetGcdNamespace(schemaRefs));

            return namespaceManager;
        }

        public static XmlNodeList GetSchemaRefNodes(XmlDocument balanceDocument, XmlNamespaceManager namespaceManager)
        {
            XmlNode instanceNode = balanceDocument.SelectSingleNode($@"//{XbrlInstanceNamespacePrefix}:xbrl", namespaceManager);

            XmlNodeList schemaRefs = null;
            if (instanceNode != null)
                schemaRefs = instanceNode.SelectNodes($@"//{XbrlLinkbaseNamespacePrefix}:schemaRef", namespaceManager);

            return schemaRefs;
        }

        public BalanceInformation Copy()
        {
            return CopyTo(new BalanceInformation());
        }

        public BalanceInformation CopyTo(BalanceInformation information)
        {
            information.SendingSoftware = SendingSoftware.Copy();
            information.CreationSoftware = CreationSoftware.Copy();
            information.BalanceType = BalanceType;
            information.DueDate = DueDate;
            information.ConsolidationType = ConsolidationType;
            information.Taxonomy = Taxonomy;
            information.Accounts = Accounts;
            information.IdentType = IdentType;
            information.Comment = Comment;

            if (HasLocalFile)
                information.SetXbrlFilePath(_xbrlFilePath);
            else
                information.SetXbrlFileContent(_xbrlFileContent);

            foreach (Attachment attachment in Attachments)
                information.Attachments.Add(attachment.Copy());

            return information;
        }

        public static bool IsStringBalanceType(string possibleType)
        {
            IEnumerable<BalanceTypes> balanceTypes = Enum.GetValues(typeof(BalanceTypes)).Cast<BalanceTypes>();
            return balanceTypes.Any(balanceType => string.Equals(BalanceTypeToElbaString(balanceType), possibleType));
        }

        public static string ConsolidationTypeToElbaString(ConsolidationTypes type)
        {
            switch (type)
            {
                case ConsolidationTypes.Einzel:
                    return "EINZEL";
                case ConsolidationTypes.Konzern:
                    return "KONZERN";
                case ConsolidationTypes.Teilkonzern:
                    return "TEILKONZ";
            }

            return string.Empty;
        }

        public static bool IsStringConsolidationType(string possibleType)
        {
            IEnumerable<ConsolidationTypes> consolidationTypes = Enum.GetValues(typeof(ConsolidationTypes)).Cast<ConsolidationTypes>();
            return consolidationTypes.Any(consolidationType => string.Equals(ConsolidationTypeToElbaString(consolidationType), possibleType));
        }

        public static string TaxonomyTypeToElbaString(TaxonomyTypes type)
        {
            switch (type)
            {
                case TaxonomyTypes.Hgb62:
                    return "HGB_6.2";
                case TaxonomyTypes.Hgb61:
                    return "HGB_6.1";
                case TaxonomyTypes.Hgb60:
                    return "HGB_6.0";
                case TaxonomyTypes.Hgb54:
                    return "HGB_5.4";
                case TaxonomyTypes.Eur10:
                    return "EÜR:1.0";
            }

            return string.Empty;
        }

        public static bool IsStringTaxonomyType(string possibleType)
        {
            IEnumerable<TaxonomyTypes> taxonomyTypes = Enum.GetValues(typeof(TaxonomyTypes)).Cast<TaxonomyTypes>();
            return taxonomyTypes.Any(taxonomyType => string.Equals(TaxonomyTypeToElbaString(taxonomyType), possibleType));
        }

        public static string IdentTypeToElbaString(IdentTypes type)
        {
            switch (type)
            {
                case IdentTypes.NotIdentity:
                    return "000";
                case IdentTypes.TechnicalIdentity:
                    return "100";
                case IdentTypes.ManualIdentity:
                    return "200";
                case IdentTypes.ManualIdentityResubmission:
                    return "201";
            }

            return string.Empty;
        }

        public static bool IsStringIdentType(string possibleType)
        {
            IEnumerable<IdentTypes> identTypes = Enum.GetValues(typeof(IdentTypes)).Cast<IdentTypes>();
            return identTypes.Any(identType => string.Equals(IdentTypeToElbaString(identType), possibleType));
        }

        public BalanceInformation()
        {
            IdentType = IdentTypes.None;
            Attachments = new List<Attachment>();
            DueDate = DateTime.Now.Date;
        }

        public XmlDocument GetFirstXmlDocument()
        {
            if (_xmlDocument != null)
                return _xmlDocument;

            if (string.IsNullOrEmpty(_xbrlFilePath) && string.IsNullOrEmpty(_xbrlFileContent))
                return null;

            _xmlDocument = new XmlDocument();
            if (HasLocalFile)
                _xmlDocument.Load(_xbrlFilePath);
            else
                _xmlDocument.LoadXml(_xbrlFileContent);

            _xmlDocNamespaceManager = SetupNamespaceManager(_xmlDocument);
            return _xmlDocument;
        }

        public string GetGcdNodeValue(string gcdConcept)
        {
            XmlDocument doc = GetFirstXmlDocument();
            if (doc == null)
                return string.Empty;

            return GcdDataValidator.GetGcdNodeValue(doc.DocumentElement, _xmlDocNamespaceManager, gcdConcept);
        }

        public ns2AbschlussTyp ToElbaData(XmlDocument balanceDocument)
        {
            XmlNode instanceNode = balanceDocument.SelectSingleNode($@"//{XbrlInstanceNamespacePrefix}:xbrl", _xmlDocNamespaceManager);
            XmlNodeList schemaRefs = GetSchemaRefNodes(balanceDocument, _xmlDocNamespaceManager);

            ns2AbschlussTyp abschluss = new ns2AbschlussTyp
            {
                Bilanz = GetBilanzElbaData(),
                Taxonomie = GetTaxonomyVersion(schemaRefs),
                Daten = GetAbschlussDaten(instanceNode as XmlElement),
                Software = GetSoftwareData(),
                IdentMerkmal = GetSubmissionIdentType(IdentType),
                Kontenrahmen = string.IsNullOrEmpty(Accounts) ? null : Accounts,
                Notiz = string.IsNullOrEmpty(Comment) ? null : Comment
            };

            return abschluss;
        }

        public ns2AbschlussTyp ToElbaData()
        {
            XmlDocument doc = GetFirstXmlDocument();
            return ToElbaData(doc);
        }

        private void ResetXmlDocument()
        {
            _xmlDocument = null;
            _xmlDocNamespaceManager = null;
        }

        private ns2AbschlussTypSoftware GetSoftwareData()
        {
            ns2AbschlussTypSoftware software = new ns2AbschlussTypSoftware();

            if (CreationSoftware != null)
                software.Erstellung = CreationSoftware.ToElbaData();

            if (SendingSoftware != null)
                software.Versand = SendingSoftware.ToElbaData();

            return software;
        }

        private ns2AbschlussTypBilanz GetBilanzElbaData()
        {
            ns2AbschlussTypBilanz bilanz = new ns2AbschlussTypBilanz
            {
                Abschlussart = BalanceTypeToElbaString(BalanceType),
                Abschlussstichtag = DueDate,
                Bilanzierungsebene = ConsolidationTypeToElbaString(ConsolidationType)
            };

            return bilanz;
        }

        private ns2AbschlussTypDaten GetAbschlussDaten(XmlElement xbrlRootNode)
        {
            ns2AbschlussTypDaten daten = new ns2AbschlussTypDaten
            {
                XbrlAbschlussdaten = new ns2XbrlAbschlussdatenTyp
                {
                    XBRL = new ns2XbrlAbschlussdatenTypXBRL {Any = new XmlElement[1]}
                }
            };

            string attachmentTimestamp = GetGcdNodeValue(_conceptNameUserSpecificDocumentInformation);
            if (string.IsNullOrEmpty(attachmentTimestamp))
                attachmentTimestamp = Attachment.GetAttachmentTimeStamp();

            daten.XbrlAbschlussdaten.XBRL.Any[0] = xbrlRootNode ;
            daten.Anhaenge = new ns3BinaerAnhangTyp[Attachments.Count];
            for (int i = 0; i < Attachments.Count; i++)
                daten.Anhaenge[i] = Attachments[i].ToElbaData(attachmentTimestamp);

            return daten;
        }

        private static string GetGcdNamespace(XmlNodeList schemaRefNodes)
        {
            if (schemaRefNodes != null)
            {
                foreach (XmlNode node in schemaRefNodes)
                {
                    var attribute = node.Attributes?["href", _xLinkNamespace];
                    if (attribute != null && attribute.Value.StartsWith(_gcdTaxonomyPrefix))
                        return attribute.Value.Substring(0, attribute.Value.LastIndexOf('/'));
                }
            }

            return string.Empty;
        }

        private string GetTaxonomyVersion(XmlNodeList schemaRefNodes)
        {
            if (schemaRefNodes != null)
            {
                foreach (XmlNode node in schemaRefNodes)
                {
                    var attribute = node.Attributes?["href", _xLinkNamespace];
                    if (attribute != null && !attribute.Value.StartsWith(_gcdTaxonomyPrefix))
                    {
                        if (_Hgb_6_2.Any(attribute.Value.StartsWith))
                            return "HGB_6.2";

                        if (_Hgb_6_1.Any(attribute.Value.StartsWith))
                            return "HGB_6.1";

                        if (_Hgb_6_0.Any(attribute.Value.StartsWith))
                            return "HGB_6.0";

                        if (_Hgb_5_4.Any(attribute.Value.StartsWith))
                            return "HGB_5.4";

                        if (attribute.Value.StartsWith(_Eur_1_0))
                            return "EÜR_1.0";
                    }
                }
            }

            return string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}