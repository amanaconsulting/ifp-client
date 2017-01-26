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
    public partial class AttachmentsUc : UserControl
    {
        private List<Attachment> _attachments;

        public AttachmentsUc()
        {
            InitializeComponent();
        }

        public List<Attachment> Attachments
        {
            get { return _attachments; }
            set
            {
                _attachments = value;
                InitializeControls();
            }
        }

        private void InitializeControls()
        {
            AttachmentsListView.Items.Clear();
            AttachmentsListView.Columns.Clear();

            AttachmentsListView.Columns.Add("Dateiname");
            AttachmentsListView.Columns[0].Width = 500;

            if (_attachments != null)
                foreach (Attachment attachment in _attachments)
                    AddAttachment(attachment);
        }

        private void AddAttachment(Attachment attachment)
        {
            string[] subItems = new string[1];
            subItems[0] = attachment.Name;

            ObjectListViewItem item = new ObjectListViewItem(attachment, subItems);

            AttachmentsListView.Items.Add(item);
            _attachments.Add(attachment);
        }

        private void AddButton_Click(object sender, EventArgs e)
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
            Attachment newAttachment = new Attachment();
            EditAttachmentForm form = new EditAttachmentForm(newAttachment);
            if (form.ShowDialog() == DialogResult.OK)
                AddAttachment(newAttachment);
        }

        private void EditSelectedItem()
        {
            ListView.SelectedListViewItemCollection items = AttachmentsListView.SelectedItems;
            if (items.Count > 1)
            {
                MessageBox.Show("You can only edit one item at the same time.");
                return;
            }

            ObjectListViewItem lvi = items[0] as ObjectListViewItem;
            Attachment underlyingObject = lvi?.UnderlyingObject as Attachment;
            if (underlyingObject != null)
            {
                Attachment copy = underlyingObject.Copy();
                EditAttachmentForm form = new EditAttachmentForm(copy);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    copy.CopyTo(underlyingObject);
                    lvi.SubItems[0].Text = underlyingObject.Name;
                }
            }
        }

        private void RemoveSelectedItems()
        {
            List<ObjectListViewItem> selectedItems = new List<ObjectListViewItem>();
            foreach (var item in AttachmentsListView.SelectedItems)
                selectedItems.Add(item as ObjectListViewItem);

            foreach (ObjectListViewItem item in selectedItems)
            {
                AttachmentsListView.Items.Remove(item);
                _attachments.Remove(item.UnderlyingObject as Attachment);
            }
        }
    }
}
