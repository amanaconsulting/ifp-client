namespace AMANA.IFP.Forms
{
    partial class EditCustomerIdentityForm
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblIdentityType = new System.Windows.Forms.Label();
            this.LblValue = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.TextBoxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(197, 66);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblIdentityType
            // 
            this.LblIdentityType.AutoSize = true;
            this.LblIdentityType.Location = new System.Drawing.Point(12, 13);
            this.LblIdentityType.Name = "LblIdentityType";
            this.LblIdentityType.Size = new System.Drawing.Size(24, 13);
            this.LblIdentityType.TabIndex = 0;
            this.LblIdentityType.Text = "Art*";
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Location = new System.Drawing.Point(13, 40);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(34, 13);
            this.LblValue.TabIndex = 2;
            this.LblValue.Text = "Wert*";
            // 
            // CmbType
            // 
            this.CmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(147, 10);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(125, 21);
            this.CmbType.TabIndex = 1;
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxValue.Location = new System.Drawing.Point(147, 37);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Size = new System.Drawing.Size(125, 20);
            this.TextBoxValue.TabIndex = 3;
            // 
            // EditCustomerIdentityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.TextBoxValue);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.LblValue);
            this.Controls.Add(this.LblIdentityType);
            this.Controls.Add(this.BtnOk);
            this.MinimumSize = new System.Drawing.Size(300, 140);
            this.Name = "EditCustomerIdentityForm";
            this.Text = "Identität";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblIdentityType;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.TextBox TextBoxValue;
    }
}