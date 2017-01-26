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
            this.CertificateSettingsUc = new AMANA.IFP.UserControls.CertificateSettingsUc();
            this.ValidationSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValidationSettingsGroupBox
            // 
            this.ValidationSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidationSettingsGroupBox.Controls.Add(this.GcdValidationCheckBox);
            this.ValidationSettingsGroupBox.Controls.Add(this.IfpValidationCheckBox);
            this.ValidationSettingsGroupBox.Location = new System.Drawing.Point(3, 31);
            this.ValidationSettingsGroupBox.Name = "ValidationSettingsGroupBox";
            this.ValidationSettingsGroupBox.Size = new System.Drawing.Size(294, 63);
            this.ValidationSettingsGroupBox.TabIndex = 3;
            this.ValidationSettingsGroupBox.TabStop = false;
            this.ValidationSettingsGroupBox.Text = "Validierungseinstellungen";
            // 
            // GcdValidationCheckBox
            // 
            this.GcdValidationCheckBox.AutoSize = true;
            this.GcdValidationCheckBox.Location = new System.Drawing.Point(6, 42);
            this.GcdValidationCheckBox.Name = "GcdValidationCheckBox";
            this.GcdValidationCheckBox.Size = new System.Drawing.Size(273, 17);
            this.GcdValidationCheckBox.TabIndex = 1;
            this.GcdValidationCheckBox.Text = "Validierung der Daten anhand der GCD-Stammdaten";
            this.GcdValidationCheckBox.UseVisualStyleBackColor = true;
            // 
            // IfpValidationCheckBox
            // 
            this.IfpValidationCheckBox.AutoSize = true;
            this.IfpValidationCheckBox.Location = new System.Drawing.Point(6, 19);
            this.IfpValidationCheckBox.Name = "IfpValidationCheckBox";
            this.IfpValidationCheckBox.Size = new System.Drawing.Size(97, 17);
            this.IfpValidationCheckBox.TabIndex = 0;
            this.IfpValidationCheckBox.Text = "IFP-Validierung";
            this.IfpValidationCheckBox.UseVisualStyleBackColor = true;
            // 
            // RoutingTableFilePathLabel
            // 
            this.RoutingTableFilePathLabel.AutoSize = true;
            this.RoutingTableFilePathLabel.Location = new System.Drawing.Point(6, 8);
            this.RoutingTableFilePathLabel.Name = "RoutingTableFilePathLabel";
            this.RoutingTableFilePathLabel.Size = new System.Drawing.Size(124, 13);
            this.RoutingTableFilePathLabel.TabIndex = 0;
            this.RoutingTableFilePathLabel.Text = "Pfad zur Routing-Tabelle";
            // 
            // RoutingTableFilePathTextBox
            // 
            this.RoutingTableFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoutingTableFilePathTextBox.Location = new System.Drawing.Point(171, 5);
            this.RoutingTableFilePathTextBox.Name = "RoutingTableFilePathTextBox";
            this.RoutingTableFilePathTextBox.Size = new System.Drawing.Size(45, 20);
            this.RoutingTableFilePathTextBox.TabIndex = 1;
            // 
            // SearchRoutingTableFilePathButton
            // 
            this.SearchRoutingTableFilePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchRoutingTableFilePathButton.Location = new System.Drawing.Point(222, 3);
            this.SearchRoutingTableFilePathButton.Name = "SearchRoutingTableFilePathButton";
            this.SearchRoutingTableFilePathButton.Size = new System.Drawing.Size(75, 23);
            this.SearchRoutingTableFilePathButton.TabIndex = 2;
            this.SearchRoutingTableFilePathButton.Text = "Suchen";
            this.SearchRoutingTableFilePathButton.UseVisualStyleBackColor = true;
            this.SearchRoutingTableFilePathButton.Click += new System.EventHandler(this.SearchRoutingTableFilePathButton_Click);
            // 
            // CertificateSettingsUc
            // 
            this.CertificateSettingsUc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificateSettingsUc.Location = new System.Drawing.Point(3, 100);
            this.CertificateSettingsUc.Name = "CertificateSettingsUc";
            this.CertificateSettingsUc.Settings = null;
            this.CertificateSettingsUc.Size = new System.Drawing.Size(294, 147);
            this.CertificateSettingsUc.TabIndex = 4;
            // 
            // IfpSettingsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchRoutingTableFilePathButton);
            this.Controls.Add(this.RoutingTableFilePathLabel);
            this.Controls.Add(this.RoutingTableFilePathTextBox);
            this.Controls.Add(this.CertificateSettingsUc);
            this.Controls.Add(this.ValidationSettingsGroupBox);
            this.Name = "IfpSettingsUc";
            this.Size = new System.Drawing.Size(300, 250);
            this.ValidationSettingsGroupBox.ResumeLayout(false);
            this.ValidationSettingsGroupBox.PerformLayout();
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
    }
}
