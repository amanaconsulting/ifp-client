// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System.Windows.Forms;
using AMANA.IFP.Common;

namespace AMANA.IFP.UserControls
{
    public partial class HeaderIdentityUc : UserControl
    {
        private HeaderIdentity _headerIdentity;

        public HeaderIdentityUc()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            InstituteIdTypeComboBox.Items.Clear();
            InstituteIdTypeComboBox.Items.Add("BLZ");
            InstituteIdTypeComboBox.Items.Add("BIC");
            InstituteIdTypeComboBox.Items.Add("RZBK");
        }

        public HeaderIdentity HeaderIdentity
        {
            get { return _headerIdentity; }
            set
            {
                _headerIdentity = value;
                InitializeControlBindings();
            }
        }

        private void InitializeControlBindings()
        {
            UserIdTextBox.DataBindings.Clear();
            ProviderTextBox.DataBindings.Clear();
            ClientTextBox.DataBindings.Clear();
            InstituteIdTextBox.DataBindings.Clear();
            InstituteIdTypeComboBox.DataBindings.Clear();

            if (_headerIdentity == null)
                return;

            UserIdTextBox.SetTextDataBinding(_headerIdentity, nameof(_headerIdentity.UserId));
            ProviderTextBox.SetTextDataBinding(_headerIdentity, nameof(_headerIdentity.Provider));
            ClientTextBox.SetTextDataBinding(_headerIdentity, nameof(_headerIdentity.Client));
            InstituteIdTextBox.SetTextDataBinding(_headerIdentity, nameof(_headerIdentity.InstituteId));
            InstituteIdTypeComboBox.SetTextDataBinding(_headerIdentity, nameof(_headerIdentity.InstituteIdType));
        }
    }
}
