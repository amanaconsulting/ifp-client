# AMANA IFP Client für den Digitalen Finanzbericht

## Installation

Die aktuellste Version des Clients steht unter folgender Adresse zum Download zur Verfügung: [GitHub Releases](https://github.com/amanaconsulting/DiFin-Client/releases)

Die ZIP-Datei muss entpackt und die AMANA.IFP.WinClient.exe gestartet werden. Grundsätzlich lassen sich die DLL's aber auch als API in Drittanwendungen verwenden.

Zur Versendung wird ein Zertifikat benötigt. Nach Vorliegen der [Teilnahme- und Verbindlichkeitserklärung](https://digitaler-finanzbericht.de/files/Digitaler-Finanzbericht_Teilnahme-und-Verbindlichkeitserklaerung.pdf) 
erfolgt die Beantragung des Zertifikats über den Zertifikate-Client der Schufa. Die Zertifikatsdatei sollte dann als Benutzerzertifikat unter Windows
installiert werden (als Computerzertifikat installiert muss die WinClient.exe im Admin-Modus ausgeführt bzw. explizit Berechtigungen zum Verarbeiten des Zertikats für das entsprechende Benutzerkonto gesetzt werden). Das Zertifikat muss dann einmalig 
unter "Allgemeine Einstellungen" im Tool ausgewählt werden.

Zum automatischen Download der Routing Tabelle muss einmalig Benutzername/Passwort für den Schufa SFTP Zugang in "Allgemeine Einstellungen" gesetzt werden. Die Zugangsdaten hierfür werden von der Schufa bereitgestellt.

## Systemvoraussetzungen

* Windows-Betriebssystem
* .NET Framework 4.5.1

## Leistungsmerkmale

![Der IFP Client bietet eine kofortable Benutzeroberfläche mit Validierung.](https://amana-consulting.de/files/_theme/uploads/graphics/ifp_client.png "Der IFP Client bietet eine kofortable Benutzeroberfläche mit Validierung.")

### Open Source

Die Leistungen der hier angebotenen Open Source Variante:

* Einfache Benutzeroberfläche
* Stammdateneingabe
* Stammdatenvalidierung
* Versendung mittels Routing an beliebige Banken
* Anzeige der Versendungsrückmeldung
* Automatische Übernahme der Stammdaten aus XBRL in die IFP Header
* Automatischer Download der Routing Tabelle (Institutsmapping)

### Professional (kostenpflichtig)

Zusätzlich zu den Leistungen der Open Source Variante bietet die Professional Edition:

* XBRL „Checker“-Validierung vor dem Absenden
* Support und Gewährleistung durch AMANA
* Konverter: Excel/CSV -> XBRL und XBRL -> Excel/HTML/PDF

### Enterprise XBRL Portal (kostenpflichtig)

Zusätzlich zu den Leistungen der Open Source und der Professional Variante bietet die Enterprise XBRL Portal Edition:

* Datenbankgestützte Verwaltung von Mandanten und Abschlüssen
* Excel-Visualisierung der XBRL-Meldungen
* Workflow-gesteuerte Mehrbenutzerfähigkeit
* Berechnung und Anzeige von Kennzahlen
* Datenextraktion und Schnittstellen zu Data Warehouse Systemen
* Vollständiger Audit-Trail und Ablage der Versendungsergebnisse
* Server für den Digitalen Finanzbericht
* XBRL Web-Editor 

## Lizenzinformationen

Dieses Programm ist freie Software. Sie können es unter den Bedingungen der GNU General Public License, Version 3, wie von der Free Software Foundation veröffentlicht, weitergeben und/oder modifizieren. Link zu den GPL: https://www.gnu.org/licenses/gpl-3.0.txt

Es wird hierzu auch eine unverbindliche Deutsche Übersetzung angeboten: http://www.gnu.de/documents/gpl.de.html 

Sollten sich aus der Deutschen Übersetzung Unklarheiten ergeben, gilt im Zweifel die Englische Originalfassung. Sollten Sie mit den Lizenzbedingungen nicht einverstanden sein, sind Sie nicht berechtigt, den AMANA Client für den Digitalen Finanzbericht in der Open-Source-Variante zu nutzen.

Selbstverständlich können Sie das Programm im Rahmen der Lizenzbedingungen in beliebiger Weise nutzen. Wir würden uns aber besonders freuen, wenn Sie mit uns in einen interaktiven Prozess eintreten, welcher die Open-Source-Variante des AMANA Clients für den Digitalen Finanzbericht besser macht. Sie erreichen uns elektronisch unter info@amana-consulting.de oder per Telefon unter +49 (0)201 94622 800.
