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
using System.Text;
using System.Windows.Forms;
using AMANA.IFP.Common;

namespace AMANA.IFP.UserControls
{
    public partial class RequestResultUc : UserControl
    {
        private RequestResult _requestResult;

        public RequestResultUc()
        {
            InitializeComponent();
        }

        public RequestResult RequestResult
        {
            get { return _requestResult; }
            set
            {
                _requestResult = value;
                InitializeControls();
            }
        }

        private void InitializeControls()
        {
            RequestTimeLabel.DataBindings.Clear();
            DataSendLabel.DataBindings.Clear();
            
            MessagesListView.Items.Clear();
            MessagesListView.Columns.Clear();

            MessagesListView.Columns.Add("Nachricht-ID");
            MessagesListView.Columns.Add("Text");

            if (_requestResult == null)
                return;

            RequestTimeLabel.SetTextDataBinding(_requestResult, nameof(_requestResult.CreationTimeAsDisplayString),
                DataSourceUpdateMode.Never);
            DataSendLabel.SetTextDataBinding(_requestResult,
                nameof(_requestResult.IsLocalResultAsDisplayString), DataSourceUpdateMode.Never);

            foreach (RequestResultMessage message in _requestResult.ResultMessages)
            {
                string[] subItems = new string[2];
                subItems[0] = message.MessageId;
                subItems[1] = message.Message;

                ObjectListViewItem item = new ObjectListViewItem(message, subItems);
                MessagesListView.Items.Add(item);
            }

            MessagesListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            MessagesListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void MessagesListView_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.C)
                    CopyListViewContentToClipboard();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void CopyListViewContentToClipboard()
        {
            StringBuilder clipboardText = new StringBuilder();
            clipboardText.Append("Nachrichten:");

            foreach (ListViewItem item in MessagesListView.SelectedItems)
            {
                clipboardText.Append(Environment.NewLine);
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    clipboardText.Append($"{subItem.Text}\t");
            }

            Clipboard.SetText(clipboardText.ToString());
        }
    }
}
