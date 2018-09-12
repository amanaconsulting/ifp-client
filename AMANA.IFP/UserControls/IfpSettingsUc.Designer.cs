namespace AMANA.IFP.UserControls
{
    partial class IfpSettingsUc
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
            this.ValidationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.GcdValidationCheckBox = new System.Windows.Forms.CheckBox();
            this.IfpValidationCheckBox = new System.Windows.Forms.CheckBox();
            this.RoutingTableFilePathLabel = new System.Windows.Forms.Label();
            this.RoutingTableFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SearchRoutingTableFilePathButton = new System.Windows.Forms.Button();
            this.CustomRoutingTableFilePathCheckbox = new System.Windows.Forms.CheckBox();
            this.SftpCredentialsGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.CertificateSettingsUc = new AMANA.IFP.UserControls.CertificateSettingsUc();
            this.ValidationSettingsGroupBox.SuspendLayout();
            this.SftpCredentialsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValidationSettingsGroupBox
            // 
            this.ValidationSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidationSettingsGroupBox.Controls.Add(this.GcdValidationCheckBox);
            this.ValidationSettingsGroupBox.Controls.Add(this.IfpValidationCheckBox);
            this.ValidationSettingsGroupBox.Location = new System.Drawing.Point(9, 152);
            this.ValidationSettingsGroupBox.Name = "ValidationSettingsGroupBox";
            this.ValidationSettingsGroupBox.Size = new System.Drawing.Size(418, 85);
            this.ValidationSettingsGroupBox.TabIndex = 3;
            this.ValidationSettingsGroupBox.TabStop = false;
            this.ValidationSettingsGroupBox.Text = "Validierungseinstellungen";
            // 
            // GcdValidationCheckBox
            // 
            this.GcdValidationCheckBox.AutoSize = true;
            this.GcdValidationCheckBox.Location = new System.Drawing.Point(6, 42);
            this.GcdValidationCheckBox.Name = "GcdValidationCheckBox";
            this.GcdValidationCheckBox.Size = new System.Drawing.Size(363, 21);
            this.GcdValidationCheckBox.TabIndex = 1;
            this.GcdValidationCheckBox.Text = "Validierung der Daten anhand der GCD-Stammdaten";
            this.GcdValidationCheckBox.UseVisualStyleBackColor = true;
            // 
            // IfpValidationCheckBox
            // 
            this.IfpValidationCheckBox.AutoSize = true;
            this.IfpValidationCheckBox.Location = new System.Drawing.Point(6, 19);
            this.IfpValidationCheckBox.Name = "IfpValidationCheckBox";
            this.IfpValidationCheckBox.Size = new System.Drawing.Size(126, 21);
            this.IfpValidationCheckBox.TabIndex = 0;
            this.IfpValidationCheckBox.Text = "IFP-Validierung";
            this.IfpValidationCheckBox.UseVisualStyleBackColor = true;
            // 
            // RoutingTableFilePathLabel
            // 
            this.RoutingTableFilePathLabel.AutoSize = true;
            this.RoutingTableFilePathLabel.Enabled = false;
            this.RoutingTableFilePathLabel.Location = new System.Drawing.Point(30, 8);
            this.RoutingTableFilePathLabel.Name = "RoutingTableFilePathLabel";
            this.RoutingTableFilePathLabel.Size = new System.Drawing.Size(166, 17);
            this.RoutingTableFilePathLabel.TabIndex = 0;
            this.RoutingTableFilePathLabel.Text = "Pfad zur Routing-Tabelle";
            // 
            // RoutingTableFilePathTextBox
            // 
            this.RoutingTableFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoutingTableFilePathTextBox.Enabled = false;
            this.RoutingTableFilePathTextBox.Location = new System.Drawing.Point(202, 8);
            this.RoutingTableFilePathTextBox.Name = "RoutingTableFilePathTextBox";
            this.RoutingTableFilePathTextBox.Size = new System.Drawing.Size(233, 22);
            this.RoutingTableFilePathTextBox.TabIndex = 1;
            // 
            // SearchRoutingTableFilePathButton
            // 
            this.SearchRoutingTableFilePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchRoutingTableFilePathButton.Enabled = false;
            this.SearchRoutingTableFilePathButton.Location = new System.Drawing.Point(441, 5);
            this.SearchRoutingTableFilePathButton.Name = "SearchRoutingTableFilePathButton";
            this.SearchRoutingTableFilePathButton.Size = new System.Drawing.Size(75, 23);
            this.SearchRoutingTableFilePathButton.TabIndex = 2;
            this.SearchRoutingTableFilePathButton.Text = "Suchen";
            this.SearchRoutingTableFilePathButton.UseVisualStyleBackColor = true;
            this.SearchRoutingTableFilePathButton.Click += new System.EventHandler(this.SearchRoutingTableFilePathButton_Click);
            // 
            // CustomRoutingTableFilePathCheckbox
            // 
            this.CustomRoutingTableFilePathCheckbox.AutoSize = true;
            this.CustomRoutingTableFilePathCheckbox.Location = new System.Drawing.Point(12, 9);
            this.CustomRoutingTableFilePathCheckbox.Name = "CustomRoutingTableFilePathCheckbox";
            this.CustomRoutingTableFilePathCheckbox.Size = new System.Drawing.Size(18, 17);
            this.CustomRoutingTableFilePathCheckbox.TabIndex = 5;
            this.CustomRoutingTableFilePathCheckbox.UseVisualStyleBackColor = true;
            this.CustomRoutingTableFilePathCheckbox.CheckedChanged += new System.EventHandler(this.CustomRoutingTableFilePathCheckbox_CheckedChanged);
            // 
            // SftpCredentialsGroupBox
            // 
            this.SftpCredentialsGroupBox.Controls.Add(this.PasswordLabel);
            this.SftpCredentialsGroupBox.Controls.Add(this.UsernameLabel);
            this.SftpCredentialsGroupBox.Controls.Add(this.PasswordTextBox);
            this.SftpCredentialsGroupBox.Controls.Add(this.UserNameTextBox);
            this.SftpCredentialsGroupBox.Location = new System.Drawing.Point(4, 42);
            this.SftpCredentialsGroupBox.Name = "SftpCredentialsGroupBox";
            this.SftpCredentialsGroupBox.Size = new System.Drawing.Size(423, 104);
            this.SftpCredentialsGroupBox.TabIndex = 6;
            this.SftpCredentialsGroupBox.TabStop = false;
            this.SftpCredentialsGroupBox.Text = "Auto-Download Routing-Tabelle Schufa SFTP Zugangsdaten";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 56);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(65, 17);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Passwort";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(6, 31);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(100, 17);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Benutzername";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(151, 56);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(132, 22);
            this.PasswordTextBox.TabIndex = 0;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(151, 31);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // CertificateSettingsUc
            // 
            this.CertificateSettingsUc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificateSettingsUc.Location = new System.Drawing.Point(4, 244);
            this.CertificateSettingsUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CertificateSettingsUc.Name = "CertificateSettingsUc";
            this.CertificateSettingsUc.Settings = null;
            this.CertificateSettingsUc.Size = new System.Drawing.Size(512, 166);
            this.CertificateSettingsUc.TabIndex = 4;
            // 
            // IfpSettingsUc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.SftpCredentialsGroupBox);
            this.Controls.Add(this.CustomRoutingTableFilePathCheckbox);
            this.Controls.Add(this.SearchRoutingTableFilePathButton);
            this.Controls.Add(this.RoutingTableFilePathLabel);
            this.Controls.Add(this.RoutingTableFilePathTextBox);
            this.Controls.Add(this.CertificateSettingsUc);
            this.Controls.Add(this.ValidationSettingsGroupBox);
            this.Name = "IfpSettingsUc";
            this.Size = new System.Drawing.Size(524, 414);
            this.ValidationSettingsGroupBox.ResumeLayout(false);
            this.ValidationSettingsGroupBox.PerformLayout();
            this.SftpCredentialsGroupBox.ResumeLayout(false);
            this.SftpCredentialsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ValidationSettingsGroupBox;
        private System.Windows.Forms.CheckBox GcdValidationCheckBox;
        private System.Windows.Forms.CheckBox IfpValidationCheckBox;
        private CertificateSettingsUc CertificateSettingsUc;
        private System.Windows.Forms.Label RoutingTableFilePathLabel;
        private System.Windows.Forms.TextBox RoutingTableFilePathTextBox;
        private System.Windows.Forms.Button SearchRoutingTableFilePathButton;
        private System.Windows.Forms.CheckBox CustomRoutingTableFilePathCheckbox;
        private System.Windows.Forms.GroupBox SftpCredentialsGroupBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
    }
}
