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
using System.Windows.Forms;
using AMANA.IFP.Client;

namespace AMANA.IFP.Forms
{
    public partial class HttpProxySettingsForm : Form
    {
        private HttpProxySettings _httpProxySettings;

        public HttpProxySettingsForm()
        {
            InitializeComponent();
        }

        public HttpProxySettings HttpProxySettings
        {
            get { return _httpProxySettings; }
            set
            {
                _httpProxySettings = value;
                InitializeDataBindings();
            }
        }

        private void InitializeDataBindings()
        {
            HttpProxySettingsUc.HttpProxySettings = _httpProxySettings.Copy();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void SaveChanges()
        {
            if (HttpProxySettingsUc.HttpProxySettings != null && HttpProxySettings != null)
                HttpProxySettingsUc.HttpProxySettings.CopyTo(HttpProxySettings);
        }
    }
}
