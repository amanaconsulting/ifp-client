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
using System.Web;
using System.Windows.Forms;
using AMANA.IFP.Common;

namespace AMANA.IFP.Forms
{
    public partial class EditAttachmentForm : Form
    {
        private Attachment _attachment;

        public EditAttachmentForm(Attachment attachment)
        {
            InitializeComponent();
            Attachment = attachment;
            InitializeControls();
        }

        public Attachment Attachment
        {
            get { return _attachment; }
            set
            {
                _attachment = value;
                InitializeDataBindings();
            }
        }

        private void InitializeControls()
        {
            AttachmentTypeComboBox.DataSource = Enum.GetValues(typeof(Attachment.AttachmentIdTypes));
        }

        private void InitializeDataBindings()
        {
            TextBoxFilePath.DataBindings.Clear();
            TextBoxFileName.DataBindings.Clear();
            TextBoxMimeType.DataBindings.Clear();
            AttachmentTypeComboBox.DataBindings.Clear();

            if (_attachment == null)
                return;

            TextBoxFilePath.SetTextDataBinding(_attachment, nameof(_attachment.FilePath));
            TextBoxFileName.SetTextDataBinding(_attachment, nameof(_attachment.Name));
            TextBoxMimeType.SetTextDataBinding(_attachment, nameof(_attachment.Mimetype));
            AttachmentTypeComboBox.SetSelectedItemDataBinding(_attachment, nameof(_attachment.AttachmentType));
        }

        private void SaveButton_Click(object sender, EventArgs e)
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

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF-Dateien (*.pdf)|*.pdf|Alle Dateien (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TextBoxFilePath.Text = ofd.FileName;
                    TextBoxFileName.Text = ofd.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }
    }
}
