namespace AMANA.IFP.UserControls
{
    partial class HeaderIdentityUc
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
            this.HeaderIdentityGroupBox = new System.Windows.Forms.GroupBox();
            this.InstituteIdLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.InstituteIdTextBox = new System.Windows.Forms.TextBox();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.ProviderTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.IdTypeLabel = new System.Windows.Forms.Label();
            this.InstituteIdTypeComboBox = new System.Windows.Forms.ComboBox();
            this.HeaderIdentityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderIdentityGroupBox
            // 
            this.HeaderIdentityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderIdentityGroupBox.Controls.Add(this.InstituteIdTypeComboBox);
            this.HeaderIdentityGroupBox.Controls.Add(this.IdTypeLabel);
            this.HeaderIdentityGroupBox.Controls.Add(this.InstituteIdLabel);
            this.HeaderIdentityGroupBox.Controls.Add(this.ClientLabel);
            this.HeaderIdentityGroupBox.Controls.Add(this.ProviderLabel);
            this.HeaderIdentityGroupBox.Controls.Add(this.InstituteIdTextBox);
            this.HeaderIdentityGroupBox.Controls.Add(this.ClientTextBox);
            this.HeaderIdentityGroupBox.Controls.Add(this.ProviderTextBox);
            this.HeaderIdentityGroupBox.Controls.Add(this.UserIdTextBox);
            this.HeaderIdentityGroupBox.Controls.Add(this.UserIdLabel);
            this.HeaderIdentityGroupBox.Location = new System.Drawing.Point(4, 4);
            this.HeaderIdentityGroupBox.Name = "HeaderIdentityGroupBox";
            this.HeaderIdentityGroupBox.Size = new System.Drawing.Size(629, 151);
            this.HeaderIdentityGroupBox.TabIndex = 0;
            this.HeaderIdentityGroupBox.TabStop = false;
            this.HeaderIdentityGroupBox.Text = "Header-Identitätsinformationen*";
            // 
            // InstituteIdLabel
            // 
            this.InstituteIdLabel.AutoSize = true;
            this.InstituteIdLabel.Location = new System.Drawing.Point(6, 100);
            this.InstituteIdLabel.Name = "InstituteIdLabel";
            this.InstituteIdLabel.Size = new System.Drawing.Size(57, 13);
            this.InstituteIdLabel.TabIndex = 6;
            this.InstituteIdLabel.Text = "Instituts-ID";
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(6, 74);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(33, 13);
            this.ClientLabel.TabIndex = 4;
            this.ClientLabel.Text = "Klient";
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.AutoSize = true;
            this.ProviderLabel.Location = new System.Drawing.Point(6, 48);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(89, 13);
            this.ProviderLabel.TabIndex = 2;
            this.ProviderLabel.Text = "Provider (IFP-ID)*";
            // 
            // InstituteIdTextBox
            // 
            this.InstituteIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstituteIdTextBox.Location = new System.Drawing.Point(179, 97);
            this.InstituteIdTextBox.Name = "InstituteIdTextBox";
            this.InstituteIdTextBox.Size = new System.Drawing.Size(444, 20);
            this.InstituteIdTextBox.TabIndex = 7;
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientTextBox.Location = new System.Drawing.Point(179, 71);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(444, 20);
            this.ClientTextBox.TabIndex = 5;
            // 
            // ProviderTextBox
            // 
            this.ProviderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderTextBox.Location = new System.Drawing.Point(179, 45);
            this.ProviderTextBox.Name = "ProviderTextBox";
            this.ProviderTextBox.Size = new System.Drawing.Size(444, 20);
            this.ProviderTextBox.TabIndex = 3;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserIdTextBox.Location = new System.Drawing.Point(179, 19);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(444, 20);
            this.UserIdTextBox.TabIndex = 1;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(6, 22);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(148, 13);
            this.UserIdLabel.TabIndex = 0;
            this.UserIdLabel.Text = "User-ID (beim Servicenehmer)";
            // 
            // IdTypeLabel
            // 
            this.IdTypeLabel.AutoSize = true;
            this.IdTypeLabel.Location = new System.Drawing.Point(6, 126);
            this.IdTypeLabel.Name = "IdTypeLabel";
            this.IdTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.IdTypeLabel.TabIndex = 1;
            this.IdTypeLabel.Text = "Instituts-ID-Typ";
            // 
            // InstituteIdTypeComboBox
            // 
            this.InstituteIdTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstituteIdTypeComboBox.FormattingEnabled = true;
            this.InstituteIdTypeComboBox.Location = new System.Drawing.Point(179, 123);
            this.InstituteIdTypeComboBox.Name = "InstituteIdTypeComboBox";
            this.InstituteIdTypeComboBox.Size = new System.Drawing.Size(444, 21);
            this.InstituteIdTypeComboBox.TabIndex = 8;
            // 
            // HeaderIdentityUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeaderIdentityGroupBox);
            this.Name = "HeaderIdentityUc";
            this.Size = new System.Drawing.Size(636, 157);
            this.HeaderIdentityGroupBox.ResumeLayout(false);
            this.HeaderIdentityGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HeaderIdentityGroupBox;
        private System.Windows.Forms.TextBox InstituteIdTextBox;
        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.TextBox ProviderTextBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label InstituteIdLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label ProviderLabel;
        private System.Windows.Forms.Label IdTypeLabel;
        private System.Windows.Forms.ComboBox InstituteIdTypeComboBox;
    }
}
