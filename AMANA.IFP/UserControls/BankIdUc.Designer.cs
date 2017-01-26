namespace AMANA.IFP.UserControls
{
    partial class BankIdUc
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
            this.BankIdGrp = new System.Windows.Forms.GroupBox();
            this.BankIdNameLabel = new System.Windows.Forms.Label();
            this.BankIdValueLabel = new System.Windows.Forms.Label();
            this.BankIdTypeLabel = new System.Windows.Forms.Label();
            this.BankIdNameTextBox = new System.Windows.Forms.TextBox();
            this.BankIdValueTextBox = new System.Windows.Forms.TextBox();
            this.BankIdTypeCmb = new System.Windows.Forms.ComboBox();
            this.BankIdGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // BankIdGrp
            // 
            this.BankIdGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankIdGrp.Controls.Add(this.BankIdNameLabel);
            this.BankIdGrp.Controls.Add(this.BankIdValueLabel);
            this.BankIdGrp.Controls.Add(this.BankIdTypeLabel);
            this.BankIdGrp.Controls.Add(this.BankIdNameTextBox);
            this.BankIdGrp.Controls.Add(this.BankIdValueTextBox);
            this.BankIdGrp.Controls.Add(this.BankIdTypeCmb);
            this.BankIdGrp.Location = new System.Drawing.Point(3, 3);
            this.BankIdGrp.Name = "BankIdGrp";
            this.BankIdGrp.Size = new System.Drawing.Size(299, 99);
            this.BankIdGrp.TabIndex = 0;
            this.BankIdGrp.TabStop = false;
            this.BankIdGrp.Text = "Bank ID*";
            // 
            // BankIdNameLabel
            // 
            this.BankIdNameLabel.AutoSize = true;
            this.BankIdNameLabel.Location = new System.Drawing.Point(6, 75);
            this.BankIdNameLabel.Name = "BankIdNameLabel";
            this.BankIdNameLabel.Size = new System.Drawing.Size(39, 13);
            this.BankIdNameLabel.TabIndex = 4;
            this.BankIdNameLabel.Text = "Name*";
            // 
            // BankIdValueLabel
            // 
            this.BankIdValueLabel.AutoSize = true;
            this.BankIdValueLabel.Location = new System.Drawing.Point(6, 49);
            this.BankIdValueLabel.Name = "BankIdValueLabel";
            this.BankIdValueLabel.Size = new System.Drawing.Size(34, 13);
            this.BankIdValueLabel.TabIndex = 2;
            this.BankIdValueLabel.Text = "Wert*";
            // 
            // BankIdTypeLabel
            // 
            this.BankIdTypeLabel.AutoSize = true;
            this.BankIdTypeLabel.Location = new System.Drawing.Point(6, 22);
            this.BankIdTypeLabel.Name = "BankIdTypeLabel";
            this.BankIdTypeLabel.Size = new System.Drawing.Size(24, 13);
            this.BankIdTypeLabel.TabIndex = 0;
            this.BankIdTypeLabel.Text = "Art*";
            // 
            // BankIdNameTextBox
            // 
            this.BankIdNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankIdNameTextBox.Location = new System.Drawing.Point(173, 72);
            this.BankIdNameTextBox.Name = "BankIdNameTextBox";
            this.BankIdNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.BankIdNameTextBox.TabIndex = 5;
            // 
            // BankIdValueTextBox
            // 
            this.BankIdValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankIdValueTextBox.Location = new System.Drawing.Point(173, 46);
            this.BankIdValueTextBox.Name = "BankIdValueTextBox";
            this.BankIdValueTextBox.Size = new System.Drawing.Size(121, 20);
            this.BankIdValueTextBox.TabIndex = 3;
            // 
            // BankIdTypeCmb
            // 
            this.BankIdTypeCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankIdTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BankIdTypeCmb.FormattingEnabled = true;
            this.BankIdTypeCmb.Location = new System.Drawing.Point(173, 19);
            this.BankIdTypeCmb.Name = "BankIdTypeCmb";
            this.BankIdTypeCmb.Size = new System.Drawing.Size(121, 21);
            this.BankIdTypeCmb.TabIndex = 1;
            // 
            // BankIdUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BankIdGrp);
            this.Name = "BankIdUc";
            this.Size = new System.Drawing.Size(305, 106);
            this.BankIdGrp.ResumeLayout(false);
            this.BankIdGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BankIdGrp;
        private System.Windows.Forms.Label BankIdNameLabel;
        private System.Windows.Forms.Label BankIdValueLabel;
        private System.Windows.Forms.Label BankIdTypeLabel;
        private System.Windows.Forms.TextBox BankIdNameTextBox;
        private System.Windows.Forms.TextBox BankIdValueTextBox;
        private System.Windows.Forms.ComboBox BankIdTypeCmb;
    }
}
