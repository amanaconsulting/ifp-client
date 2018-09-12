using AMANA.IFP.UserControls;

namespace AMANA.IFP.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnSend = new System.Windows.Forms.Button();
            this.InformationTabs = new System.Windows.Forms.TabControl();
            this.BalanceInfoTabPage = new System.Windows.Forms.TabPage();
            this.BalanceInformation = new AMANA.IFP.UserControls.BalanceInformationUc();
            this.CustomerInfoTabPage = new System.Windows.Forms.TabPage();
            this.BtnSetGcdCustomer = new System.Windows.Forms.Button();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.CustomerContactUc = new AMANA.IFP.UserControls.ContactUc();
            this.CustomerAddressUc = new AMANA.IFP.UserControls.AddressUc();
            this.CustomerIdentitiesUc = new AMANA.IFP.UserControls.CustomerIdentitiesUc();
            this.RecieverTabPage = new System.Windows.Forms.TabPage();
            this.RecieverContactPersonUc = new AMANA.IFP.UserControls.ContactPersonUc();
            this.RecieverAddressUc = new AMANA.IFP.UserControls.AddressUc();
            this.RecieverBankIdUc = new AMANA.IFP.UserControls.BankIdUc();
            this.SenderInfoTabPage = new System.Windows.Forms.TabPage();
            this.SenderInformationPanel = new System.Windows.Forms.Panel();
            this.SenderNameUc = new AMANA.IFP.UserControls.NameUc();
            this.SenderAddressUc = new AMANA.IFP.UserControls.AddressUc();
            this.SenderIdentitiesUc = new AMANA.IFP.UserControls.SenderIdentitiesUc();
            this.SenderContactUc = new AMANA.IFP.UserControls.ContactUc();
            this.IfpConfigurationTabPage = new System.Windows.Forms.TabPage();
            this.ClientConfigurationUc = new AMANA.IFP.UserControls.ClientConfigurationUc();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadSessionDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSessionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IfpSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HttpProxySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMessagesButton = new System.Windows.Forms.Button();
            this.LblMandatoryFieldsInfo = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GcdToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chk_Testsubmission = new System.Windows.Forms.CheckBox();
            this.DeleteSessionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetSessionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationTabs.SuspendLayout();
            this.BalanceInfoTabPage.SuspendLayout();
            this.CustomerInfoTabPage.SuspendLayout();
            this.RecieverTabPage.SuspendLayout();
            this.SenderInfoTabPage.SuspendLayout();
            this.SenderInformationPanel.SuspendLayout();
            this.IfpConfigurationTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSend.Location = new System.Drawing.Point(23, 676);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "Senden";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // InformationTabs
            // 
            this.InformationTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationTabs.Controls.Add(this.BalanceInfoTabPage);
            this.InformationTabs.Controls.Add(this.CustomerInfoTabPage);
            this.InformationTabs.Controls.Add(this.RecieverTabPage);
            this.InformationTabs.Controls.Add(this.SenderInfoTabPage);
            this.InformationTabs.Controls.Add(this.IfpConfigurationTabPage);
            this.InformationTabs.Location = new System.Drawing.Point(13, 40);
            this.InformationTabs.Multiline = true;
            this.InformationTabs.Name = "InformationTabs";
            this.InformationTabs.SelectedIndex = 0;
            this.InformationTabs.Size = new System.Drawing.Size(659, 630);
            this.InformationTabs.TabIndex = 0;
            // 
            // BalanceInfoTabPage
            // 
            this.BalanceInfoTabPage.Controls.Add(this.BalanceInformation);
            this.BalanceInfoTabPage.Location = new System.Drawing.Point(4, 46);
            this.BalanceInfoTabPage.Name = "BalanceInfoTabPage";
            this.BalanceInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BalanceInfoTabPage.Size = new System.Drawing.Size(651, 580);
            this.BalanceInfoTabPage.TabIndex = 3;
            this.BalanceInfoTabPage.Text = "Abschlussinformationen";
            this.BalanceInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // BalanceInformation
            // 
            this.BalanceInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceInformation.BalanceInformation = null;
            this.BalanceInformation.Location = new System.Drawing.Point(6, 6);
            this.BalanceInformation.Margin = new System.Windows.Forms.Padding(4);
            this.BalanceInformation.Name = "BalanceInformation";
            this.BalanceInformation.Size = new System.Drawing.Size(639, 568);
            this.BalanceInformation.TabIndex = 0;
            // 
            // CustomerInfoTabPage
            // 
            this.CustomerInfoTabPage.Controls.Add(this.BtnSetGcdCustomer);
            this.CustomerInfoTabPage.Controls.Add(this.CustomerTextBox);
            this.CustomerInfoTabPage.Controls.Add(this.LblCustomerName);
            this.CustomerInfoTabPage.Controls.Add(this.CustomerContactUc);
            this.CustomerInfoTabPage.Controls.Add(this.CustomerAddressUc);
            this.CustomerInfoTabPage.Controls.Add(this.CustomerIdentitiesUc);
            this.CustomerInfoTabPage.Location = new System.Drawing.Point(4, 46);
            this.CustomerInfoTabPage.Name = "CustomerInfoTabPage";
            this.CustomerInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerInfoTabPage.Size = new System.Drawing.Size(651, 580);
            this.CustomerInfoTabPage.TabIndex = 2;
            this.CustomerInfoTabPage.Text = "Kundeninformationen";
            this.CustomerInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // BtnSetGcdCustomer
            // 
            this.BtnSetGcdCustomer.Image = global::AMANA.IFP.Properties.Resources.nav_refresh_blue_16x16;
            this.BtnSetGcdCustomer.Location = new System.Drawing.Point(150, 3);
            this.BtnSetGcdCustomer.Name = "BtnSetGcdCustomer";
            this.BtnSetGcdCustomer.Size = new System.Drawing.Size(25, 25);
            this.BtnSetGcdCustomer.TabIndex = 1;
            this.BtnSetGcdCustomer.UseVisualStyleBackColor = true;
            this.BtnSetGcdCustomer.Click += new System.EventHandler(this.BtnSetGcdCustomer_Click);
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerTextBox.Location = new System.Drawing.Point(181, 6);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.Size = new System.Drawing.Size(463, 22);
            this.CustomerTextBox.TabIndex = 2;
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Location = new System.Drawing.Point(6, 9);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(50, 17);
            this.LblCustomerName.TabIndex = 0;
            this.LblCustomerName.Text = "Name*";
            // 
            // CustomerContactUc
            // 
            this.CustomerContactUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerContactUc.ContactData = null;
            this.CustomerContactUc.Location = new System.Drawing.Point(3, 380);
            this.CustomerContactUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerContactUc.Name = "CustomerContactUc";
            this.CustomerContactUc.Size = new System.Drawing.Size(641, 158);
            this.CustomerContactUc.TabIndex = 5;
            // 
            // CustomerAddressUc
            // 
            this.CustomerAddressUc.Address = null;
            this.CustomerAddressUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerAddressUc.DisplayGcdButton = false;
            this.CustomerAddressUc.Location = new System.Drawing.Point(3, 156);
            this.CustomerAddressUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerAddressUc.Name = "CustomerAddressUc";
            this.CustomerAddressUc.Size = new System.Drawing.Size(642, 218);
            this.CustomerAddressUc.TabIndex = 4;
            // 
            // CustomerIdentitiesUc
            // 
            this.CustomerIdentitiesUc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerIdentitiesUc.Identities = null;
            this.CustomerIdentitiesUc.Location = new System.Drawing.Point(3, 32);
            this.CustomerIdentitiesUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerIdentitiesUc.Name = "CustomerIdentitiesUc";
            this.CustomerIdentitiesUc.Size = new System.Drawing.Size(641, 118);
            this.CustomerIdentitiesUc.TabIndex = 3;
            // 
            // RecieverTabPage
            // 
            this.RecieverTabPage.Controls.Add(this.RecieverContactPersonUc);
            this.RecieverTabPage.Controls.Add(this.RecieverAddressUc);
            this.RecieverTabPage.Controls.Add(this.RecieverBankIdUc);
            this.RecieverTabPage.Location = new System.Drawing.Point(4, 46);
            this.RecieverTabPage.Name = "RecieverTabPage";
            this.RecieverTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RecieverTabPage.Size = new System.Drawing.Size(651, 580);
            this.RecieverTabPage.TabIndex = 1;
            this.RecieverTabPage.Text = "Empfängerinformationen";
            this.RecieverTabPage.UseVisualStyleBackColor = true;
            // 
            // RecieverContactPersonUc
            // 
            this.RecieverContactPersonUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecieverContactPersonUc.ContactPerson = null;
            this.RecieverContactPersonUc.Location = new System.Drawing.Point(6, 342);
            this.RecieverContactPersonUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecieverContactPersonUc.Name = "RecieverContactPersonUc";
            this.RecieverContactPersonUc.Size = new System.Drawing.Size(645, 96);
            this.RecieverContactPersonUc.TabIndex = 2;
            // 
            // RecieverAddressUc
            // 
            this.RecieverAddressUc.Address = null;
            this.RecieverAddressUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecieverAddressUc.DisplayGcdButton = false;
            this.RecieverAddressUc.Location = new System.Drawing.Point(6, 118);
            this.RecieverAddressUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecieverAddressUc.Name = "RecieverAddressUc";
            this.RecieverAddressUc.Size = new System.Drawing.Size(642, 218);
            this.RecieverAddressUc.TabIndex = 1;
            // 
            // RecieverBankIdUc
            // 
            this.RecieverBankIdUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecieverBankIdUc.BankId = null;
            this.RecieverBankIdUc.Location = new System.Drawing.Point(6, 6);
            this.RecieverBankIdUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecieverBankIdUc.Name = "RecieverBankIdUc";
            this.RecieverBankIdUc.Size = new System.Drawing.Size(639, 106);
            this.RecieverBankIdUc.TabIndex = 0;
            // 
            // SenderInfoTabPage
            // 
            this.SenderInfoTabPage.Controls.Add(this.SenderInformationPanel);
            this.SenderInfoTabPage.Location = new System.Drawing.Point(4, 46);
            this.SenderInfoTabPage.Name = "SenderInfoTabPage";
            this.SenderInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SenderInfoTabPage.Size = new System.Drawing.Size(651, 580);
            this.SenderInfoTabPage.TabIndex = 0;
            this.SenderInfoTabPage.Text = "Absenderinformationen";
            this.SenderInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // SenderInformationPanel
            // 
            this.SenderInformationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderInformationPanel.Controls.Add(this.SenderNameUc);
            this.SenderInformationPanel.Controls.Add(this.SenderAddressUc);
            this.SenderInformationPanel.Controls.Add(this.SenderIdentitiesUc);
            this.SenderInformationPanel.Controls.Add(this.SenderContactUc);
            this.SenderInformationPanel.Location = new System.Drawing.Point(7, 7);
            this.SenderInformationPanel.Name = "SenderInformationPanel";
            this.SenderInformationPanel.Size = new System.Drawing.Size(638, 567);
            this.SenderInformationPanel.TabIndex = 0;
            // 
            // SenderNameUc
            // 
            this.SenderNameUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderNameUc.IfpName = null;
            this.SenderNameUc.Location = new System.Drawing.Point(0, 314);
            this.SenderNameUc.Margin = new System.Windows.Forms.Padding(4);
            this.SenderNameUc.Name = "SenderNameUc";
            this.SenderNameUc.Size = new System.Drawing.Size(629, 85);
            this.SenderNameUc.TabIndex = 2;
            // 
            // SenderAddressUc
            // 
            this.SenderAddressUc.Address = null;
            this.SenderAddressUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderAddressUc.DisplayGcdButton = false;
            this.SenderAddressUc.Location = new System.Drawing.Point(-1, 90);
            this.SenderAddressUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SenderAddressUc.Name = "SenderAddressUc";
            this.SenderAddressUc.Size = new System.Drawing.Size(633, 218);
            this.SenderAddressUc.TabIndex = 1;
            // 
            // SenderIdentitiesUc
            // 
            this.SenderIdentitiesUc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderIdentitiesUc.Identities = null;
            this.SenderIdentitiesUc.Location = new System.Drawing.Point(3, 3);
            this.SenderIdentitiesUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SenderIdentitiesUc.Name = "SenderIdentitiesUc";
            this.SenderIdentitiesUc.Size = new System.Drawing.Size(629, 81);
            this.SenderIdentitiesUc.TabIndex = 0;
            // 
            // SenderContactUc
            // 
            this.SenderContactUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderContactUc.ContactData = null;
            this.SenderContactUc.Location = new System.Drawing.Point(-1, 405);
            this.SenderContactUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SenderContactUc.Name = "SenderContactUc";
            this.SenderContactUc.Size = new System.Drawing.Size(638, 159);
            this.SenderContactUc.TabIndex = 3;
            // 
            // IfpConfigurationTabPage
            // 
            this.IfpConfigurationTabPage.Controls.Add(this.ClientConfigurationUc);
            this.IfpConfigurationTabPage.Location = new System.Drawing.Point(4, 46);
            this.IfpConfigurationTabPage.Name = "IfpConfigurationTabPage";
            this.IfpConfigurationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IfpConfigurationTabPage.Size = new System.Drawing.Size(651, 580);
            this.IfpConfigurationTabPage.TabIndex = 4;
            this.IfpConfigurationTabPage.Text = "Client-Konfiguration";
            this.IfpConfigurationTabPage.UseVisualStyleBackColor = true;
            // 
            // ClientConfigurationUc
            // 
            this.ClientConfigurationUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientConfigurationUc.IfpDataContainer = null;
            this.ClientConfigurationUc.Location = new System.Drawing.Point(6, 6);
            this.ClientConfigurationUc.Margin = new System.Windows.Forms.Padding(4);
            this.ClientConfigurationUc.Name = "ClientConfigurationUc";
            this.ClientConfigurationUc.Size = new System.Drawing.Size(642, 192);
            this.ClientConfigurationUc.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetSessionMenuItem,
            this.LoadSessionDataMenuItem,
            this.SaveSessionMenuItem,
            this.DeleteSessionMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // LoadSessionDataMenuItem
            // 
            this.LoadSessionDataMenuItem.Name = "LoadSessionDataMenuItem";
            this.LoadSessionDataMenuItem.Size = new System.Drawing.Size(313, 26);
            this.LoadSessionDataMenuItem.Text = "Zuletzt gespeicherte Sitzung laden";
            this.LoadSessionDataMenuItem.Click += new System.EventHandler(this.LoadSessionDataMenuItem_Click);
            // 
            // SaveSessionMenuItem
            // 
            this.SaveSessionMenuItem.Name = "SaveSessionMenuItem";
            this.SaveSessionMenuItem.Size = new System.Drawing.Size(313, 26);
            this.SaveSessionMenuItem.Text = "Aktuelle Sitzung speichern";
            this.SaveSessionMenuItem.Click += new System.EventHandler(this.SaveSessionMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IfpSettingsToolStripMenuItem,
            this.HttpProxySettingsToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.SettingsToolStripMenuItem.Text = "&Einstellungen";
            // 
            // IfpSettingsToolStripMenuItem
            // 
            this.IfpSettingsToolStripMenuItem.Name = "IfpSettingsToolStripMenuItem";
            this.IfpSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.IfpSettingsToolStripMenuItem.Text = "&Allgemeine Einstellungen";
            this.IfpSettingsToolStripMenuItem.Click += new System.EventHandler(this.ValidationSettingsToolStripMenuItem_Click);
            // 
            // HttpProxySettingsToolStripMenuItem
            // 
            this.HttpProxySettingsToolStripMenuItem.Name = "HttpProxySettingsToolStripMenuItem";
            this.HttpProxySettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.HttpProxySettingsToolStripMenuItem.Text = "&Proxy-Einstellungen";
            this.HttpProxySettingsToolStripMenuItem.Click += new System.EventHandler(this.HttpProxySettingsToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.hilfeToolStripMenuItem.Text = "&Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.überToolStripMenuItem.Text = "&Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // ShowMessagesButton
            // 
            this.ShowMessagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowMessagesButton.Location = new System.Drawing.Point(105, 676);
            this.ShowMessagesButton.Name = "ShowMessagesButton";
            this.ShowMessagesButton.Size = new System.Drawing.Size(125, 23);
            this.ShowMessagesButton.TabIndex = 4;
            this.ShowMessagesButton.Text = "Meldungen anzeigen";
            this.ShowMessagesButton.UseVisualStyleBackColor = true;
            this.ShowMessagesButton.Click += new System.EventHandler(this.ShowMessagesButton_Click);
            // 
            // LblMandatoryFieldsInfo
            // 
            this.LblMandatoryFieldsInfo.AutoSize = true;
            this.LblMandatoryFieldsInfo.Location = new System.Drawing.Point(10, 24);
            this.LblMandatoryFieldsInfo.Name = "LblMandatoryFieldsInfo";
            this.LblMandatoryFieldsInfo.Size = new System.Drawing.Size(293, 17);
            this.LblMandatoryFieldsInfo.TabIndex = 1;
            this.LblMandatoryFieldsInfo.Text = "Pflichtfelder sind mit einem * gekennzeichnet.";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(597, 676);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Schließen";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // chk_Testsubmission
            // 
            this.chk_Testsubmission.AutoSize = true;
            this.chk_Testsubmission.Location = new System.Drawing.Point(236, 682);
            this.chk_Testsubmission.Name = "chk_Testsubmission";
            this.chk_Testsubmission.Size = new System.Drawing.Size(136, 21);
            this.chk_Testsubmission.TabIndex = 6;
            this.chk_Testsubmission.Text = "Testübermittlung";
            this.chk_Testsubmission.UseVisualStyleBackColor = true;
            // 
            // DeleteSessionMenuItem
            // 
            this.DeleteSessionMenuItem.Name = "DeleteSessionMenuItem";
            this.DeleteSessionMenuItem.Size = new System.Drawing.Size(313, 26);
            this.DeleteSessionMenuItem.Text = "Sitzungsdaten löschen";
            this.DeleteSessionMenuItem.Click += new System.EventHandler(this.DeleteSessionMenuItem_Click);
            // 
            // ResetSessionMenuItem
            // 
            this.ResetSessionMenuItem.Name = "ResetSessionMenuItem";
            this.ResetSessionMenuItem.Size = new System.Drawing.Size(313, 26);
            this.ResetSessionMenuItem.Text = "Aktuelle Sitzung zurücksetzen";
            this.ResetSessionMenuItem.Click += new System.EventHandler(this.ResetSessionMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.chk_Testsubmission);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblMandatoryFieldsInfo);
            this.Controls.Add(this.ShowMessagesButton);
            this.Controls.Add(this.InformationTabs);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 725);
            this.Name = "MainForm";
            this.Text = "Client für den Digitalen Finanzbericht";
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.InformationTabs.ResumeLayout(false);
            this.BalanceInfoTabPage.ResumeLayout(false);
            this.CustomerInfoTabPage.ResumeLayout(false);
            this.CustomerInfoTabPage.PerformLayout();
            this.RecieverTabPage.ResumeLayout(false);
            this.SenderInfoTabPage.ResumeLayout(false);
            this.SenderInformationPanel.ResumeLayout(false);
            this.IfpConfigurationTabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TabControl InformationTabs;
        private System.Windows.Forms.TabPage SenderInfoTabPage;
        private System.Windows.Forms.TabPage RecieverTabPage;
        private System.Windows.Forms.TabPage CustomerInfoTabPage;
        private System.Windows.Forms.TabPage BalanceInfoTabPage;
        private System.Windows.Forms.Panel SenderInformationPanel;
        private ContactUc SenderContactUc;
        private SenderIdentitiesUc SenderIdentitiesUc;
        private AddressUc SenderAddressUc;
        private NameUc SenderNameUc;
        private BankIdUc RecieverBankIdUc;
        private AddressUc RecieverAddressUc;
        private ContactPersonUc RecieverContactPersonUc;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.Label LblCustomerName;
        private CustomerIdentitiesUc CustomerIdentitiesUc;
        private AddressUc CustomerAddressUc;
        private ContactUc CustomerContactUc;
        private System.Windows.Forms.TabPage IfpConfigurationTabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HttpProxySettingsToolStripMenuItem;
        private System.Windows.Forms.Button ShowMessagesButton;
        private System.Windows.Forms.ToolStripMenuItem IfpSettingsToolStripMenuItem;
        private BalanceInformationUc BalanceInformation;
        private System.Windows.Forms.Button BtnSetGcdCustomer;
        private System.Windows.Forms.Label LblMandatoryFieldsInfo;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ToolTip GcdToolTip;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private ClientConfigurationUc ClientConfigurationUc;
        private System.Windows.Forms.CheckBox chk_Testsubmission;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadSessionDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSessionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetSessionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteSessionMenuItem;
    }
}

