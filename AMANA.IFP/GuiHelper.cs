// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
namespace AMANA.IFP
{
    public static class GuiHelper
    {
        private const string GcdValueTooltip =
            "{0} aus den Stammdaten der Taxonomie ermitteln (Taxonomie muss gesetzt sein).";

        public static string GetGcdValueTooltipText(string gcdValueName)
        {
            return string.Format(GcdValueTooltip, gcdValueName);
        }
    }
}