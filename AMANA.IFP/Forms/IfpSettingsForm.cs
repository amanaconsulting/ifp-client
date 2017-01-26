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
using System.Windows.Forms;
using AMANA.IFP.Client;

namespace AMANA.IFP.Forms
{
    public partial class IfpSettingsForm : Form
    {
        private IfpClientSettings _settings;

        public IfpSettingsForm()
        {
            InitializeComponent();
        }

        public IfpClientSettings Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                SettingsUc.Settings = _settings.Copy();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
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

        private void SaveChanges()
        {
            if (SettingsUc.Settings != null && Settings != null)
                SettingsUc.Settings.CopyTo(Settings);
        }
    }
}
