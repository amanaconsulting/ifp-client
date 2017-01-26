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
using System.Windows.Forms;
using AMANA.IFP.Common;
using AMANA.IFP.Forms;

namespace AMANA.IFP.UserControls
{
    public partial class CustomerIdentitiesUc : UserControl
    {
        private List<CustomerIdentity> _identities;

        public CustomerIdentitiesUc()
        {
            InitializeComponent();
        }

        public List<CustomerIdentity> Identities
        {
            get { return _identities; }
            set
            {
                _identities = value;
                InitializeControls();
            }
        }

        private void InitializeControls()
        {
            SenderIdentityListView.Items.Clear();
            SenderIdentityListView.Columns.Clear();

            SenderIdentityListView.Columns.Add("Art");
            SenderIdentityListView.Columns.Add("Wert");

            SenderIdentityListView.Columns[0].Width = 150;
            SenderIdentityListView.Columns[1].Width = 350;

            if (_identities != null)
                foreach (CustomerIdentity identity in _identities)
                    AddSenderIdentity(identity);
        }

        private void AddSenderIdentity(CustomerIdentity identity)
        {
            string[] subItems = new string[2];
            subItems[0] = CustomerIdentity.IdentityTypeToElbaString(identity.IdentityType);
            subItems[1] = identity.Value;

            ObjectListViewItem item = new ObjectListViewItem(identity, subItems);

            SenderIdentityListView.Items.Add(item);
            _identities.Add(identity);
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

        private void DeleteButton_Click(object sender, EventArgs e)
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
            CustomerIdentity newIdentity = new CustomerIdentity();
            EditCustomerIdentityForm form = new EditCustomerIdentityForm(newIdentity);
            if (form.ShowDialog() == DialogResult.OK)
                AddSenderIdentity(newIdentity);
        }

        private void EditSelectedItem()
        {
            ListView.SelectedListViewItemCollection items = SenderIdentityListView.SelectedItems;
            if (items.Count > 1)
            {
                MessageBox.Show("You can only edit one item at the same time.");
                return;
            }

            ObjectListViewItem lvi = items[0] as ObjectListViewItem;
            CustomerIdentity underlyingObject = lvi?.UnderlyingObject as CustomerIdentity;
            if (underlyingObject != null)
            {
                CustomerIdentity copy = underlyingObject.Copy();
                EditCustomerIdentityForm form = new EditCustomerIdentityForm(copy);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    copy.CopyTo(underlyingObject);
                    lvi.SubItems[0].Text = CustomerIdentity.IdentityTypeToElbaString(underlyingObject.IdentityType);
                    lvi.SubItems[1].Text = underlyingObject.Value;
                }
            }
        }

        private void RemoveSelectedItems()
        {
            List<ObjectListViewItem> selectedItems = new List<ObjectListViewItem>();
            foreach (var item in SenderIdentityListView.SelectedItems)
                selectedItems.Add(item as ObjectListViewItem);

            foreach (ObjectListViewItem item in selectedItems)
            {
                SenderIdentityListView.Items.Remove(item);
                _identities.Remove(item.UnderlyingObject as CustomerIdentity);
            }
        }
    }
}
