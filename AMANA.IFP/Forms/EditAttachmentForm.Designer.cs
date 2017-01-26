namespace AMANA.IFP.Forms
{
    partial class EditAttachmentForm
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
            this.LabelFilePath = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.MimeTypeLabel = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TextBoxMimeType = new System.Windows.Forms.TextBox();
            this.TextBoxFileName = new System.Windows.Forms.TextBox();
            this.TextBoxFilePath = new System.Windows.Forms.TextBox();
            this.AttachmentTypeLabel = new System.Windows.Forms.Label();
            this.AttachmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelFilePath
            // 
            this.LabelFilePath.AutoSize = true;
            this.LabelFilePath.Location = new System.Drawing.Point(12, 15);
            this.LabelFilePath.Name = "LabelFilePath";
            this.LabelFilePath.Size = new System.Drawing.Size(57, 13);
            this.LabelFilePath.TabIndex = 0;
            this.LabelFilePath.Text = "Dateipfad*";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 41);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(58, 13);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "Dateiname";
            // 
            // MimeTypeLabel
            // 
            this.MimeTypeLabel.AutoSize = true;
            this.MimeTypeLabel.Location = new System.Drawing.Point(12, 67);
            this.MimeTypeLabel.Name = "MimeTypeLabel";
            this.MimeTypeLabel.Size = new System.Drawing.Size(60, 13);
            this.MimeTypeLabel.TabIndex = 5;
            this.MimeTypeLabel.Text = "MIME-Typ*";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileButton.Location = new System.Drawing.Point(197, 10);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.Text = "Suchen";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(197, 125);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Speichern";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TextBoxMimeType
            // 
            this.TextBoxMimeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMimeType.Enabled = false;
            this.TextBoxMimeType.Location = new System.Drawing.Point(115, 64);
            this.TextBoxMimeType.Name = "TextBoxMimeType";
            this.TextBoxMimeType.Size = new System.Drawing.Size(157, 20);
            this.TextBoxMimeType.TabIndex = 6;
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileName.Location = new System.Drawing.Point(115, 38);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Size = new System.Drawing.Size(157, 20);
            this.TextBoxFileName.TabIndex = 4;
            // 
            // TextBoxFilePath
            // 
            this.TextBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFilePath.Location = new System.Drawing.Point(115, 12);
            this.TextBoxFilePath.Name = "TextBoxFilePath";
            this.TextBoxFilePath.Size = new System.Drawing.Size(76, 20);
            this.TextBoxFilePath.TabIndex = 1;
            // 
            // AttachmentTypeLabel
            // 
            this.AttachmentTypeLabel.AutoSize = true;
            this.AttachmentTypeLabel.Location = new System.Drawing.Point(12, 93);
            this.AttachmentTypeLabel.Name = "AttachmentTypeLabel";
            this.AttachmentTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.AttachmentTypeLabel.TabIndex = 7;
            this.AttachmentTypeLabel.Text = "Anhangtyp";
            // 
            // AttachmentTypeComboBox
            // 
            this.AttachmentTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttachmentTypeComboBox.FormattingEnabled = true;
            this.AttachmentTypeComboBox.Location = new System.Drawing.Point(115, 90);
            this.AttachmentTypeComboBox.Name = "AttachmentTypeComboBox";
            this.AttachmentTypeComboBox.Size = new System.Drawing.Size(157, 21);
            this.AttachmentTypeComboBox.TabIndex = 8;
            // 
            // EditAttachmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.AttachmentTypeComboBox);
            this.Controls.Add(this.AttachmentTypeLabel);
            this.Controls.Add(this.TextBoxFilePath);
            this.Controls.Add(this.TextBoxFileName);
            this.Controls.Add(this.TextBoxMimeType);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.MimeTypeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.LabelFilePath);
            this.MinimumSize = new System.Drawing.Size(300, 195);
            this.Name = "EditAttachmentForm";
            this.Text = "EditAttachmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFilePath;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label MimeTypeLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TextBoxMimeType;
        private System.Windows.Forms.TextBox TextBoxFileName;
        private System.Windows.Forms.TextBox TextBoxFilePath;
        private System.Windows.Forms.Label AttachmentTypeLabel;
        private System.Windows.Forms.ComboBox AttachmentTypeComboBox;
    }
}