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

namespace AMANA.IFP.UserControls
{
    public partial class HttpProxySettingsUc : UserControl
    {
        private HttpProxySettings _httpProxySettings;

        public HttpProxySettingsUc()
        {
            InitializeComponent();
            InitializeControls();
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

        private void InitializeControls()
        {
            ProxyTypeComboBox.DataSource = Enum.GetValues(typeof(HttpProxySettings.HttpProxyMode));
        }

        private void InitializeDataBindings()
        {
            ProxyTypeComboBox.DataBindings.Clear();
            HttpProxyHostTextBox.DataBindings.Clear();
            ProxyPortTextBox.DataBindings.Clear();
            HttpProxyUsernameTextBox.DataBindings.Clear();
            HttpProxyPasswordTextBox.DataBindings.Clear();

            if (_httpProxySettings == null)
                return;

            ProxyTypeComboBox.SetSelectedItemDataBinding(_httpProxySettings, nameof(_httpProxySettings.ProxyMode));
            HttpProxyHostTextBox.SetTextDataBinding(_httpProxySettings, nameof(_httpProxySettings.ProxyHost));
            ProxyPortTextBox.SetTextDataBinding(_httpProxySettings, nameof(_httpProxySettings.ProxyPort));
            HttpProxyUsernameTextBox.SetTextDataBinding(_httpProxySettings, nameof(_httpProxySettings.UserName));
            HttpProxyPasswordTextBox.SetTextDataBinding(_httpProxySettings, nameof(_httpProxySettings.Password));
        }

        private void ProxyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HttpProxySettings == null)
                return;

            bool isOwnProxy = (HttpProxySettings.HttpProxyMode)ProxyTypeComboBox.SelectedItem ==
                              HttpProxySettings.HttpProxyMode.OwnProxy;

            HttpProxyHostTextBox.Enabled = isOwnProxy;
            ProxyPortTextBox.Enabled = isOwnProxy;
            HttpProxyUsernameTextBox.Enabled = isOwnProxy;
            HttpProxyPasswordTextBox.Enabled = isOwnProxy;
        }
    }
}
