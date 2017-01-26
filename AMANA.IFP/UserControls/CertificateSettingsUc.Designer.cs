namespace AMANA.IFP.UserControls
{
    partial class CertificateSettingsUc
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
            this.SertificateSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.StoreLocationLabel = new System.Windows.Forms.Label();
            this.StoreNameLabel = new System.Windows.Forms.Label();
            this.FindValueLabel = new System.Windows.Forms.Label();
            this.X509FindTypeLabel = new System.Windows.Forms.Label();
            this.StoreLocationComboBox = new System.Windows.Forms.ComboBox();
            this.StoreNameComboBox = new System.Windows.Forms.ComboBox();
            this.X509FindTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FindValueTextBox = new System.Windows.Forms.TextBox();
            this.SertificateSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SertificateSettingsGroupBox
            // 
            this.SertificateSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SertificateSettingsGroupBox.Controls.Add(this.FindValueTextBox);
            this.SertificateSettingsGroupBox.Controls.Add(this.X509FindTypeComboBox);
            this.SertificateSettingsGroupBox.Controls.Add(this.StoreNameComboBox);
            this.SertificateSettingsGroupBox.Controls.Add(this.StoreLocationComboBox);
            this.SertificateSettingsGroupBox.Controls.Add(this.X509FindTypeLabel);
            this.SertificateSettingsGroupBox.Controls.Add(this.FindValueLabel);
            this.SertificateSettingsGroupBox.Controls.Add(this.StoreNameLabel);
            this.SertificateSettingsGroupBox.Controls.Add(this.StoreLocationLabel);
            this.SertificateSettingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SertificateSettingsGroupBox.Name = "SertificateSettingsGroupBox";
            this.SertificateSettingsGroupBox.Size = new System.Drawing.Size(297, 147);
            this.SertificateSettingsGroupBox.TabIndex = 0;
            this.SertificateSettingsGroupBox.TabStop = false;
            this.SertificateSettingsGroupBox.Text = "Zertifikatseinstellungen";
            // 
            // StoreLocationLabel
            // 
            this.StoreLocationLabel.AutoSize = true;
            this.StoreLocationLabel.Location = new System.Drawing.Point(11, 22);
            this.StoreLocationLabel.Name = "StoreLocationLabel";
            this.StoreLocationLabel.Size = new System.Drawing.Size(61, 13);
            this.StoreLocationLabel.TabIndex = 0;
            this.StoreLocationLabel.Text = "Speicherort";
            // 
            // StoreNameLabel
            // 
            this.StoreNameLabel.AutoSize = true;
            this.StoreNameLabel.Location = new System.Drawing.Point(11, 49);
            this.StoreNameLabel.Name = "StoreNameLabel";
            this.StoreNameLabel.Size = new System.Drawing.Size(149, 13);
            this.StoreNameLabel.TabIndex = 2;
            this.StoreNameLabel.Text = "Name des Zertifikatsspeichers";
            // 
            // FindValueLabel
            // 
            this.FindValueLabel.AutoSize = true;
            this.FindValueLabel.Location = new System.Drawing.Point(11, 103);
            this.FindValueLabel.Name = "FindValueLabel";
            this.FindValueLabel.Size = new System.Drawing.Size(52, 13);
            this.FindValueLabel.TabIndex = 6;
            this.FindValueLabel.Text = "Suchwert";
            // 
            // X509FindTypeLabel
            // 
            this.X509FindTypeLabel.AutoSize = true;
            this.X509FindTypeLabel.Location = new System.Drawing.Point(11, 76);
            this.X509FindTypeLabel.Name = "X509FindTypeLabel";
            this.X509FindTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.X509FindTypeLabel.TabIndex = 4;
            this.X509FindTypeLabel.Text = "Suchkriterium";
            // 
            // StoreLocationComboBox
            // 
            this.StoreLocationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreLocationComboBox.FormattingEnabled = true;
            this.StoreLocationComboBox.Location = new System.Drawing.Point(170, 19);
            this.StoreLocationComboBox.Name = "StoreLocationComboBox";
            this.StoreLocationComboBox.Size = new System.Drawing.Size(121, 21);
            this.StoreLocationComboBox.TabIndex = 1;
            // 
            // StoreNameComboBox
            // 
            this.StoreNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreNameComboBox.FormattingEnabled = true;
            this.StoreNameComboBox.Location = new System.Drawing.Point(170, 46);
            this.StoreNameComboBox.Name = "StoreNameComboBox";
            this.StoreNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.StoreNameComboBox.TabIndex = 3;
            // 
            // X509FindTypeComboBox
            // 
            this.X509FindTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.X509FindTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.X509FindTypeComboBox.FormattingEnabled = true;
            this.X509FindTypeComboBox.Location = new System.Drawing.Point(170, 73);
            this.X509FindTypeComboBox.Name = "X509FindTypeComboBox";
            this.X509FindTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.X509FindTypeComboBox.TabIndex = 5;
            // 
            // FindValueTextBox
            // 
            this.FindValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindValueTextBox.Location = new System.Drawing.Point(170, 100);
            this.FindValueTextBox.Name = "FindValueTextBox";
            this.FindValueTextBox.Size = new System.Drawing.Size(121, 20);
            this.FindValueTextBox.TabIndex = 7;
            // 
            // CertificateSettingsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SertificateSettingsGroupBox);
            this.Name = "CertificateSettingsUc";
            this.Size = new System.Drawing.Size(300, 150);
            this.SertificateSettingsGroupBox.ResumeLayout(false);
            this.SertificateSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SertificateSettingsGroupBox;
        private System.Windows.Forms.TextBox FindValueTextBox;
        private System.Windows.Forms.ComboBox X509FindTypeComboBox;
        private System.Windows.Forms.ComboBox StoreNameComboBox;
        private System.Windows.Forms.ComboBox StoreLocationComboBox;
        private System.Windows.Forms.Label X509FindTypeLabel;
        private System.Windows.Forms.Label FindValueLabel;
        private System.Windows.Forms.Label StoreNameLabel;
        private System.Windows.Forms.Label StoreLocationLabel;
    }
}
