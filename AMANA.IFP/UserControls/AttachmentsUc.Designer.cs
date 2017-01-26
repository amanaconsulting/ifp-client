namespace AMANA.IFP.UserControls
{
    partial class AttachmentsUc
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
            this.AttachmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AttachmentsListView = new System.Windows.Forms.ListView();
            this.AttachmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttachmentsGroupBox
            // 
            this.AttachmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentsGroupBox.Controls.Add(this.EditButton);
            this.AttachmentsGroupBox.Controls.Add(this.RemoveButton);
            this.AttachmentsGroupBox.Controls.Add(this.AddButton);
            this.AttachmentsGroupBox.Controls.Add(this.AttachmentsListView);
            this.AttachmentsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AttachmentsGroupBox.Name = "AttachmentsGroupBox";
            this.AttachmentsGroupBox.Size = new System.Drawing.Size(375, 147);
            this.AttachmentsGroupBox.TabIndex = 0;
            this.AttachmentsGroupBox.TabStop = false;
            this.AttachmentsGroupBox.Text = "Anhänge*";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(213, 119);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Bearbeiten";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(294, 119);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Entfernen";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(132, 119);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Hinzufügen";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AttachmentsListView
            // 
            this.AttachmentsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentsListView.Location = new System.Drawing.Point(3, 16);
            this.AttachmentsListView.Name = "AttachmentsListView";
            this.AttachmentsListView.Size = new System.Drawing.Size(366, 97);
            this.AttachmentsListView.TabIndex = 0;
            this.AttachmentsListView.UseCompatibleStateImageBehavior = false;
            this.AttachmentsListView.View = System.Windows.Forms.View.Details;
            // 
            // AttachmentsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AttachmentsGroupBox);
            this.Name = "AttachmentsUc";
            this.Size = new System.Drawing.Size(378, 150);
            this.AttachmentsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AttachmentsGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListView AttachmentsListView;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}
