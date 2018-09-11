using System.Windows.Forms;

namespace AMANA.IFP.UserControls
{
    partial class HttpProxySettingsUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HttpProxySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.SeparatorLabel = new System.Windows.Forms.Label();
            this.ProxyPortTextBox = new System.Windows.Forms.TextBox();
            this.ProxyTypeLabe = new System.Windows.Forms.Label();
            this.ProxyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.HttpProxyHostTextBox = new System.Windows.Forms.TextBox();
            this.HttpProxyUsernameTextBox = new System.Windows.Forms.TextBox();
            this.HttpProxyPasswordTextBox = new System.Windows.Forms.TextBox();
            this.HttpProxyPasswordLabel = new System.Windows.Forms.Label();
            this.HttpProxyAddressLabel = new System.Windows.Forms.Label();
            this.HttpProxyUserNameLabel = new System.Windows.Forms.Label();
            this.HttpProxySettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HttpProxySettingsGroupBox
            // 
            this.HttpProxySettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HttpProxySettingsGroupBox.Controls.Add(this.SeparatorLabel);
            this.HttpProxySettingsGroupBox.Controls.Add(this.ProxyPortTextBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.ProxyTypeLabe);
            this.HttpProxySettingsGroupBox.Controls.Add(this.ProxyTypeComboBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyHostTextBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyUsernameTextBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyPasswordTextBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyPasswordLabel);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyAddressLabel);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyUserNameLabel);
            this.HttpProxySettingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.HttpProxySettingsGroupBox.Name = "HttpProxySettingsGroupBox";
            this.HttpProxySettingsGroupBox.Size = new System.Drawing.Size(400, 144);
            this.HttpProxySettingsGroupBox.TabIndex = 0;
            this.HttpProxySettingsGroupBox.TabStop = false;
            this.HttpProxySettingsGroupBox.Text = "HTTP-Proxyeinstellungen";
            // 
            // SeparatorLabel
            // 
            this.SeparatorLabel.Location = new System.Drawing.Point(325, 47);
            this.SeparatorLabel.Name = "SeparatorLabel";
            this.SeparatorLabel.Size = new System.Drawing.Size(12, 17);
            this.SeparatorLabel.TabIndex = 9;
            this.SeparatorLabel.Text = ":";
            // 
            // ProxyPortTextBox
            // 
            this.ProxyPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyPortTextBox.Enabled = false;
            this.ProxyPortTextBox.Location = new System.Drawing.Point(340, 46);
            this.ProxyPortTextBox.Name = "ProxyPortTextBox";
            this.ProxyPortTextBox.Size = new System.Drawing.Size(53, 22);
            this.ProxyPortTextBox.TabIndex = 4;
            // 
            // ProxyTypeLabe
            // 
            this.ProxyTypeLabe.AutoSize = true;
            this.ProxyTypeLabe.Location = new System.Drawing.Point(7, 22);
            this.ProxyTypeLabe.Name = "ProxyTypeLabe";
            this.ProxyTypeLabe.Size = new System.Drawing.Size(62, 17);
            this.ProxyTypeLabe.TabIndex = 0;
            this.ProxyTypeLabe.Text = "Proxytyp";
            // 
            // ProxyTypeComboBox
            // 
            this.ProxyTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProxyTypeComboBox.FormattingEnabled = true;
            this.ProxyTypeComboBox.Location = new System.Drawing.Point(172, 19);
            this.ProxyTypeComboBox.Name = "ProxyTypeComboBox";
            this.ProxyTypeComboBox.Size = new System.Drawing.Size(222, 24);
            this.ProxyTypeComboBox.TabIndex = 1;
            this.ProxyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ProxyTypeComboBox_SelectedIndexChanged);
            // 
            // HttpProxyHostTextBox
            // 
            this.HttpProxyHostTextBox.Enabled = false;
            this.HttpProxyHostTextBox.Location = new System.Drawing.Point(172, 46);
            this.HttpProxyHostTextBox.Name = "HttpProxyHostTextBox";
            this.HttpProxyHostTextBox.Size = new System.Drawing.Size(150, 22);
            this.HttpProxyHostTextBox.TabIndex = 3;
            // 
            // HttpProxyUsernameTextBox
            // 
            this.HttpProxyUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HttpProxyUsernameTextBox.Enabled = false;
            this.HttpProxyUsernameTextBox.Location = new System.Drawing.Point(172, 72);
            this.HttpProxyUsernameTextBox.Name = "HttpProxyUsernameTextBox";
            this.HttpProxyUsernameTextBox.Size = new System.Drawing.Size(221, 22);
            this.HttpProxyUsernameTextBox.TabIndex = 5;
            // 
            // HttpProxyPasswordTextBox
            // 
            this.HttpProxyPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HttpProxyPasswordTextBox.Enabled = false;
            this.HttpProxyPasswordTextBox.Location = new System.Drawing.Point(172, 98);
            this.HttpProxyPasswordTextBox.Name = "HttpProxyPasswordTextBox";
            this.HttpProxyPasswordTextBox.PasswordChar = '*';
            this.HttpProxyPasswordTextBox.Size = new System.Drawing.Size(221, 22);
            this.HttpProxyPasswordTextBox.TabIndex = 7;
            // 
            // HttpProxyPasswordLabel
            // 
            this.HttpProxyPasswordLabel.AutoSize = true;
            this.HttpProxyPasswordLabel.Location = new System.Drawing.Point(6, 101);
            this.HttpProxyPasswordLabel.Name = "HttpProxyPasswordLabel";
            this.HttpProxyPasswordLabel.Size = new System.Drawing.Size(65, 17);
            this.HttpProxyPasswordLabel.TabIndex = 6;
            this.HttpProxyPasswordLabel.Text = "Passwort";
            // 
            // HttpProxyAddressLabel
            // 
            this.HttpProxyAddressLabel.AutoSize = true;
            this.HttpProxyAddressLabel.Location = new System.Drawing.Point(7, 49);
            this.HttpProxyAddressLabel.Name = "HttpProxyAddressLabel";
            this.HttpProxyAddressLabel.Size = new System.Drawing.Size(107, 17);
            this.HttpProxyAddressLabel.TabIndex = 2;
            this.HttpProxyAddressLabel.Text = "Proxy-Host:Port";
            // 
            // HttpProxyUserNameLabel
            // 
            this.HttpProxyUserNameLabel.AutoSize = true;
            this.HttpProxyUserNameLabel.Location = new System.Drawing.Point(6, 75);
            this.HttpProxyUserNameLabel.Name = "HttpProxyUserNameLabel";
            this.HttpProxyUserNameLabel.Size = new System.Drawing.Size(100, 17);
            this.HttpProxyUserNameLabel.TabIndex = 4;
            this.HttpProxyUserNameLabel.Text = "Benutzername";
            // 
            // HttpProxySettingsUc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.HttpProxySettingsGroupBox);
            this.Name = "HttpProxySettingsUc";
            this.Size = new System.Drawing.Size(400, 150);
            this.HttpProxySettingsGroupBox.ResumeLayout(false);
            this.HttpProxySettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HttpProxySettingsGroupBox;
        private System.Windows.Forms.TextBox HttpProxyHostTextBox;
        private System.Windows.Forms.TextBox HttpProxyUsernameTextBox;
        private System.Windows.Forms.TextBox HttpProxyPasswordTextBox;
        private System.Windows.Forms.Label HttpProxyPasswordLabel;
        private System.Windows.Forms.Label HttpProxyAddressLabel;
        private System.Windows.Forms.Label HttpProxyUserNameLabel;
        private System.Windows.Forms.Label ProxyTypeLabe;
        private System.Windows.Forms.ComboBox ProxyTypeComboBox;
        private System.Windows.Forms.Label SeparatorLabel;
        private System.Windows.Forms.TextBox ProxyPortTextBox;
    }
}
