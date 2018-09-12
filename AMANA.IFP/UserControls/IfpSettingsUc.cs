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

namespace AMANA.IFP.UserControls
{
    public partial class IfpSettingsUc : UserControl
    {
        private IfpClientSettings _settings;

        public IfpSettingsUc()
        {
            InitializeComponent();
        }

        public IfpClientSettings Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                InitializeControls();
            }
        }

        private void InitializeControls()
        {
            RoutingTableFilePathTextBox.DataBindings.Clear();
            IfpValidationCheckBox.DataBindings.Clear();
            GcdValidationCheckBox.DataBindings.Clear();
            CustomRoutingTableFilePathCheckbox.DataBindings.Clear();
            PasswordTextBox.DataBindings.Clear();
            UserNameTextBox.DataBindings.Clear();
            CertificateSettingsUc.Settings = _settings?.CertificateSettings;

            if (Settings == null)
                return;

            RoutingTableFilePathTextBox.SetTextDataBinding(_settings, nameof(_settings.RoutingTableFilePath));
            IfpValidationCheckBox.SetCheckedDataBinding(_settings, nameof(_settings.ValidateIfpData));
            GcdValidationCheckBox.SetCheckedDataBinding(_settings, nameof(_settings.ValidateGcdData));
            CustomRoutingTableFilePathCheckbox.SetCheckedDataBinding(_settings, nameof(_settings.IsAutoDownloadRoutingTableFileDisabled));
            UserNameTextBox.SetTextDataBinding(_settings, nameof(_settings.SftpSchufaFilesUserName));
            PasswordTextBox.SetTextDataBinding(_settings, nameof(_settings.SftpSchufaFilesPassword));
        }

        private void SearchRoutingTableFilePathButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetRoutingTableFilePath();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void SetRoutingTableFilePath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML-Datei (*.xml)|*.xml|Alle Dateien (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _settings.RoutingTableFilePath = ofd.FileName;
            }
        }

        private void CustomRoutingTableFilePathCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RoutingTableFilePathLabel.Enabled = RoutingTableFilePathTextBox.Enabled = SearchRoutingTableFilePathButton.Enabled = CustomRoutingTableFilePathCheckbox.Checked;
            SftpCredentialsGroupBox.Enabled = !CustomRoutingTableFilePathCheckbox.Checked;
        }
    }
}
