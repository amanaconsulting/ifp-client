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
using AMANA.IFP.Common;

namespace AMANA.IFP.Forms
{
    public partial class EditCustomerIdentityForm : Form
    {
        private readonly CustomerIdentity _identity;

        public EditCustomerIdentityForm(CustomerIdentity identity)
        {
            _identity = identity;
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            TextBoxValue.SetTextDataBinding(_identity, nameof(_identity.Value));
            CmbType.DataSource = Enum.GetValues(typeof(IdentityTypes));
            CmbType.SetSelectedItemDataBinding(_identity, nameof(_identity.IdentityType));
        }

        private void BtnOk_Click(object sender, EventArgs e)
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
    }
}
