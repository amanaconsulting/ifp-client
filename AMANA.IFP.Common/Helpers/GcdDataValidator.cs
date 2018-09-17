// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common.Helpers
{
    public class GcdDataValidator
    {
        public const string CompanyNameConcept = "genInfo.company.id.name";
        public const string CompanyCountryConcept = "genInfo.company.id.location.country.isoCode";
        public const string CompanyStreetConcept = "genInfo.company.id.location.street";
        public const string CompanyHouseNoConcept = "genInfo.company.id.location.houseNo";
        public const string CompanyZipCodeConcept = "genInfo.company.id.location.zipCode";
        public const string CompanyCityConcept = "genInfo.company.id.location.city";

        private const string MessageId = "GCD";

        public bool IsValid => !ResultMessages.Any();
        public List<RequestResultMessage> ResultMessages { get; } = new List<RequestResultMessage>();

        public static string GetGcdNodeValue(XmlNode instanceNode, XmlNamespaceManager namespaceManager, string conceptLocalName)
        {
            XmlNode gcdNode =
                instanceNode.SelectSingleNode($@"//{BalanceInformation.XbrlGcdDataNamespacePrefix}:{conceptLocalName}",
                    namespaceManager);
            if (gcdNode == null || gcdNode.ChildNodes.Count == 0)
                return string.Empty;

            gcdNode = gcdNode.ChildNodes[0];
            if (gcdNode.NodeType != XmlNodeType.Text)
                return string.Empty;

            return gcdNode.InnerText;
        }

        public bool Validate(ns2BilanzdatenTyp elbaInformation)
        {
            ResultMessages.Clear();

            XmlNode instanceNode = elbaInformation.Abschluss.First()?.Daten.XbrlAbschlussdaten.XBRL.Any.FirstOrDefault();
            if (instanceNode == null)
            {
                ResultMessages.Add(new RequestResultMessage("Es konnte keine XBRL-Instanz gefunden werden.", MessageId));
                return IsValid;
            }

            XmlNamespaceManager namespaceManager = BalanceInformation.SetupNamespaceManager(instanceNode.OwnerDocument);
            ns2BilanzdatenTypKunde kunde = elbaInformation.Kunde;
            CompareValues(instanceNode, namespaceManager, CompanyNameConcept, kunde.Name, "Name (Kunde)");
            CompareValues(instanceNode, namespaceManager, CompanyCountryConcept, kunde.Adresse.Land, "Land (Kunde)");
            if (kunde.Adresse.Hausanschrift != null)
            {
                CompareValues(instanceNode, namespaceManager, CompanyCityConcept, kunde.Adresse.Hausanschrift.Ort,
                    "Ort (Kunde Hausanschrift)");
                CompareValues(instanceNode, namespaceManager, CompanyZipCodeConcept, kunde.Adresse.Hausanschrift.PLZ,
                    "PLZ (Kunde Hausanschrift)");
                ValidateAddress(instanceNode, namespaceManager, kunde.Adresse.Hausanschrift.Strasse_Hausnummer.Trim());
            }

            return IsValid;
        }

        private void CompareValues(XmlNode instanceNode, XmlNamespaceManager namespaceManager, string conceptLocalName,
            string comparisonValue, string ifpFieldName)
        {
            string value = GetGcdNodeValue(instanceNode, namespaceManager, conceptLocalName);

            if (!string.IsNullOrEmpty(value) && !value.Equals(comparisonValue))
                AddResultMessage(comparisonValue, ifpFieldName, value);
        }

        private void ValidateAddress(XmlNode instanceNode, XmlNamespaceManager namespaceManager, string ifpAddress)
        {
            if (string.IsNullOrEmpty(ifpAddress))
                return;

            string gcdAddress =
                $"{GetGcdNodeValue(instanceNode, namespaceManager, CompanyStreetConcept)} {GetGcdNodeValue(instanceNode, namespaceManager, CompanyHouseNoConcept)}"
                    .Trim();

            if (string.IsNullOrEmpty(gcdAddress))
                return;

            if (!ifpAddress.Equals(gcdAddress))
                AddResultMessage(ifpAddress, "Straße, Hausnummer (Kunde Hausanschrift)", gcdAddress);
        }

        private void AddResultMessage(string comparisonValue, string ifpFieldName, string value)
        {
            ResultMessages.Add(new RequestResultMessage(
                        $"Der Wert {comparisonValue} des IFP-Feldes {ifpFieldName} weicht vom Wert {value} aus den GCD-Stammdaten ab",
                        MessageId));
        }
    }
}