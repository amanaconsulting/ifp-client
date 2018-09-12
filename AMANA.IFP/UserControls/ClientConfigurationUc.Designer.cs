namespace AMANA.IFP.UserControls
{
    partial class ClientConfigurationUc
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
            this.HeaderIdentityUc = new AMANA.IFP.UserControls.HeaderIdentityUc();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeaderIdentityUc
            // 
            this.HeaderIdentityUc.HeaderIdentity = null;
            this.HeaderIdentityUc.Location = new System.Drawing.Point(3, 3);
            this.HeaderIdentityUc.Name = "HeaderIdentityUc";
            this.HeaderIdentityUc.Size = new System.Drawing.Size(636, 157);
            this.HeaderIdentityUc.TabIndex = 0;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(3, 169);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(42, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version";
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Location = new System.Drawing.Point(186, 166);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.Size = new System.Drawing.Size(453, 20);
            this.VersionTextBox.TabIndex = 2;
            // 
            // ClientConfigurationUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.VersionTextBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.HeaderIdentityUc);
            this.Name = "ClientConfigurationUc";
            this.Size = new System.Drawing.Size(642, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HeaderIdentityUc HeaderIdentityUc;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.TextBox VersionTextBox;
    }
}
