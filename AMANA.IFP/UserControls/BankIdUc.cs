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
using AMANA.IFP.Common;

namespace AMANA.IFP.UserControls
{
    public partial class BankIdUc : UserControl
    {
        private BankId _bankId;

        public BankIdUc()
        {
            InitializeComponent();
            BankIdTypeCmb.DataSource = Enum.GetValues(typeof(BankId.BankIdTypes));
        }

        public BankId BankId
        {
            get { return _bankId; }
            set
            {
                _bankId = value;
                InitializeDataBindings();
            }
        }

        private void InitializeDataBindings()
        {
            BankIdTypeCmb.DataBindings.Clear();
            BankIdValueTextBox.DataBindings.Clear();
            BankIdNameTextBox.DataBindings.Clear();

            if (_bankId == null)
                return;

            BankIdTypeCmb.SetSelectedItemDataBinding(_bankId, nameof(_bankId.BankIdType));
            BankIdValueTextBox.SetTextDataBinding(_bankId, nameof(_bankId.Value));
            BankIdNameTextBox.SetTextDataBinding(_bankId, nameof(_bankId.Name));
        }
    }
}
