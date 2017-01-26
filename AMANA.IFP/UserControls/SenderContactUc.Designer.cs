namespace AMANA.IFP.UserControls
{
    partial class ContactUc
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
            this.ContactPersonUc = new AMANA.IFP.UserControls.ContactPersonUc();
            this.ContactDataTlp = new System.Windows.Forms.TableLayoutPanel();
            this.ContactPhoneNumberPnl = new System.Windows.Forms.Panel();
            this.ContactPhoneNumberLabel = new System.Windows.Forms.Label();
            this.ContactPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.ContactEmailPnl = new System.Windows.Forms.Panel();
            this.ContactEmailLabel = new System.Windows.Forms.Label();
            this.ContactEmailTextBox = new System.Windows.Forms.TextBox();
            this.ContactGrp.SuspendLayout();
            this.ContactDataTlp.SuspendLayout();
            this.ContactPhoneNumberPnl.SuspendLayout();
            this.ContactEmailPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactGrp
            // 
            this.ContactGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactGrp.Controls.Add(this.ContactPersonUc);
            this.ContactGrp.Controls.Add(this.ContactDataTlp);
            this.ContactGrp.Location = new System.Drawing.Point(3, 3);
            this.ContactGrp.Name = "ContactGrp";
            this.ContactGrp.Size = new System.Drawing.Size(629, 152);
            this.ContactGrp.TabIndex = 0;
            this.ContactGrp.TabStop = false;
            this.ContactGrp.Text = "Kontaktdaten*";
            // 
            // ContactPersonUc
            // 
            this.ContactPersonUc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPersonUc.ContactPerson = null;
            this.ContactPersonUc.Location = new System.Drawing.Point(6, 19);
            this.ContactPersonUc.Name = "ContactPersonUc";
            this.ContactPersonUc.Size = new System.Drawing.Size(617, 96);
            this.ContactPersonUc.TabIndex = 0;
            // 
            // ContactDataTlp
            // 
            this.ContactDataTlp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDataTlp.ColumnCount = 2;
            this.ContactDataTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactDataTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContactDataTlp.Controls.Add(this.ContactPhoneNumberPnl, 0, 0);
            this.ContactDataTlp.Controls.Add(this.ContactEmailPnl, 1, 0);
            this.ContactDataTlp.Location = new System.Drawing.Point(3, 112);
            this.ContactDataTlp.Name = "ContactDataTlp";
            this.ContactDataTlp.RowCount = 1;
            this.ContactDataTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ContactDataTlp.Size = new System.Drawing.Size(620, 34);
            this.ContactDataTlp.TabIndex = 1;
            // 
            // ContactPhoneNumberPnl
            // 
            this.ContactPhoneNumberPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPhoneNumberPnl.Controls.Add(this.ContactPhoneNumberLabel);
            this.ContactPhoneNumberPnl.Controls.Add(this.ContactPhoneNumberTextBox);
            this.ContactPhoneNumberPnl.Location = new System.Drawing.Point(3, 3);
            this.ContactPhoneNumberPnl.Name = "ContactPhoneNumberPnl";
            this.ContactPhoneNumberPnl.Size = new System.Drawing.Size(304, 28);
            this.ContactPhoneNumberPnl.TabIndex = 0;
            // 
            // ContactPhoneNumberLabel
            // 
            this.ContactPhoneNumberLabel.AutoSize = true;
            this.ContactPhoneNumberLabel.Location = new System.Drawing.Point(3, 6);
            this.ContactPhoneNumberLabel.Name = "ContactPhoneNumberLabel";
            this.ContactPhoneNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.ContactPhoneNumberLabel.TabIndex = 0;
            this.ContactPhoneNumberLabel.Text = "Telefon*";
            // 
            // ContactPhoneNumberTextBox
            // 
            this.ContactPhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPhoneNumberTextBox.Location = new System.Drawing.Point(176, 3);
            this.ContactPhoneNumberTextBox.Name = "ContactPhoneNumberTextBox";
            this.ContactPhoneNumberTextBox.Size = new System.Drawing.Size(125, 20);
            this.ContactPhoneNumberTextBox.TabIndex = 1;
            // 
            // ContactEmailPnl
            // 
            this.ContactEmailPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactEmailPnl.Controls.Add(this.ContactEmailLabel);
            this.ContactEmailPnl.Controls.Add(this.ContactEmailTextBox);
            this.ContactEmailPnl.Location = new System.Drawing.Point(313, 3);
            this.ContactEmailPnl.Name = "ContactEmailPnl";
            this.ContactEmailPnl.Size = new System.Drawing.Size(304, 28);
            this.ContactEmailPnl.TabIndex = 1;
            // 
            // ContactEmailLabel
            // 
            this.ContactEmailLabel.AutoSize = true;
            this.ContactEmailLabel.Location = new System.Drawing.Point(7, 6);
            this.ContactEmailLabel.Name = "ContactEmailLabel";
            this.ContactEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.ContactEmailLabel.TabIndex = 0;
            this.ContactEmailLabel.Text = "Email";
            // 
            // ContactEmailTextBox
            // 
            this.ContactEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactEmailTextBox.Location = new System.Drawing.Point(176, 3);
            this.ContactEmailTextBox.Name = "ContactEmailTextBox";
            this.ContactEmailTextBox.Size = new System.Drawing.Size(125, 20);
            this.ContactEmailTextBox.TabIndex = 1;
            // 
            // ContactUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContactGrp);
            this.Name = "ContactUc";
            this.Size = new System.Drawing.Size(635, 158);
            this.ContactGrp.ResumeLayout(false);
            this.ContactDataTlp.ResumeLayout(false);
            this.ContactPhoneNumberPnl.ResumeLayout(false);
            this.ContactPhoneNumberPnl.PerformLayout();
            this.ContactEmailPnl.ResumeLayout(false);
            this.ContactEmailPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ContactGrp;
        private System.Windows.Forms.TableLayoutPanel ContactDataTlp;
        private System.Windows.Forms.Panel ContactEmailPnl;
        private System.Windows.Forms.Label ContactEmailLabel;
        private System.Windows.Forms.TextBox ContactPhoneNumberTextBox;
        private System.Windows.Forms.Panel ContactPhoneNumberPnl;
        private System.Windows.Forms.Label ContactPhoneNumberLabel;
        private System.Windows.Forms.TextBox ContactEmailTextBox;
        private ContactPersonUc ContactPersonUc;
    }
}
