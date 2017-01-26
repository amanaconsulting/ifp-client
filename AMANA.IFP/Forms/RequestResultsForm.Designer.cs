namespace AMANA.IFP.Forms
{
    partial class RequestResultsForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.RequestResultUc = new AMANA.IFP.UserControls.RequestResultUc();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(297, 226);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Schließen";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RequestResultUc
            // 
            this.RequestResultUc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestResultUc.Location = new System.Drawing.Point(0, 0);
            this.RequestResultUc.Name = "RequestResultUc";
            this.RequestResultUc.RequestResult = null;
            this.RequestResultUc.Size = new System.Drawing.Size(385, 220);
            this.RequestResultUc.TabIndex = 0;
            // 
            // RequestResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RequestResultUc);
            this.MinimumSize = new System.Drawing.Size(245, 200);
            this.Name = "RequestResultsForm";
            this.Text = "Meldungen";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.RequestResultUc RequestResultUc;
        private System.Windows.Forms.Button CloseButton;
    }
}