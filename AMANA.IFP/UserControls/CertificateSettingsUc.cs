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
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using AMANA.IFP.Client;

namespace AMANA.IFP.UserControls
{
    public partial class CertificateSettingsUc : UserControl
    {
        private CertificateSettings _settings;

        public CertificateSettings Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                InitializeDataBindings();
            }
        }

        public CertificateSettingsUc()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            StoreLocationComboBox.DataSource = Enum.GetValues(typeof(StoreLocation));
            StoreNameComboBox.DataSource = Enum.GetValues(typeof(StoreName));
            X509FindTypeComboBox.DataSource = Enum.GetValues(typeof(X509FindType));
        }

        private void InitializeDataBindings()
        {
            StoreLocationComboBox.DataBindings.Clear();
            StoreNameComboBox.DataBindings.Clear();
            X509FindTypeComboBox.DataBindings.Clear();
            FindValueTextBox.DataBindings.Clear();

            if (_settings == null)
                return;

            StoreLocationComboBox.SetSelectedItemDataBinding(_settings, nameof(_settings.StoreLocation));
            StoreNameComboBox.SetSelectedItemDataBinding(_settings, nameof(_settings.StoreName));
            X509FindTypeComboBox.SetSelectedItemDataBinding(_settings, nameof(_settings.FindType));
            FindValueTextBox.SetTextDataBinding(_settings, nameof(_settings.FindValue));
        }
    }
}
