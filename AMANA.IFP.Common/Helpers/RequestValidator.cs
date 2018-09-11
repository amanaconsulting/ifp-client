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
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common.Helpers
{
    public class RequestValidator
    {
        public ns2KanzleiTyp Absender { get; set; }
        public ns2EmpfaengerTyp Empfaenger { get; set; }
        public ns2BilanzdatenTypKunde Kunde { get; set; }
        public ns2AbschlussTyp Abschluss { get; set; }
        public List<ns3QuittungTypHinweis> Hinweise { get; set; }
        public bool IsXbrlValid { get; set; }
        public bool AnfrageBearbeitet { get; set; }

        public RequestValidator()
        {
            Hinweise = new List<ns3QuittungTypHinweis>();
        }

        public RequestValidator(ns2BilanzdatenTyp elbaData)
            : this()
        {
            Absender = elbaData.Absender;
            Empfaenger = elbaData.Empfaenger;
            Kunde = elbaData.Kunde;
            Abschluss = elbaData.Abschluss.FirstOrDefault();
        }

        public ns3QuittungTyp CreateQuittung()
        {
            ns3QuittungTyp quittung = new ns3QuittungTyp
            {
                AnfrageBearbeitet = AnfrageBearbeitet,
                Hinweise = Hinweise.ToArray()
            };

            return quittung;
        }

        public virtual void Validate()
        {
            ValidateAbsender();
            ValidateEmpfaenger();
            ValidateKunde();
            ValidateAbschluss();
            CompleteValidation();
        }

        public void AddHinweisWithMessage(Enums.Fehlercode fehlercode, string message)
        {
            Hinweise.Add(ErrorHelper.CreateHinweis(fehlercode, message));
        }

        protected void AddHinweisFromErrorCode(Enums.Fehlercode fehlercode)
        {
            Hinweise.Add(ErrorHelper.GetHinweisByFehlercode(fehlercode));
        }

        private void ValidateAbsender()
        {
            if (Absender.Identifikationen == null || Absender.Identifikationen.Length == 0 || Absender.Identifikationen.Any(ident => ident == null))
                AddHinweisFromErrorCode(Enums.Fehlercode.F101);

            if (Absender.Adresse.Hausanschrift != null)
            {
                if (string.IsNullOrEmpty(Absender.Adresse.Hausanschrift.Strasse_Hausnummer))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F102);

                if (string.IsNullOrEmpty(Absender.Adresse.Hausanschrift.PLZ))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F103);

                if (string.IsNullOrEmpty(Absender.Adresse.Hausanschrift.Ort))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F104);
            }

            if (string.IsNullOrEmpty(Absender.NameAbsender.Name))
                AddHinweisFromErrorCode(Enums.Fehlercode.F105);

            if (string.IsNullOrEmpty(Absender.Kontaktdaten.Ansprechpartner.Vorname))
                AddHinweisFromErrorCode(Enums.Fehlercode.F106);

            if (string.IsNullOrEmpty(Absender.Kontaktdaten.Ansprechpartner.Nachname))
                AddHinweisFromErrorCode(Enums.Fehlercode.F107);

            if (string.IsNullOrEmpty(Absender.Kontaktdaten.Telefon))
                AddHinweisFromErrorCode(Enums.Fehlercode.F108);
            
            ValidateAbsenderIdentifikation();
        }

        private void ValidateAbsenderIdentifikation()
        {
            Regex regex = new Regex("I{1}F{1}P{1}[0-9]{7}");
            foreach (ns2IdentifikationSteuerberaterTypIdentifikation identifikation in Absender.Identifikationen)
            {
                if (identifikation == null)
                    continue;

                if (!SenderIdentity.IsStringIdentityType(identifikation.Art))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F143);

                if (string.Equals(identifikation.Art, SenderIdentity.IdentityTypeToElbaString(SenderIdentity.IdentityTypes.IfpIdBeauftragter)))
                {
                    if (!RoutingTableReader.Mappings.Any(m => string.Equals(m.IFPID, identifikation.Wert)))
                        AddHinweisFromErrorCode(Enums.Fehlercode.F130);

                    if (!regex.Match(identifikation.Wert).Success)
                        AddHinweisFromErrorCode(Enums.Fehlercode.F133);
                }
                else if (string.Equals(identifikation.Art, SenderIdentity.IdentityTypeToElbaString(SenderIdentity.IdentityTypes.IfpIdFirma)))
                {
                    if (!RoutingTableReader.Mappings.Any(m => string.Equals(m.IFPID, identifikation.Wert)))
                        AddHinweisFromErrorCode(Enums.Fehlercode.F130);

                    if (!regex.Match(identifikation.Wert).Success)
                        AddHinweisFromErrorCode(Enums.Fehlercode.F134);
                }
            }
        }

        private void ValidateEmpfaenger()
        {
            if (string.IsNullOrEmpty(Empfaenger.BankID?.Art) || string.IsNullOrEmpty(Empfaenger.BankID.Wert))
                AddHinweisFromErrorCode(Enums.Fehlercode.F109);

            if (Empfaenger.Anschrift.Hausanschrift != null)
            {
                if (string.IsNullOrEmpty(Empfaenger.Anschrift.Hausanschrift.Strasse_Hausnummer))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F110);

                if (string.IsNullOrEmpty(Empfaenger.Anschrift.Hausanschrift.PLZ))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F111);

                if (string.IsNullOrEmpty(Empfaenger.Anschrift.Hausanschrift.Ort))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F112);
            }

            if (string.IsNullOrEmpty(Empfaenger.Ansprechpartner.Vorname))
                AddHinweisFromErrorCode(Enums.Fehlercode.F113);

            if (string.IsNullOrEmpty(Empfaenger.Ansprechpartner.Nachname))
                AddHinweisFromErrorCode(Enums.Fehlercode.F114);

            ValidateEmpfaengerBankId();
        }

        private void ValidateEmpfaengerBankId()
        {
            if (Empfaenger.BankID != null && !BankId.IsStringBankId(Empfaenger.BankID.Art))
                AddHinweisFromErrorCode(Enums.Fehlercode.F144);

            if (!RoutingTableReader.Mappings.Any(m => string.Equals(m.BLZ, Empfaenger.BankID.Wert)))
                AddHinweisFromErrorCode(Enums.Fehlercode.F131);

            Regex regex = new Regex("[0-9]{8}");
            if (Empfaenger.BankID?.Wert != null && !regex.Match(Empfaenger.BankID.Wert).Success)
                AddHinweisFromErrorCode(Enums.Fehlercode.F135);
        }

        private void ValidateKunde()
        {
            if (Kunde.Identifikationen.Length == 0 || Kunde.Identifikationen.Any(ident => ident == null))
                AddHinweisFromErrorCode(Enums.Fehlercode.F115);

            if (string.IsNullOrEmpty(Kunde.Name))
                AddHinweisFromErrorCode(Enums.Fehlercode.F116);

            if (Kunde.Adresse.Hausanschrift != null)
            {
                if (string.IsNullOrEmpty(Kunde.Adresse.Hausanschrift.Strasse_Hausnummer))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F117);

                if (string.IsNullOrEmpty(Kunde.Adresse.Hausanschrift.PLZ))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F118);

                if (string.IsNullOrEmpty(Kunde.Adresse.Hausanschrift.Ort))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F119);
            }

            if (string.IsNullOrEmpty(Kunde.Kontaktdaten.Ansprechpartner.Vorname))
                AddHinweisFromErrorCode(Enums.Fehlercode.F120);

            if (string.IsNullOrEmpty(Kunde.Kontaktdaten.Ansprechpartner.Nachname))
                AddHinweisFromErrorCode(Enums.Fehlercode.F121);

            if (string.IsNullOrEmpty(Kunde.Kontaktdaten.Telefon))
                AddHinweisFromErrorCode(Enums.Fehlercode.F122);

            ValidateKundeIdentifikation();
        }

        private void ValidateKundeIdentifikation()
        {
            foreach (ns2IdentifikationKundeTypIdentifikation identifikation in Kunde.Identifikationen)
            {
                if (string.IsNullOrEmpty(identifikation.Wert))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F141);

                if (!CustomerIdentity.IsStringIdentityType(identifikation.Art))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F145);
            }
        }

        private void ValidateAbschluss()
        {
            if (string.IsNullOrEmpty(Abschluss.Bilanz.Abschlussart))
                AddHinweisFromErrorCode(Enums.Fehlercode.F123);

            if (Abschluss.Bilanz.Abschlussstichtag == DateTime.MinValue)
                AddHinweisFromErrorCode(Enums.Fehlercode.F124);

            if (string.IsNullOrEmpty(Abschluss.Bilanz.Bilanzierungsebene))
                AddHinweisFromErrorCode(Enums.Fehlercode.F125);

            if (string.IsNullOrEmpty(Abschluss.Taxonomie))
                AddHinweisFromErrorCode(Enums.Fehlercode.F126);

            if (Abschluss.Daten?.XbrlAbschlussdaten?.XBRL == null)
                AddHinweisFromErrorCode(Enums.Fehlercode.F127);

            if (Abschluss.Daten?.Anhaenge == null ||
                Abschluss.Daten?.Anhaenge.Length == 0 ||
                (Abschluss.Daten != null && Abschluss.Daten.Anhaenge.Any(a => a == null)))
            {
                AddHinweisFromErrorCode(Enums.Fehlercode.F128);
                AddHinweisFromErrorCode(Enums.Fehlercode.F129);
            }
            else
            {
                if (Abschluss.Daten.Anhaenge.Any(a => string.IsNullOrEmpty(a.Typ)))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F128);

                if (Abschluss.Daten.Anhaenge.Any(a => a.Dokument.Length == 0))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F129);

                if (Abschluss.Daten.Anhaenge.Length > 5)
                    AddHinweisFromErrorCode(Enums.Fehlercode.F168);
            }

            if (string.IsNullOrEmpty(Abschluss.IdentMerkmal))
                AddHinweisFromErrorCode(Enums.Fehlercode.F140);

            ValidateAbschlussart(Abschluss.Bilanz.Abschlussart);
            ValidateBilanzierungsebene(Abschluss.Bilanz.Bilanzierungsebene);
            ValidateTaxonomie(Abschluss.Taxonomie);
            ValidateIdentMerkmal(Abschluss.IdentMerkmal);
            ValidateSoftware(Abschluss.Software);

            if (Abschluss.Daten != null)
                ValidateAnhaenge(Abschluss.Daten.Anhaenge);
        }

        private void ValidateAbschlussart(string abschlussart)
        {
            if (!BalanceInformation.IsStringBalanceType(abschlussart))
                AddHinweisFromErrorCode(Enums.Fehlercode.F142);
        }

        private void ValidateBilanzierungsebene(string bilanzierungsebene)
        {
            if (!BalanceInformation.IsStringConsolidationType(bilanzierungsebene))
                AddHinweisFromErrorCode(Enums.Fehlercode.F146);
        }

        private void ValidateTaxonomie(string taxonomie)
        {
            if (!BalanceInformation.IsStringTaxonomyType(taxonomie))
                AddHinweisFromErrorCode(Enums.Fehlercode.F147);
        }

        private void ValidateIdentMerkmal(string identMerkmal)
        {
            if (!BalanceInformation.IsStringIdentType(identMerkmal))
                AddHinweisFromErrorCode(Enums.Fehlercode.F148);
        }

        private void ValidateSoftware(ns2AbschlussTypSoftware software)
        {
            if (software == null)
                return;

            if (software.Versand != null && SoftwareHasEmptyFields(software.Versand))
                AddHinweisFromErrorCode(Enums.Fehlercode.F138);

            if (software.Erstellung != null && SoftwareHasEmptyFields(software.Erstellung))
                AddHinweisFromErrorCode(Enums.Fehlercode.F139);
        }

        private bool SoftwareHasEmptyFields(ns2SoftwareTyp software)
        {
            return string.IsNullOrEmpty(software.ID) || string.IsNullOrEmpty(software.Name) ||
                   string.IsNullOrEmpty(software.Version) || string.IsNullOrEmpty(software.Hersteller);
        }       

        private void ValidateAnhaenge(ns3BinaerAnhangTyp[] anhaenge)
        {
            string timestampExp = @"\d{4}\d{2}\d{2}\d{2}\d{2}\d{2}\d{0,4}";
            Regex jahresAbschlussPdf = new Regex(string.Format("{0}{1}",
                Attachment.AttachmentIdTypeToElbaString(Attachment.AttachmentIdTypes.Japdf), timestampExp));

            // PDF fehlt
            if (anhaenge.All(anhang => anhang.AnhangID != null && !jahresAbschlussPdf.Match(anhang.AnhangID).Success))
                AddHinweisFromErrorCode(Enums.Fehlercode.F150);

            IEnumerable<Attachment.AttachmentIdTypes> attachmentIdTypes = Enum.GetValues(typeof(Attachment.AttachmentIdTypes)).Cast<Attachment.AttachmentIdTypes>();
            List<Regex> regex = new List<Regex>();
            foreach (Attachment.AttachmentIdTypes attachmentIdType in attachmentIdTypes)
            {
                if (attachmentIdType != Attachment.AttachmentIdTypes.Ohne)
                    regex.Add(new Regex(string.Format("{0}{1}",
                        Attachment.AttachmentIdTypeToElbaString(attachmentIdType), timestampExp)));
            }

            foreach (ns3BinaerAnhangTyp anhang in anhaenge)
            {
                if (anhang.AnhangID == null || !regex.Any(r => r.Match(anhang.AnhangID).Success))
                    AddHinweisFromErrorCode(Enums.Fehlercode.F149);
            }
        }

        private void CompleteValidation()
        {
            if (!Hinweise.Any() || Hinweise.All(h => string.Equals(h.ID, Enums.Fehlercode.X401.ToString()) && IsXbrlValid))
            {
                AddHinweisFromErrorCode(Enums.Fehlercode.F000);
                AnfrageBearbeitet = true;
            }
        }
    }
}