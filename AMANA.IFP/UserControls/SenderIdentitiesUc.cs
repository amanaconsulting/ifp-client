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
using System.Collections.Generic;
using System.Windows.Forms;
using AMANA.IFP.Common;
using AMANA.IFP.Forms;

namespace AMANA.IFP.UserControls
{
    public partial class SenderIdentitiesUc : UserControl
    {
        private List<SenderIdentity> _identities;

        public SenderIdentitiesUc()
        {
            InitializeComponent();
        }

        public List<SenderIdentity> Identities
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
                foreach (SenderIdentity identity in _identities)
                    AddSenderIdentity(identity);
        }

        private void AddSenderIdentity(SenderIdentity identity)
        {
            string[] subItems = new string[2];
            subItems[0] = SenderIdentity.IdentityTypeToElbaString(identity.IdentityType);
            subItems[1] = identity.Value;

            ObjectListViewItem item = new ObjectListViewItem(identity, subItems);

            SenderIdentityListView.Items.Add(item);            
        }

        private void BtnAddSenderIdentity_Click(object sender, EventArgs e)
        {
            try
            {
                SenderIdentity newIdentity = new SenderIdentity();
                EditIdentityForm form = new EditIdentityForm(newIdentity);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _identities.Add(newIdentity);
                    AddSenderIdentity(newIdentity);
                }
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

        private void EditSelectedItem()
        {
            ListView.SelectedListViewItemCollection items = SenderIdentityListView.SelectedItems;
            if (items.Count > 1)
            {
                MessageBox.Show("You can only edit one item at the same time.");
                return;
            }

            ObjectListViewItem lvi = items[0] as ObjectListViewItem;
            SenderIdentity underlyingObject = lvi?.UnderlyingObject as SenderIdentity;
            if (underlyingObject != null)
            {
                SenderIdentity copy = underlyingObject.Copy();
                EditIdentityForm form = new EditIdentityForm(copy);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    copy.CopyTo(underlyingObject);
                    lvi.SubItems[0].Text = SenderIdentity.IdentityTypeToElbaString(underlyingObject.IdentityType);
                    lvi.SubItems[1].Text = underlyingObject.Value;
                }
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

        private void RemoveSelectedItems()
        {
            List<ObjectListViewItem> selectedItems = new List<ObjectListViewItem>();
            foreach (var item in SenderIdentityListView.SelectedItems)
                selectedItems.Add(item as ObjectListViewItem);

            foreach (ObjectListViewItem item in selectedItems)
            {
                SenderIdentityListView.Items.Remove(item);
                _identities.Remove(item.UnderlyingObject as SenderIdentity);
            }
        }
    }
}
