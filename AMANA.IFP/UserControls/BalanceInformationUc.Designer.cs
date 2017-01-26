namespace AMANA.IFP.UserControls
{
    partial class BalanceInformationUc
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
            this.BalanceInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.AttachmentsTableLayoutPanels = new System.Windows.Forms.TableLayoutPanel();
            this.CommentPanel = new System.Windows.Forms.Panel();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.AttachmentsUc = new AMANA.IFP.UserControls.AttachmentsUc();
            this.AccountsPanel = new System.Windows.Forms.Panel();
            this.AccountsTextBox = new System.Windows.Forms.TextBox();
            this.AccountsLabel = new System.Windows.Forms.Label();
            this.BalanceXbrlFileLabel = new System.Windows.Forms.Label();
            this.IdentLabel = new System.Windows.Forms.Label();
            this.BalanceXbrlFilePathButton = new System.Windows.Forms.Button();
            this.IdentComboBox = new System.Windows.Forms.ComboBox();
            this.BalanceXbrlFilePathTextBox = new System.Windows.Forms.TextBox();
            this.BalanceLevelLabel = new System.Windows.Forms.Label();
            this.BalanceLevelComboBox = new System.Windows.Forms.ComboBox();
            this.BalanceDueDateLabel = new System.Windows.Forms.Label();
            this.BalanceDueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BalanceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BalanceTypeLabel = new System.Windows.Forms.Label();
            this.BalanceInformationGroupBox.SuspendLayout();
            this.AttachmentsTableLayoutPanels.SuspendLayout();
            this.CommentPanel.SuspendLayout();
            this.AccountsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BalanceInformationGroupBox
            // 
            this.BalanceInformationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceInformationGroupBox.Controls.Add(this.AttachmentsTableLayoutPanels);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceXbrlFileLabel);
            this.BalanceInformationGroupBox.Controls.Add(this.IdentLabel);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceXbrlFilePathButton);
            this.BalanceInformationGroupBox.Controls.Add(this.IdentComboBox);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceXbrlFilePathTextBox);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceLevelLabel);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceLevelComboBox);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceDueDateLabel);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceDueDateDateTimePicker);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceTypeComboBox);
            this.BalanceInformationGroupBox.Controls.Add(this.BalanceTypeLabel);
            this.BalanceInformationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BalanceInformationGroupBox.Name = "BalanceInformationGroupBox";
            this.BalanceInformationGroupBox.Size = new System.Drawing.Size(299, 499);
            this.BalanceInformationGroupBox.TabIndex = 0;
            this.BalanceInformationGroupBox.TabStop = false;
            this.BalanceInformationGroupBox.Text = "Abschluss*";
            // 
            // AttachmentsTableLayoutPanels
            // 
            this.AttachmentsTableLayoutPanels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentsTableLayoutPanels.ColumnCount = 1;
            this.AttachmentsTableLayoutPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AttachmentsTableLayoutPanels.Controls.Add(this.CommentPanel, 0, 0);
            this.AttachmentsTableLayoutPanels.Controls.Add(this.AttachmentsUc, 0, 2);
            this.AttachmentsTableLayoutPanels.Controls.Add(this.AccountsPanel, 0, 1);
            this.AttachmentsTableLayoutPanels.Location = new System.Drawing.Point(6, 155);
            this.AttachmentsTableLayoutPanels.Name = "AttachmentsTableLayoutPanels";
            this.AttachmentsTableLayoutPanels.RowCount = 3;
            this.AttachmentsTableLayoutPanels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.AttachmentsTableLayoutPanels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.AttachmentsTableLayoutPanels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AttachmentsTableLayoutPanels.Size = new System.Drawing.Size(287, 338);
            this.AttachmentsTableLayoutPanels.TabIndex = 11;
            // 
            // CommentPanel
            // 
            this.CommentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentPanel.Controls.Add(this.CommentTextBox);
            this.CommentPanel.Controls.Add(this.CommentLabel);
            this.CommentPanel.Location = new System.Drawing.Point(3, 3);
            this.CommentPanel.Name = "CommentPanel";
            this.CommentPanel.Size = new System.Drawing.Size(281, 95);
            this.CommentPanel.TabIndex = 0;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentTextBox.Location = new System.Drawing.Point(3, 16);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(275, 79);
            this.CommentTextBox.TabIndex = 1;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(0, 0);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(31, 13);
            this.CommentLabel.TabIndex = 0;
            this.CommentLabel.Text = "Notiz";
            // 
            // AttachmentsUc
            // 
            this.AttachmentsUc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentsUc.Attachments = null;
            this.AttachmentsUc.Location = new System.Drawing.Point(3, 205);
            this.AttachmentsUc.Name = "AttachmentsUc";
            this.AttachmentsUc.Size = new System.Drawing.Size(281, 130);
            this.AttachmentsUc.TabIndex = 2;
            // 
            // AccountsPanel
            // 
            this.AccountsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsPanel.Controls.Add(this.AccountsTextBox);
            this.AccountsPanel.Controls.Add(this.AccountsLabel);
            this.AccountsPanel.Location = new System.Drawing.Point(3, 104);
            this.AccountsPanel.Name = "AccountsPanel";
            this.AccountsPanel.Size = new System.Drawing.Size(281, 95);
            this.AccountsPanel.TabIndex = 1;
            // 
            // AccountsTextBox
            // 
            this.AccountsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsTextBox.Location = new System.Drawing.Point(3, 16);
            this.AccountsTextBox.Multiline = true;
            this.AccountsTextBox.Name = "AccountsTextBox";
            this.AccountsTextBox.Size = new System.Drawing.Size(275, 79);
            this.AccountsTextBox.TabIndex = 1;
            // 
            // AccountsLabel
            // 
            this.AccountsLabel.AutoSize = true;
            this.AccountsLabel.Location = new System.Drawing.Point(3, 0);
            this.AccountsLabel.Name = "AccountsLabel";
            this.AccountsLabel.Size = new System.Drawing.Size(92, 13);
            this.AccountsLabel.TabIndex = 0;
            this.AccountsLabel.Text = "Kontennachweise";
            // 
            // BalanceXbrlFileLabel
            // 
            this.BalanceXbrlFileLabel.AutoSize = true;
            this.BalanceXbrlFileLabel.Location = new System.Drawing.Point(6, 103);
            this.BalanceXbrlFileLabel.Name = "BalanceXbrlFileLabel";
            this.BalanceXbrlFileLabel.Size = new System.Drawing.Size(76, 13);
            this.BalanceXbrlFileLabel.TabIndex = 6;
            this.BalanceXbrlFileLabel.Text = "XBRL-Instanz*";
            // 
            // IdentLabel
            // 
            this.IdentLabel.AutoSize = true;
            this.IdentLabel.Location = new System.Drawing.Point(6, 131);
            this.IdentLabel.Name = "IdentLabel";
            this.IdentLabel.Size = new System.Drawing.Size(70, 13);
            this.IdentLabel.TabIndex = 9;
            this.IdentLabel.Text = "Identmerkmal";
            // 
            // BalanceXbrlFilePathButton
            // 
            this.BalanceXbrlFilePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceXbrlFilePathButton.Location = new System.Drawing.Point(218, 99);
            this.BalanceXbrlFilePathButton.Name = "BalanceXbrlFilePathButton";
            this.BalanceXbrlFilePathButton.Size = new System.Drawing.Size(75, 23);
            this.BalanceXbrlFilePathButton.TabIndex = 8;
            this.BalanceXbrlFilePathButton.Text = "Suchen";
            this.BalanceXbrlFilePathButton.UseVisualStyleBackColor = true;
            this.BalanceXbrlFilePathButton.Click += new System.EventHandler(this.BalanceXbrlFilePathButton_Click);
            // 
            // IdentComboBox
            // 
            this.IdentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdentComboBox.FormattingEnabled = true;
            this.IdentComboBox.Location = new System.Drawing.Point(115, 128);
            this.IdentComboBox.Name = "IdentComboBox";
            this.IdentComboBox.Size = new System.Drawing.Size(178, 21);
            this.IdentComboBox.TabIndex = 10;
            // 
            // BalanceXbrlFilePathTextBox
            // 
            this.BalanceXbrlFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceXbrlFilePathTextBox.Location = new System.Drawing.Point(115, 100);
            this.BalanceXbrlFilePathTextBox.Name = "BalanceXbrlFilePathTextBox";
            this.BalanceXbrlFilePathTextBox.Size = new System.Drawing.Size(97, 20);
            this.BalanceXbrlFilePathTextBox.TabIndex = 7;
            // 
            // BalanceLevelLabel
            // 
            this.BalanceLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceLevelLabel.AutoSize = true;
            this.BalanceLevelLabel.Location = new System.Drawing.Point(6, 75);
            this.BalanceLevelLabel.Name = "BalanceLevelLabel";
            this.BalanceLevelLabel.Size = new System.Drawing.Size(103, 13);
            this.BalanceLevelLabel.TabIndex = 4;
            this.BalanceLevelLabel.Text = "Bilanzierungsebene*";
            // 
            // BalanceLevelComboBox
            // 
            this.BalanceLevelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BalanceLevelComboBox.FormattingEnabled = true;
            this.BalanceLevelComboBox.Location = new System.Drawing.Point(115, 72);
            this.BalanceLevelComboBox.Name = "BalanceLevelComboBox";
            this.BalanceLevelComboBox.Size = new System.Drawing.Size(178, 21);
            this.BalanceLevelComboBox.TabIndex = 5;
            // 
            // BalanceDueDateLabel
            // 
            this.BalanceDueDateLabel.AutoSize = true;
            this.BalanceDueDateLabel.Location = new System.Drawing.Point(6, 52);
            this.BalanceDueDateLabel.Name = "BalanceDueDateLabel";
            this.BalanceDueDateLabel.Size = new System.Drawing.Size(96, 13);
            this.BalanceDueDateLabel.TabIndex = 2;
            this.BalanceDueDateLabel.Text = "Abschlussstichtag*";
            // 
            // BalanceDueDateDateTimePicker
            // 
            this.BalanceDueDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceDueDateDateTimePicker.CustomFormat = "";
            this.BalanceDueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BalanceDueDateDateTimePicker.Location = new System.Drawing.Point(115, 46);
            this.BalanceDueDateDateTimePicker.Name = "BalanceDueDateDateTimePicker";
            this.BalanceDueDateDateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.BalanceDueDateDateTimePicker.TabIndex = 3;
            // 
            // BalanceTypeComboBox
            // 
            this.BalanceTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BalanceTypeComboBox.FormattingEnabled = true;
            this.BalanceTypeComboBox.Location = new System.Drawing.Point(115, 19);
            this.BalanceTypeComboBox.Name = "BalanceTypeComboBox";
            this.BalanceTypeComboBox.Size = new System.Drawing.Size(178, 21);
            this.BalanceTypeComboBox.TabIndex = 1;
            // 
            // BalanceTypeLabel
            // 
            this.BalanceTypeLabel.AutoSize = true;
            this.BalanceTypeLabel.Location = new System.Drawing.Point(6, 22);
            this.BalanceTypeLabel.Name = "BalanceTypeLabel";
            this.BalanceTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.BalanceTypeLabel.TabIndex = 0;
            this.BalanceTypeLabel.Text = "Abschlussart*";
            // 
            // BalanceInformationUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BalanceInformationGroupBox);
            this.Name = "BalanceInformationUc";
            this.Size = new System.Drawing.Size(305, 505);
            this.BalanceInformationGroupBox.ResumeLayout(false);
            this.BalanceInformationGroupBox.PerformLayout();
            this.AttachmentsTableLayoutPanels.ResumeLayout(false);
            this.CommentPanel.ResumeLayout(false);
            this.CommentPanel.PerformLayout();
            this.AccountsPanel.ResumeLayout(false);
            this.AccountsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BalanceInformationGroupBox;
        private System.Windows.Forms.Label BalanceTypeLabel;
        private System.Windows.Forms.Label BalanceXbrlFileLabel;
        private System.Windows.Forms.Button BalanceXbrlFilePathButton;
        private System.Windows.Forms.TextBox BalanceXbrlFilePathTextBox;
        private System.Windows.Forms.Label BalanceLevelLabel;
        private System.Windows.Forms.ComboBox BalanceLevelComboBox;
        private System.Windows.Forms.Label BalanceDueDateLabel;
        private System.Windows.Forms.DateTimePicker BalanceDueDateDateTimePicker;
        private System.Windows.Forms.ComboBox BalanceTypeComboBox;
        private AttachmentsUc AttachmentsUc;
        private System.Windows.Forms.TableLayoutPanel AttachmentsTableLayoutPanels;
        private System.Windows.Forms.Panel AccountsPanel;
        private System.Windows.Forms.TextBox AccountsTextBox;
        private System.Windows.Forms.Label AccountsLabel;
        private System.Windows.Forms.Panel CommentPanel;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.Label IdentLabel;
        private System.Windows.Forms.ComboBox IdentComboBox;
    }
}
