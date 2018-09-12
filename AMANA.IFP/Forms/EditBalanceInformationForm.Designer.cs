namespace AMANA.IFP.Forms
{
    partial class EditBalanceInformationForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BalanceSheetInformationUc = new AMANA.IFP.UserControls.BalanceInformationUc();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAdd.Location = new System.Drawing.Point(247, 472);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "OK";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BalanceSheetInformationUc
            // 
            this.BalanceSheetInformationUc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceSheetInformationUc.BalanceInformation = null;
            this.BalanceSheetInformationUc.Location = new System.Drawing.Point(12, 12);
            this.BalanceSheetInformationUc.Name = "BalanceSheetInformationUc";
            this.BalanceSheetInformationUc.Size = new System.Drawing.Size(310, 454);
            this.BalanceSheetInformationUc.TabIndex = 0;
            // 
            // EditBalanceInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 501);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BalanceSheetInformationUc);
            this.MaximumSize = new System.Drawing.Size(350, 540);
            this.Name = "EditBalanceInformationForm";
            this.Text = "Bilanz";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.BalanceInformationUc BalanceSheetInformationUc;
        private System.Windows.Forms.Button BtnAdd;
    }
}