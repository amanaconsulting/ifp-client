namespace AMANA.IFP.UserControls
{
    partial class RequestResultUc
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
            this.RequestResultGroupBox = new System.Windows.Forms.GroupBox();
            this.DataSendLabel = new System.Windows.Forms.Label();
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.RequestTimeLabel = new System.Windows.Forms.Label();
            this.ValidationTimeLabel = new System.Windows.Forms.Label();
            this.RequestResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestResultGroupBox
            // 
            this.RequestResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestResultGroupBox.Controls.Add(this.DataSendLabel);
            this.RequestResultGroupBox.Controls.Add(this.MessagesListView);
            this.RequestResultGroupBox.Controls.Add(this.RequestTimeLabel);
            this.RequestResultGroupBox.Controls.Add(this.ValidationTimeLabel);
            this.RequestResultGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RequestResultGroupBox.Name = "RequestResultGroupBox";
            this.RequestResultGroupBox.Size = new System.Drawing.Size(144, 144);
            this.RequestResultGroupBox.TabIndex = 0;
            this.RequestResultGroupBox.TabStop = false;
            this.RequestResultGroupBox.Text = "Meldungen";
            // 
            // DataSendLabel
            // 
            this.DataSendLabel.AutoSize = true;
            this.DataSendLabel.Location = new System.Drawing.Point(3, 29);
            this.DataSendLabel.Name = "DataSendLabel";
            this.DataSendLabel.Size = new System.Drawing.Size(194, 13);
            this.DataSendLabel.TabIndex = 3;
            this.DataSendLabel.Text = "Es werden keine Meldungen angezeigt.";
            // 
            // MessagesListView
            // 
            this.MessagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesListView.FullRowSelect = true;
            this.MessagesListView.Location = new System.Drawing.Point(6, 50);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(132, 88);
            this.MessagesListView.TabIndex = 2;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.Details;
            this.MessagesListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MessagesListView_KeyUp);
            // 
            // RequestTimeLabel
            // 
            this.RequestTimeLabel.AutoSize = true;
            this.RequestTimeLabel.Location = new System.Drawing.Point(3, 16);
            this.RequestTimeLabel.Name = "RequestTimeLabel";
            this.RequestTimeLabel.Size = new System.Drawing.Size(208, 13);
            this.RequestTimeLabel.TabIndex = 1;
            this.RequestTimeLabel.Text = "Es wurde noch keine IFP-Daten gesendet.";
            // 
            // ValidationTimeLabel
            // 
            this.ValidationTimeLabel.AutoSize = true;
            this.ValidationTimeLabel.Location = new System.Drawing.Point(6, 16);
            this.ValidationTimeLabel.Name = "ValidationTimeLabel";
            this.ValidationTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.ValidationTimeLabel.TabIndex = 0;
            this.ValidationTimeLabel.Text = "label1";
            // 
            // RequestResultUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RequestResultGroupBox);
            this.Name = "RequestResultUc";
            this.RequestResultGroupBox.ResumeLayout(false);
            this.RequestResultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RequestResultGroupBox;
        private System.Windows.Forms.Label DataSendLabel;
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.Label RequestTimeLabel;
        private System.Windows.Forms.Label ValidationTimeLabel;
    }
}
