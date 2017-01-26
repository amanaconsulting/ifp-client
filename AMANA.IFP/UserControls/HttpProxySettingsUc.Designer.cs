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
            this.ProxyTypeLabe = new System.Windows.Forms.Label();
            this.ProxyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.HttpProxyAddressTextBox = new System.Windows.Forms.TextBox();
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
            this.HttpProxySettingsGroupBox.Controls.Add(this.ProxyTypeLabe);
            this.HttpProxySettingsGroupBox.Controls.Add(this.ProxyTypeComboBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyAddressTextBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyUsernameTextBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyPasswordTextBox);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyPasswordLabel);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyAddressLabel);
            this.HttpProxySettingsGroupBox.Controls.Add(this.HttpProxyUserNameLabel);
            this.HttpProxySettingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.HttpProxySettingsGroupBox.Name = "HttpProxySettingsGroupBox";
            this.HttpProxySettingsGroupBox.Size = new System.Drawing.Size(299, 144);
            this.HttpProxySettingsGroupBox.TabIndex = 0;
            this.HttpProxySettingsGroupBox.TabStop = false;
            this.HttpProxySettingsGroupBox.Text = "HTTP-Proxyeinstellungen";
            // 
            // ProxyTypeLabe
            // 
            this.ProxyTypeLabe.AutoSize = true;
            this.ProxyTypeLabe.Location = new System.Drawing.Point(7, 22);
            this.ProxyTypeLabe.Name = "ProxyTypeLabe";
            this.ProxyTypeLabe.Size = new System.Drawing.Size(47, 13);
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
            this.ProxyTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProxyTypeComboBox.TabIndex = 1;
            this.ProxyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ProxyTypeComboBox_SelectedIndexChanged);
            // 
            // HttpProxyAddressTextBox
            // 
            this.HttpProxyAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HttpProxyAddressTextBox.Enabled = false;
            this.HttpProxyAddressTextBox.Location = new System.Drawing.Point(172, 46);
            this.HttpProxyAddressTextBox.Name = "HttpProxyAddressTextBox";
            this.HttpProxyAddressTextBox.Size = new System.Drawing.Size(120, 20);
            this.HttpProxyAddressTextBox.TabIndex = 3;
            // 
            // HttpProxyUsernameTextBox
            // 
            this.HttpProxyUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HttpProxyUsernameTextBox.Enabled = false;
            this.HttpProxyUsernameTextBox.Location = new System.Drawing.Point(172, 72);
            this.HttpProxyUsernameTextBox.Name = "HttpProxyUsernameTextBox";
            this.HttpProxyUsernameTextBox.Size = new System.Drawing.Size(120, 20);
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
            this.HttpProxyPasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.HttpProxyPasswordTextBox.TabIndex = 7;
            // 
            // HttpProxyPasswordLabel
            // 
            this.HttpProxyPasswordLabel.AutoSize = true;
            this.HttpProxyPasswordLabel.Location = new System.Drawing.Point(6, 101);
            this.HttpProxyPasswordLabel.Name = "HttpProxyPasswordLabel";
            this.HttpProxyPasswordLabel.Size = new System.Drawing.Size(50, 13);
            this.HttpProxyPasswordLabel.TabIndex = 6;
            this.HttpProxyPasswordLabel.Text = "Passwort";
            // 
            // HttpProxyAddressLabel
            // 
            this.HttpProxyAddressLabel.AutoSize = true;
            this.HttpProxyAddressLabel.Location = new System.Drawing.Point(7, 49);
            this.HttpProxyAddressLabel.Name = "HttpProxyAddressLabel";
            this.HttpProxyAddressLabel.Size = new System.Drawing.Size(74, 13);
            this.HttpProxyAddressLabel.TabIndex = 2;
            this.HttpProxyAddressLabel.Text = "Proxy-Adresse";
            // 
            // HttpProxyUserNameLabel
            // 
            this.HttpProxyUserNameLabel.AutoSize = true;
            this.HttpProxyUserNameLabel.Location = new System.Drawing.Point(6, 75);
            this.HttpProxyUserNameLabel.Name = "HttpProxyUserNameLabel";
            this.HttpProxyUserNameLabel.Size = new System.Drawing.Size(75, 13);
            this.HttpProxyUserNameLabel.TabIndex = 4;
            this.HttpProxyUserNameLabel.Text = "Benutzername";
            // 
            // HttpProxySettingsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HttpProxySettingsGroupBox);
            this.Name = "HttpProxySettingsUc";
            this.Size = new System.Drawing.Size(305, 150);
            this.HttpProxySettingsGroupBox.ResumeLayout(false);
            this.HttpProxySettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HttpProxySettingsGroupBox;
        private System.Windows.Forms.TextBox HttpProxyAddressTextBox;
        private System.Windows.Forms.TextBox HttpProxyUsernameTextBox;
        private System.Windows.Forms.TextBox HttpProxyPasswordTextBox;
        private System.Windows.Forms.Label HttpProxyPasswordLabel;
        private System.Windows.Forms.Label HttpProxyAddressLabel;
        private System.Windows.Forms.Label HttpProxyUserNameLabel;
        private System.Windows.Forms.Label ProxyTypeLabe;
        private System.Windows.Forms.ComboBox ProxyTypeComboBox;
    }
}
