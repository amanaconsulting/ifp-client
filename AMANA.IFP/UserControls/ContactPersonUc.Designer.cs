namespace AMANA.IFP.UserControls
{
    partial class ContactPersonUc
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
            this.ContactGrp = new System.Windows.Forms.GroupBox();
            this.ContactDataTlp = new System.Windows.Forms.TableLayoutPanel();
            this.ContactLastNamePnl = new System.Windows.Forms.Panel();
            this.ContactLastNameLabel = new System.Windows.Forms.Label();
            this.ContactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactNameAdditionPnl = new System.Windows.Forms.Panel();
            this.ContactNameAdditionLabel = new System.Windows.Forms.Label();
            this.ContactNameAdditionTextBox = new System.Windows.Forms.TextBox();
            this.ContactFirstNamePnl = new System.Windows.Forms.Panel();
            this.ContactFirstNameLabel = new System.Windows.Forms.Label();
            this.ContactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactNameAddressPnl = new System.Windows.Forms.Panel();
            this.ContactNameAddressLabel = new System.Windows.Forms.Label();
            this.ContactPersonNameAddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactGrp.SuspendLayout();
            this.ContactDataTlp.SuspendLayout();
            this.ContactLastNamePnl.SuspendLayout();
            this.ContactNameAdditionPnl.SuspendLayout();
            this.ContactFirstNamePnl.SuspendLayout();
            this.ContactNameAddressPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactGrp
            // 
            this.ContactGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactGrp.Controls.Add(this.ContactDataTlp);
            this.ContactGrp.Location = new System.Drawing.Point(3, 3);
            this.ContactGrp.Name = "ContactGrp";
            this.ContactGrp.Size = new System.Drawing.Size(629, 89);
            this.ContactGrp.TabIndex = 0;
            this.ContactGrp.TabStop = false;
            this.ContactGrp.Text = "Ansprechpartner*";
            // 
            // ContactDataTlp
            // 
            this.ContactDataTlp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDataTlp.ColumnCount = 2;
            this.ContactDataTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactDataTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactDataTlp.Controls.Add(this.ContactLastNamePnl, 1, 1);
            this.ContactDataTlp.Controls.Add(this.ContactNameAdditionPnl, 1, 0);
            this.ContactDataTlp.Controls.Add(this.ContactFirstNamePnl, 0, 1);
            this.ContactDataTlp.Controls.Add(this.ContactNameAddressPnl, 0, 0);
            this.ContactDataTlp.Location = new System.Drawing.Point(3, 20);
            this.ContactDataTlp.Name = "ContactDataTlp";
            this.ContactDataTlp.RowCount = 2;
            this.ContactDataTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ContactDataTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ContactDataTlp.Size = new System.Drawing.Size(620, 64);
            this.ContactDataTlp.TabIndex = 0;
            // 
            // ContactLastNamePnl
            // 
            this.ContactLastNamePnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactLastNamePnl.Controls.Add(this.ContactLastNameLabel);
            this.ContactLastNamePnl.Controls.Add(this.ContactLastNameTextBox);
            this.ContactLastNamePnl.Location = new System.Drawing.Point(313, 35);
            this.ContactLastNamePnl.Name = "ContactLastNamePnl";
            this.ContactLastNamePnl.Size = new System.Drawing.Size(304, 26);
            this.ContactLastNamePnl.TabIndex = 3;
            // 
            // ContactLastNameLabel
            // 
            this.ContactLastNameLabel.AutoSize = true;
            this.ContactLastNameLabel.Location = new System.Drawing.Point(7, 7);
            this.ContactLastNameLabel.Name = "ContactLastNameLabel";
            this.ContactLastNameLabel.Size = new System.Drawing.Size(63, 13);
            this.ContactLastNameLabel.TabIndex = 0;
            this.ContactLastNameLabel.Text = "Nachname*";
            // 
            // ContactLastNameTextBox
            // 
            this.ContactLastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactLastNameTextBox.Location = new System.Drawing.Point(173, 3);
            this.ContactLastNameTextBox.Name = "ContactLastNameTextBox";
            this.ContactLastNameTextBox.Size = new System.Drawing.Size(125, 20);
            this.ContactLastNameTextBox.TabIndex = 1;
            // 
            // ContactNameAdditionPnl
            // 
            this.ContactNameAdditionPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactNameAdditionPnl.Controls.Add(this.ContactNameAdditionLabel);
            this.ContactNameAdditionPnl.Controls.Add(this.ContactNameAdditionTextBox);
            this.ContactNameAdditionPnl.Location = new System.Drawing.Point(313, 3);
            this.ContactNameAdditionPnl.Name = "ContactNameAdditionPnl";
            this.ContactNameAdditionPnl.Size = new System.Drawing.Size(304, 26);
            this.ContactNameAdditionPnl.TabIndex = 1;
            // 
            // ContactNameAdditionLabel
            // 
            this.ContactNameAdditionLabel.AutoSize = true;
            this.ContactNameAdditionLabel.Location = new System.Drawing.Point(8, 7);
            this.ContactNameAdditionLabel.Name = "ContactNameAdditionLabel";
            this.ContactNameAdditionLabel.Size = new System.Drawing.Size(101, 13);
            this.ContactNameAdditionLabel.TabIndex = 0;
            this.ContactNameAdditionLabel.Text = "Namenserweiterung";
            // 
            // ContactNameAdditionTextBox
            // 
            this.ContactNameAdditionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactNameAdditionTextBox.Location = new System.Drawing.Point(173, 3);
            this.ContactNameAdditionTextBox.Name = "ContactNameAdditionTextBox";
            this.ContactNameAdditionTextBox.Size = new System.Drawing.Size(125, 20);
            this.ContactNameAdditionTextBox.TabIndex = 1;
            // 
            // ContactFirstNamePnl
            // 
            this.ContactFirstNamePnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactFirstNamePnl.Controls.Add(this.ContactFirstNameLabel);
            this.ContactFirstNamePnl.Controls.Add(this.ContactFirstNameTextBox);
            this.ContactFirstNamePnl.Location = new System.Drawing.Point(3, 35);
            this.ContactFirstNamePnl.Name = "ContactFirstNamePnl";
            this.ContactFirstNamePnl.Size = new System.Drawing.Size(304, 26);
            this.ContactFirstNamePnl.TabIndex = 2;
            // 
            // ContactFirstNameLabel
            // 
            this.ContactFirstNameLabel.AutoSize = true;
            this.ContactFirstNameLabel.Location = new System.Drawing.Point(10, 7);
            this.ContactFirstNameLabel.Name = "ContactFirstNameLabel";
            this.ContactFirstNameLabel.Size = new System.Drawing.Size(53, 13);
            this.ContactFirstNameLabel.TabIndex = 0;
            this.ContactFirstNameLabel.Text = "Vorname*";
            // 
            // ContactFirstNameTextBox
            // 
            this.ContactFirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactFirstNameTextBox.Location = new System.Drawing.Point(173, 2);
            this.ContactFirstNameTextBox.Name = "ContactFirstNameTextBox";
            this.ContactFirstNameTextBox.Size = new System.Drawing.Size(125, 20);
            this.ContactFirstNameTextBox.TabIndex = 1;
            // 
            // ContactNameAddressPnl
            // 
            this.ContactNameAddressPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactNameAddressPnl.Controls.Add(this.ContactNameAddressLabel);
            this.ContactNameAddressPnl.Controls.Add(this.ContactPersonNameAddressTextBox);
            this.ContactNameAddressPnl.Location = new System.Drawing.Point(3, 3);
            this.ContactNameAddressPnl.Name = "ContactNameAddressPnl";
            this.ContactNameAddressPnl.Size = new System.Drawing.Size(304, 26);
            this.ContactNameAddressPnl.TabIndex = 0;
            // 
            // ContactNameAddressLabel
            // 
            this.ContactNameAddressLabel.AutoSize = true;
            this.ContactNameAddressLabel.Location = new System.Drawing.Point(10, 7);
            this.ContactNameAddressLabel.Name = "ContactNameAddressLabel";
            this.ContactNameAddressLabel.Size = new System.Drawing.Size(41, 13);
            this.ContactNameAddressLabel.TabIndex = 0;
            this.ContactNameAddressLabel.Text = "Anrede";
            // 
            // ContactPersonNameAddressTextBox
            // 
            this.ContactPersonNameAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPersonNameAddressTextBox.Location = new System.Drawing.Point(173, 3);
            this.ContactPersonNameAddressTextBox.Name = "ContactPersonNameAddressTextBox";
            this.ContactPersonNameAddressTextBox.Size = new System.Drawing.Size(125, 20);
            this.ContactPersonNameAddressTextBox.TabIndex = 1;
            // 
            // ContactPersonUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContactGrp);
            this.Name = "ContactPersonUc";
            this.Size = new System.Drawing.Size(638, 96);
            this.ContactGrp.ResumeLayout(false);
            this.ContactDataTlp.ResumeLayout(false);
            this.ContactLastNamePnl.ResumeLayout(false);
            this.ContactLastNamePnl.PerformLayout();
            this.ContactNameAdditionPnl.ResumeLayout(false);
            this.ContactNameAdditionPnl.PerformLayout();
            this.ContactFirstNamePnl.ResumeLayout(false);
            this.ContactFirstNamePnl.PerformLayout();
            this.ContactNameAddressPnl.ResumeLayout(false);
            this.ContactNameAddressPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ContactGrp;
        private System.Windows.Forms.TableLayoutPanel ContactDataTlp;
        private System.Windows.Forms.Panel ContactLastNamePnl;
        private System.Windows.Forms.Label ContactLastNameLabel;
        private System.Windows.Forms.TextBox ContactLastNameTextBox;
        private System.Windows.Forms.Panel ContactNameAdditionPnl;
        private System.Windows.Forms.Label ContactNameAdditionLabel;
        private System.Windows.Forms.TextBox ContactNameAdditionTextBox;
        private System.Windows.Forms.Panel ContactFirstNamePnl;
        private System.Windows.Forms.Label ContactFirstNameLabel;
        private System.Windows.Forms.TextBox ContactFirstNameTextBox;
        private System.Windows.Forms.Panel ContactNameAddressPnl;
        private System.Windows.Forms.Label ContactNameAddressLabel;
        private System.Windows.Forms.TextBox ContactPersonNameAddressTextBox;
    }
}
