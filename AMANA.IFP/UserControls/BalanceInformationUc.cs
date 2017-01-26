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
    public partial class BalanceInformationUc : UserControl
    {
        private BalanceInformation _balanceInformation;

        public BalanceInformation BalanceInformation
        {
            get { return _balanceInformation; }
            set
            {
                _balanceInformation = value;
                InitializeDataBindings();
            }
        }

        public BalanceInformationUc()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            BalanceTypeComboBox.DataSource = Enum.GetValues(typeof(BalanceInformation.BalanceTypes));
            BalanceLevelComboBox.DataSource = Enum.GetValues(typeof(BalanceInformation.ConsolidationTypes));
            IdentComboBox.DataSource = Enum.GetValues(typeof(BalanceInformation.IdentTypes));
        }

        private void InitializeDataBindings()
        {
            BalanceTypeComboBox.DataBindings.Clear();
            BalanceDueDateDateTimePicker.DataBindings.Clear();
            BalanceLevelComboBox.DataBindings.Clear();
            BalanceXbrlFilePathTextBox.DataBindings.Clear();
            BalanceXbrlFilePathButton.DataBindings.Clear();
            AccountsTextBox.DataBindings.Clear();
            IdentComboBox.DataBindings.Clear();
            CommentTextBox.DataBindings.Clear();

            if (_balanceInformation == null)
                return;

            BalanceTypeComboBox.SetSelectedItemDataBinding(_balanceInformation, nameof(_balanceInformation.BalanceType));
            BalanceDueDateDateTimePicker.SetDataBinding(nameof(BalanceDueDateDateTimePicker.Value), _balanceInformation, nameof(_balanceInformation.DueDate));
            BalanceLevelComboBox.SetSelectedItemDataBinding(_balanceInformation, nameof(_balanceInformation.ConsolidationType));
            BalanceXbrlFilePathTextBox.SetTextDataBinding(_balanceInformation, nameof(_balanceInformation.XbrlFilePath));
            BalanceXbrlFilePathTextBox.SetEnabledDataBinding(_balanceInformation,
                nameof(_balanceInformation.HasLocalFile), DataSourceUpdateMode.Never);
            BalanceXbrlFilePathButton.SetEnabledDataBinding(_balanceInformation,
                nameof(_balanceInformation.HasLocalFile), DataSourceUpdateMode.Never);
            AccountsTextBox.SetTextDataBinding(_balanceInformation, nameof(_balanceInformation.Accounts));
            IdentComboBox.SetSelectedItemDataBinding(_balanceInformation, nameof(_balanceInformation.IdentType));
            CommentTextBox.SetTextDataBinding(_balanceInformation, nameof(_balanceInformation.Comment));

            AttachmentsUc.Attachments = _balanceInformation.Attachments;
        }

        private void BalanceXbrlFilePathButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetXbrlFilePath();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void SetXbrlFilePath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XBRL-Instanzen (*.xml, *.xbrl)|*.xml;*.xbrl|Alle Dateien (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BalanceXbrlFilePathTextBox.Text = ofd.FileName;
            }
        }
    }
}
