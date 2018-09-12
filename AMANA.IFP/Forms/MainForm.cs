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
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;
using AMANA.IFP.Client;
using AMANA.IFP.Common;
using AMANA.IFP.Common.Helpers;

namespace AMANA.IFP.Forms
{
    public partial class MainForm : Form
    {
        private IfpDataContainer _dataContainer;
        private RequestResult _lastRequestResult;

        public Software ChannelSoftware { get; set; } = new Software()
        {
            Id = "IFP99900045",
            Manufacturer = "AMANA consulting GmbH",
            Name = "IFP Transfer Client",
            Version = Assembly.GetExecutingAssembly().GetName().Version.ToString()
        };

        public MainForm()
        {
            InitObjects();
            InitializeComponent();
            InitControls();
        }       

        private void InitObjects()
        {
            _dataContainer = new IfpDataContainer();
        }

        private void InitControls()
        {
            ElbaInformation elbaInformation = _dataContainer.ElbaInformation;
            Sender sender = elbaInformation.SenderInformation;
            SenderIdentitiesUc.Identities = sender.SenderIdentities;
            SenderAddressUc.Address = sender.Address;
            SenderNameUc.IfpName = sender.SenderName;
            SenderContactUc.ContactData = elbaInformation.SenderInformation.ContactData;

            Receiver receiver = elbaInformation.RecieverInformation;
            RecieverBankIdUc.BankId = receiver.BankId;
            RecieverAddressUc.Address = receiver.Address;
            RecieverAddressUc.SetIfpDataContainer(_dataContainer);
            RecieverContactPersonUc.ContactPerson = receiver.ContactPerson;

            Customer customer = elbaInformation.CustomerInformation;
            CustomerIdentitiesUc.Identities = customer.Identities;
            CustomerAddressUc.Address = customer.Address;
            CustomerAddressUc.DisplayGcdButton = true;
            CustomerAddressUc.SetIfpDataContainer(_dataContainer);
            CustomerContactUc.ContactData = customer.ContactData;

            BalanceInformation.BalanceInformation = elbaInformation.PrimaryBalanceInformation;

            CustomerTextBox.DataBindings.Clear();
            CustomerTextBox.SetTextDataBinding(customer, nameof(customer.Name));
            ClientConfigurationUc.IfpDataContainer = _dataContainer;

            SetEnabledStateForLoadDeleteMenuItems();

            GcdToolTip.SetToolTip(BtnSetGcdCustomer, GuiHelper.GetGcdValueTooltipText("Name"));
        }

        private void SendData(IfpDataContainer container, bool isTest = false)
        {
            try
            {
                _lastRequestResult = container.SendData(ChannelSoftware, isTest);
                MessageBox.Show(_lastRequestResult.IsLocalResult
                    ? "Daten wurden nicht gesendet. Bitte überprüfen Sie die Meldungen."
                    : "Daten wurden gesendet. Bitte überprüfen Sie die Meldungen");
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SendData(_dataContainer, chk_Testsubmission.Checked);
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void HttpProxySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HttpProxySettings settings = _dataContainer.HttpProxySettings.Copy();
                HttpProxySettingsForm form = new HttpProxySettingsForm { HttpProxySettings = settings };
                if (form.ShowDialog() == DialogResult.OK)
                    form.HttpProxySettings.CopyTo(_dataContainer.HttpProxySettings);
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void ShowMessagesButton_Click(object sender, EventArgs e)
        {
            try
            {
                RequestResultsForm form = new RequestResultsForm { RequestResult = _lastRequestResult };
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout(true);
        }

        private void ValidationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EditIfpSettings();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
            
        }

        private void EditIfpSettings()
        {
            IfpSettingsForm form = new IfpSettingsForm { Settings = _dataContainer.IfpClientSettings };
            if (form.ShowDialog() == DialogResult.OK)
                _dataContainer.IfpClientSettings.Save();
        }

        private void BtnSetGcdCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomerFromGcd();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void SetCustomerFromGcd()
        {
            string value =
                _dataContainer.ElbaInformation.PrimaryBalanceInformation.GetGcdNodeValue(
                    GcdDataValidator.CompanyNameConcept);

            if (!string.IsNullOrEmpty(value))
                _dataContainer.ElbaInformation.CustomerInformation.Name = value;
        }

        private void BtnClose_Click(object sender, EventArgs e)
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

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (AboutForm form = new AboutForm())
                    form.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void LoadSessionDataMenuItem_Click(object sender, EventArgs e)
        {
            _dataContainer = new IfpDataContainer(true);
            InitControls();
        }

        private void SaveSessionMenuItem_Click(object sender, EventArgs e)
        {
            _dataContainer.ElbaInformation.Save();
            _dataContainer.HeaderIdentity.Save();

            SetEnabledStateForLoadDeleteMenuItems();
        }

        private void ResetSessionMenuItem_Click(object sender, EventArgs e)
        {
            _dataContainer = new IfpDataContainer();
            InitControls();
        }

        private void DeleteSessionMenuItem_Click(object sender, EventArgs e)
        {
            if (_dataContainer.ElbaInformation.IsStoredAsFile())
                _dataContainer.ElbaInformation.DeleteStoredFile();
            if (_dataContainer.HeaderIdentity.IsStoredAsFile())
                _dataContainer.HeaderIdentity.DeleteStoredFile();

            SetEnabledStateForLoadDeleteMenuItems();
        }

        private void SetEnabledStateForLoadDeleteMenuItems()
        {
            LoadSessionDataMenuItem.Enabled = _dataContainer.ElbaInformation.IsStoredAsFile() || _dataContainer.HeaderIdentity.IsStoredAsFile();
            DeleteSessionMenuItem.Enabled = _dataContainer.ElbaInformation.IsStoredAsFile() || _dataContainer.HeaderIdentity.IsStoredAsFile();
        }
    }
}
