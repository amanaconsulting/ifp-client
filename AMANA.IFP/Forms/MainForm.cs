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
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Windows.Forms;
using AMANA.IFP.Client;
using AMANA.IFP.Common;
using AMANA.IFP.Common.Helpers;

namespace AMANA.IFP.Forms
{
    public partial class MainForm : Form
    {
        private RequestResult _lastRequestResult;

        public IfpDataContainer DataContainer { get; set; } = new IfpDataContainer();

        public Software ChannelSoftware { get; set; } = new Software
        {
            Id = "IFP99900045",
            Manufacturer = "AMANA consulting GmbH",
            Name = "IFP Transfer Client",
            Version = Assembly.GetExecutingAssembly().GetName().Version.ToString()
        };

        public MainForm()
        {
            InitializeComponent();
            InitControls();
        }       

        private void InitControls()
        {
            ElbaInformation elbaInformation = DataContainer.ElbaInformation;
            Sender sender = elbaInformation.SenderInformation;
            SenderIdentitiesUc.Identities = sender.SenderIdentities;
            SenderAddressUc.Address = sender.Address;
            SenderNameUc.IfpName = sender.SenderName;
            SenderContactUc.ContactData = elbaInformation.SenderInformation.ContactData;

            Receiver receiver = elbaInformation.RecieverInformation;
            RecieverBankIdUc.BankId = receiver.BankId;
            RecieverAddressUc.Address = receiver.Address;
            RecieverAddressUc.SetIfpDataContainer(DataContainer);
            RecieverContactPersonUc.ContactPerson = receiver.ContactPerson;

            Customer customer = elbaInformation.CustomerInformation;
            CustomerIdentitiesUc.Identities = customer.Identities;
            CustomerAddressUc.Address = customer.Address;
            CustomerAddressUc.DisplayGcdButton = true;
            CustomerAddressUc.SetIfpDataContainer(DataContainer);
            CustomerContactUc.ContactData = customer.ContactData;

            BalanceInformation.BalanceInformation = elbaInformation.PrimaryBalanceInformation;

            CustomerTextBox.DataBindings.Clear();
            CustomerTextBox.SetTextDataBinding(customer, nameof(customer.Name));
            ClientConfigurationUc.IfpDataContainer = DataContainer;

            SetEnabledStateForLoadDeleteMenuItems();

            GcdToolTip.SetToolTip(BtnSetGcdCustomer, GuiHelper.GetGcdValueTooltipText("Name"));
        }

        private void SendData(IfpDataContainer container, bool isTest = false)
        {
            try
            {
                ValidationScopeLabel.Text = String.Empty;
                ValidationResultIconLabel.Text = String.Empty;

                _lastRequestResult = container.SendData(ChannelSoftware, isTest);
                MessageBox.Show(_lastRequestResult.IsLocalResult
                    ? "Daten wurden nicht gesendet. Bitte überprüfen Sie die Meldungen."
                    : "Daten wurden gesendet. Bitte überprüfen Sie die Meldungen");

                if (_lastRequestResult.IsLocalResult)
                {
                    ValidationScopeLabel.Text = "Client";
                    ValidationResultIconLabel.Text = "X";
                    ValidationResultIconLabel.ForeColor = Color.Red;
                }
                else
                {
                    ValidationScopeLabel.Text = "Server";

                    if (_lastRequestResult.ResultMessages.Count == 0 || 
                        _lastRequestResult.ResultMessages.Count == 1 && 
                        _lastRequestResult.ResultMessages.Any(rm => rm.MessageId.Equals(Enums.Fehlercode.F000.ToString(), StringComparison.OrdinalIgnoreCase))
                    )
                    {                        
                        ValidationResultIconLabel.Text = "✓";
                        ValidationResultIconLabel.ForeColor = Color.Green;
                    }
                    else
                    {                       
                        ValidationResultIconLabel.Text = "X";
                        ValidationResultIconLabel.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is FaultException)
                {
                    ValidationScopeLabel.Text = "Server";
                    ValidationResultIconLabel.Text = "X";
                    ValidationResultIconLabel.ForeColor = Color.Red;
                }

                ex.ToMessageBox();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SendData(DataContainer, chk_Testsubmission.Checked);
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
                HttpProxySettings settings = DataContainer.HttpProxySettings;
                HttpProxySettingsForm form = new HttpProxySettingsForm { HttpProxySettings = settings };
                if (form.ShowDialog() == DialogResult.OK)
                    form.HttpProxySettings.Save();
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
            IfpSettingsForm form = new IfpSettingsForm { Settings = DataContainer.IfpClientSettings };
            if (form.ShowDialog() == DialogResult.OK)
                DataContainer.IfpClientSettings.Save();
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
                DataContainer.ElbaInformation.PrimaryBalanceInformation.GetGcdNodeValue(
                    GcdDataValidator.CompanyNameConcept);

            if (!string.IsNullOrEmpty(value))
                DataContainer.ElbaInformation.CustomerInformation.Name = value;
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
            DataContainer = new IfpDataContainer(true);
            InitControls();
        }

        private void SaveSessionMenuItem_Click(object sender, EventArgs e)
        {
            DataContainer.ElbaInformation.Save();
            DataContainer.HeaderIdentity.Save();

            SetEnabledStateForLoadDeleteMenuItems();
        }

        private void ResetSessionMenuItem_Click(object sender, EventArgs e)
        {
            DataContainer = new IfpDataContainer();
            InitControls();
        }

        private void DeleteSessionMenuItem_Click(object sender, EventArgs e)
        {
            if (DataContainer.ElbaInformation.IsStoredAsFile())
                DataContainer.ElbaInformation.DeleteStoredFile();
            if (DataContainer.HeaderIdentity.IsStoredAsFile())
                DataContainer.HeaderIdentity.DeleteStoredFile();

            SetEnabledStateForLoadDeleteMenuItems();
        }

        private void SetEnabledStateForLoadDeleteMenuItems()
        {
            LoadSessionDataMenuItem.Enabled = DataContainer.ElbaInformation.IsStoredAsFile() || DataContainer.HeaderIdentity.IsStoredAsFile();
            DeleteSessionMenuItem.Enabled = DataContainer.ElbaInformation.IsStoredAsFile() || DataContainer.HeaderIdentity.IsStoredAsFile();
        }
    }
}
