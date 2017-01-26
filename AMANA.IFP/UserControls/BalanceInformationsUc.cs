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
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AMANA.IFP.Client;
using AMANA.IFP.Common;
using AMANA.IFP.Forms;

namespace AMANA.IFP.UserControls
{
    public partial class BalanceInformationsUc : UserControl
    {
        private IfpDataContainer _dataContainer;

        public BalanceInformationsUc()
        {
            InitializeComponent();
        }

        public List<BalanceInformation> Balances => _dataContainer?.ElbaInformation?.BalanceInformation;

        public IfpDataContainer DataContainer
        {
            get { return _dataContainer; }
            set
            {
                _dataContainer = value;
                InitializeControls();
            }
        }

        public void AddBalanceInformation(BalanceInformation balance)
        {
            AddBalanceInformationToListView(balance);
            Balances.Add(balance);
        }

        public void AddOrUpdateBalanceInformation(BalanceInformation balanceInformation)
        {
            ObjectListViewItem olvItem =
                BalancesListView.Items.OfType<ObjectListViewItem>()
                    .FirstOrDefault(item => item.UnderlyingObject == balanceInformation);

            if (olvItem != null)
                olvItem.SubItems[0].Text = balanceInformation.XbrlFilePath;
            else
                AddBalanceInformationToListView(balanceInformation);
        }

        private void InitializeControls()
        {
            BalancesListView.Items.Clear();
            BalancesListView.Columns.Clear();

            BalancesListView.Columns.Add("Dateipfad");

            if (Balances != null)
                foreach (BalanceInformation balance in Balances)
                    AddBalanceInformationToListView(balance);
        }

        private void AddBalanceInformationToListView(BalanceInformation balance)
        {
            string[] subItems = new string[1];
            subItems[0] = balance.XbrlFilePath;

            ObjectListViewItem item = new ObjectListViewItem(balance, subItems);

            BalancesListView.Items.Add(item);
        }

        private void BtnAddSenderIdentity_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewItem();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditSelectedItem();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveSelectedItems();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void AddNewItem()
        {
            BalanceInformation newBalanceInformation = new BalanceInformation();
            EditBalanceInformationForm form = new EditBalanceInformationForm(newBalanceInformation);
            if (form.ShowDialog() == DialogResult.OK)
                AddBalanceInformation(newBalanceInformation);
        }

        private void EditSelectedItem()
        {
            ListView.SelectedListViewItemCollection items = BalancesListView.SelectedItems;
            if (items.Count > 1)
            {
                MessageBox.Show("You can only edit one item at the same time.");
                return;
            }

            ObjectListViewItem lvi = items[0] as ObjectListViewItem;
            BalanceInformation underlyingObject = lvi?.UnderlyingObject as BalanceInformation;
            if (underlyingObject != null)
            {
                BalanceInformation copy = underlyingObject.Copy();
                EditBalanceInformationForm form = new EditBalanceInformationForm(copy);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    copy.CopyTo(underlyingObject);
                    lvi.SubItems[0].Text = underlyingObject.XbrlFilePath;
                }
            }
        }

        private void RemoveSelectedItems()
        {
            List<ObjectListViewItem> selectedItems = new List<ObjectListViewItem>();
            foreach (var item in BalancesListView.SelectedItems)
                selectedItems.Add(item as ObjectListViewItem);

            foreach (ObjectListViewItem item in selectedItems)
            {
                BalancesListView.Items.Remove(item);
                Balances.Remove(item.UnderlyingObject as BalanceInformation);
            }
        }
    }
}
