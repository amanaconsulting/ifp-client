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
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common.Helpers
{
    public class ErrorHelper
    {
        public static ns3QuittungTypHinweis GetHinweisByFehlercode(Enums.Fehlercode fehlercode)
        {
            switch (fehlercode)
            {
                case Enums.Fehlercode.F000:
                    return CreateHinweis(fehlercode, @"Alle Daten korrekt geprüft, keine Fehler");
                case Enums.Fehlercode.F101:
                    return CreateHinweis(fehlercode, @"Pflichfeld Absender-Identifikation nicht befüllt");
                case Enums.Fehlercode.F102:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Absender-Strasse_Hausnummer nicht befüllt");
                case Enums.Fehlercode.F103:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Absender-PLZ nicht befüllt");
                case Enums.Fehlercode.F104:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Absender-Ort nicht befüllt");
                case Enums.Fehlercode.F105:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Absender-Name nicht befüllt");
                case Enums.Fehlercode.F106:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Absender-Ansprechpartner-Vorname nicht befüllt");
                case Enums.Fehlercode.F107:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Absender-Ansprechpartner-Nachname nicht befüllt");
                case Enums.Fehlercode.F108:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Absender-Telefon nicht befüllt");
                case Enums.Fehlercode.F109:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Empfänger-BankID nicht befüllt");
                case Enums.Fehlercode.F110:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Empfänger-Straße Hausnummer nicht befüllt");
                case Enums.Fehlercode.F111:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Empfänger-PLZ nicht befüllt");
                case Enums.Fehlercode.F112:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Empfänger-Ort nicht befüllt");
                case Enums.Fehlercode.F113:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Empfänger-Ansprechpartner-Vorname nicht befüllt");
                case Enums.Fehlercode.F114:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Empfänger-Ansprechpartner-Nachname nicht befüllt");
                case Enums.Fehlercode.F115:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-Identifikation nicht befüllt");
                case Enums.Fehlercode.F116:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-Name nicht befüllt");
                case Enums.Fehlercode.F117:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-Strasse_Hausnummer nicht befüllt");
                case Enums.Fehlercode.F118:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-PLZ nicht befüllt");
                case Enums.Fehlercode.F119:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-Ort nicht befüllt");
                case Enums.Fehlercode.F120:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-Kontaktdaten-Vorname nicht befüllt");
                case Enums.Fehlercode.F121:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-Kontaktdaten-Nachname nicht befüllt");
                case Enums.Fehlercode.F122:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-Telefon nicht befüllt");
                case Enums.Fehlercode.F123:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Abschluss-Abschlussart nicht befüllt");
                case Enums.Fehlercode.F124:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Abschluss-Abschlussstichtag nicht befüllt");
                case Enums.Fehlercode.F125:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Abschluss-Bilanzierungsebene nicht befüllt");
                case Enums.Fehlercode.F126:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Abschluss-Taxonomie nicht befüllt");
                case Enums.Fehlercode.F127:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Abschluss-Daten-XBRL nicht befüllt");
                case Enums.Fehlercode.F128:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Abschluss-Anhänge-Typ nicht befüllt");
                case Enums.Fehlercode.F129:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Abschluss-Anhänge-Dokument nicht befüllt");
                case Enums.Fehlercode.F130:
                    return CreateHinweis(fehlercode, @"Ungültiger Wert im Feld Absender-Identifikation");
                case Enums.Fehlercode.F131:
                    return CreateHinweis(fehlercode, @"Ungültiger Wert im Feld Empfänger-BankID");
                case Enums.Fehlercode.F132:
                    return CreateHinweis(fehlercode, @"Ungültiger Wert im Feld Kunde-Identifikation");
                case Enums.Fehlercode.F133:
                    return CreateHinweis(fehlercode, @"Ungültiges Format im Feld Absender-Identifikation-IFP-ID-BEAUF");
                case Enums.Fehlercode.F134:
                    return CreateHinweis(fehlercode, @"Ungültiges Format im Feld Absender-Identifikation-IFP-ID-Firma");
                case Enums.Fehlercode.F135:
                    return CreateHinweis(fehlercode, @"Ungültiges Format im Feld Empfänger-BankID");
                case Enums.Fehlercode.F136:
                    return CreateHinweis(fehlercode, @"Ungültiges Format im Feld Kunde-Identifikation");
                case Enums.Fehlercode.F137:
                    return CreateHinweis(fehlercode, @"Nicht unterstützte Taxonomie referenziert im Feld schemaRef");
                case Enums.Fehlercode.F138:
                    return CreateHinweis(fehlercode, @"Versendende Software fehlt, mindestangaben sind Name ID, Version, Hersteller");
                case Enums.Fehlercode.F139:
                    return CreateHinweis(fehlercode, @"Erstellende Software fehlt, mindestangaben sind Name ID, Version, Hersteller");
                case Enums.Fehlercode.F140:
                    return CreateHinweis(fehlercode, @"Verpflichtende Angabe IdentMerkmal fehlt");
                case Enums.Fehlercode.F141:
                    return CreateHinweis(fehlercode, @"Pflichtfeld Kunde-Identifikation-WERT fehlt");
                case Enums.Fehlercode.F142:
                    return CreateHinweis(fehlercode, @"Element Abschlussart ungültig");
                case Enums.Fehlercode.F143:
                    return CreateHinweis(fehlercode, @"Ungültige Art im Feld Absender-Identifikationen-Identifikation");
                case Enums.Fehlercode.F144:
                    return CreateHinweis(fehlercode, @"Ungültige Art im Feld Empfänger-BankID");
                case Enums.Fehlercode.F145:
                    return CreateHinweis(fehlercode, @"Ungültige Art im Feld Kunde-Identifikationen-Identifikation");
                case Enums.Fehlercode.F146:
                    return CreateHinweis(fehlercode, @"Ungültiger Wert im Feld Abschluss-Bilanz-Bilanzierungsebene");
                case Enums.Fehlercode.F147:
                    return CreateHinweis(fehlercode, @"Ungültiger Wert im Feld Abschluss-Taxonomie");
                case Enums.Fehlercode.F148:
                    return CreateHinweis(fehlercode, @"Ungültiger Wert im Feld Abschluss-IdentMerkmal");
                case Enums.Fehlercode.F149:
                    return CreateHinweis(fehlercode, @"Ungültiger Wert im Feld Anhaenge-AnhangID");
                case Enums.Fehlercode.F150:
                    return CreateHinweis(fehlercode, @"Kein PDF-Anhang vorhanden");
                case Enums.Fehlercode.F168:
                    return CreateHinweis(fehlercode, @"Mehr als 5 Datei-Anhänge sind nicht erlaubt");
                case Enums.Fehlercode.U111:
                    return CreateHinweis(fehlercode, @"Unbekannter Fehler");
                default:
                    throw new ArgumentException();
            }
        }

        public static ns3QuittungTypHinweis CreateHinweis(Enums.Fehlercode fehlercode, string beschreibung)
        {
            return new ns3QuittungTypHinweis
            {
                ID = fehlercode.ToString(),
                Beschreibung = beschreibung
            };
        }
    }
}