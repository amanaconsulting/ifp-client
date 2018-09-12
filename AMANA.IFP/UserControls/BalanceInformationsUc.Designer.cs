namespace AMANA.IFP.UserControls
{
    partial class BalanceInformationsUc
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
            this.BalancesGrp = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BalancesListView = new System.Windows.Forms.ListView();
            this.BtnAddBalanceIdentity = new System.Windows.Forms.Button();
            this.BalancesGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // BalancesGrp
            // 
            this.BalancesGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalancesGrp.Controls.Add(this.RemoveButton);
            this.BalancesGrp.Controls.Add(this.EditButton);
            this.BalancesGrp.Controls.Add(this.BalancesListView);
            this.BalancesGrp.Controls.Add(this.BtnAddBalanceIdentity);
            this.BalancesGrp.Location = new System.Drawing.Point(3, 3);
            this.BalancesGrp.Name = "BalancesGrp";
            this.BalancesGrp.Size = new System.Drawing.Size(632, 124);
            this.BalancesGrp.TabIndex = 0;
            this.BalancesGrp.TabStop = false;
            this.BalancesGrp.Text = "Abschlüsse*";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(551, 95);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Entfernen";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(470, 95);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Bearbeiten";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BalancesListView
            // 
            this.BalancesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalancesListView.Location = new System.Drawing.Point(6, 19);
            this.BalancesListView.Name = "BalancesListView";
            this.BalancesListView.Size = new System.Drawing.Size(620, 70);
            this.BalancesListView.TabIndex = 0;
            this.BalancesListView.UseCompatibleStateImageBehavior = false;
            this.BalancesListView.View = System.Windows.Forms.View.Details;
            // 
            // BtnAddBalanceIdentity
            // 
            this.BtnAddBalanceIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddBalanceIdentity.Location = new System.Drawing.Point(389, 95);
            this.BtnAddBalanceIdentity.Name = "BtnAddBalanceIdentity";
            this.BtnAddBalanceIdentity.Size = new System.Drawing.Size(75, 23);
            this.BtnAddBalanceIdentity.TabIndex = 1;
            this.BtnAddBalanceIdentity.Text = "Hinzufügen";
            this.BtnAddBalanceIdentity.UseVisualStyleBackColor = true;
            this.BtnAddBalanceIdentity.Click += new System.EventHandler(this.BtnAddSenderIdentity_Click);
            // 
            // BalanceInformationsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BalancesGrp);
            this.Name = "BalanceInformationsUc";
            this.Size = new System.Drawing.Size(638, 130);
            this.BalancesGrp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BalancesGrp;
        private System.Windows.Forms.ListView BalancesListView;
        private System.Windows.Forms.Button BtnAddBalanceIdentity;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
    }
}
