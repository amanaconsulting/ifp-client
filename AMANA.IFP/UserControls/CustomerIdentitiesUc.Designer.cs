namespace AMANA.IFP.UserControls
{
    partial class CustomerIdentitiesUc
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
            this.IdentitiesGrp = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SenderIdentityListView = new System.Windows.Forms.ListView();
            this.BtnAddSenderIdentity = new System.Windows.Forms.Button();
            this.IdentitiesGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdentitiesGrp
            // 
            this.IdentitiesGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentitiesGrp.Controls.Add(this.RemoveButton);
            this.IdentitiesGrp.Controls.Add(this.EditButton);
            this.IdentitiesGrp.Controls.Add(this.SenderIdentityListView);
            this.IdentitiesGrp.Controls.Add(this.BtnAddSenderIdentity);
            this.IdentitiesGrp.Location = new System.Drawing.Point(3, 3);
            this.IdentitiesGrp.Name = "IdentitiesGrp";
            this.IdentitiesGrp.Size = new System.Drawing.Size(632, 124);
            this.IdentitiesGrp.TabIndex = 0;
            this.IdentitiesGrp.TabStop = false;
            this.IdentitiesGrp.Text = "Identitäten*";
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
            this.RemoveButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            // SenderIdentityListView
            // 
            this.SenderIdentityListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderIdentityListView.Location = new System.Drawing.Point(6, 19);
            this.SenderIdentityListView.Name = "SenderIdentityListView";
            this.SenderIdentityListView.Size = new System.Drawing.Size(620, 70);
            this.SenderIdentityListView.TabIndex = 0;
            this.SenderIdentityListView.UseCompatibleStateImageBehavior = false;
            this.SenderIdentityListView.View = System.Windows.Forms.View.Details;
            // 
            // BtnAddSenderIdentity
            // 
            this.BtnAddSenderIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddSenderIdentity.Location = new System.Drawing.Point(389, 95);
            this.BtnAddSenderIdentity.Name = "BtnAddSenderIdentity";
            this.BtnAddSenderIdentity.Size = new System.Drawing.Size(75, 23);
            this.BtnAddSenderIdentity.TabIndex = 1;
            this.BtnAddSenderIdentity.Text = "Hinzufügen";
            this.BtnAddSenderIdentity.UseVisualStyleBackColor = true;
            this.BtnAddSenderIdentity.Click += new System.EventHandler(this.BtnAddSenderIdentity_Click);
            // 
            // CustomerIdentitiesUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdentitiesGrp);
            this.Name = "CustomerIdentitiesUc";
            this.Size = new System.Drawing.Size(638, 130);
            this.IdentitiesGrp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox IdentitiesGrp;
        private System.Windows.Forms.ListView SenderIdentityListView;
        private System.Windows.Forms.Button BtnAddSenderIdentity;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
    }
}
