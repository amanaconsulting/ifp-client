namespace AMANA.IFP.UserControls
{
    partial class AddressUc
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
            this.components = new System.ComponentModel.Container();
            this.AddressGrp = new System.Windows.Forms.GroupBox();
            this.AddressesTlp = new System.Windows.Forms.TableLayoutPanel();
            this.SenderStatePnl = new System.Windows.Forms.Panel();
            this.SenderStateLabel = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.SenderCountryPnl = new System.Windows.Forms.Panel();
            this.ApplyGcdDataCountryButton = new System.Windows.Forms.Button();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.SenderCountryLabel = new System.Windows.Forms.Label();
            this.HomeAddressGrp = new System.Windows.Forms.GroupBox();
            this.ApplyGcdDataCityButton = new System.Windows.Forms.Button();
            this.ApplyGcdDataZipCodeButton = new System.Windows.Forms.Button();
            this.ApplyGcdDataStreetButton = new System.Windows.Forms.Button();
            this.SenderHomeSubCityLabel = new System.Windows.Forms.Label();
            this.HomeCityLabel = new System.Windows.Forms.Label();
            this.HomeAddressSubCityTextBox = new System.Windows.Forms.TextBox();
            this.HomeAddressCityTextBox = new System.Windows.Forms.TextBox();
            this.HomeAddressZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.SenderHomeZipCodeLabel = new System.Windows.Forms.Label();
            this.HomeAddressStreetTextBox = new System.Windows.Forms.TextBox();
            this.HomeAddressLabel = new System.Windows.Forms.Label();
            this.ChkSendHomeAddress = new System.Windows.Forms.CheckBox();
            this.BoxAddressGrp = new System.Windows.Forms.GroupBox();
            this.SenderBoxNumberLabel = new System.Windows.Forms.Label();
            this.SenderBoxCityLabel = new System.Windows.Forms.Label();
            this.BoxNumberTextBox = new System.Windows.Forms.TextBox();
            this.BoxCityTextBox = new System.Windows.Forms.TextBox();
            this.BoxZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.SenderBoxZipCodeLabel = new System.Windows.Forms.Label();
            this.ChkSendBoxAddress = new System.Windows.Forms.CheckBox();
            this.GcdDataTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.AddressGrp.SuspendLayout();
            this.AddressesTlp.SuspendLayout();
            this.SenderStatePnl.SuspendLayout();
            this.SenderCountryPnl.SuspendLayout();
            this.HomeAddressGrp.SuspendLayout();
            this.BoxAddressGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressGrp
            // 
            this.AddressGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressGrp.Controls.Add(this.AddressesTlp);
            this.AddressGrp.Location = new System.Drawing.Point(3, 3);
            this.AddressGrp.Name = "AddressGrp";
            this.AddressGrp.Size = new System.Drawing.Size(632, 212);
            this.AddressGrp.TabIndex = 0;
            this.AddressGrp.TabStop = false;
            this.AddressGrp.Text = "Adresse*";
            // 
            // AddressesTlp
            // 
            this.AddressesTlp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressesTlp.ColumnCount = 2;
            this.AddressesTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddressesTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddressesTlp.Controls.Add(this.SenderStatePnl, 1, 1);
            this.AddressesTlp.Controls.Add(this.SenderCountryPnl, 0, 1);
            this.AddressesTlp.Controls.Add(this.HomeAddressGrp, 0, 0);
            this.AddressesTlp.Controls.Add(this.BoxAddressGrp, 1, 0);
            this.AddressesTlp.Location = new System.Drawing.Point(6, 19);
            this.AddressesTlp.Name = "AddressesTlp";
            this.AddressesTlp.RowCount = 2;
            this.AddressesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddressesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.AddressesTlp.Size = new System.Drawing.Size(620, 187);
            this.AddressesTlp.TabIndex = 0;
            // 
            // SenderStatePnl
            // 
            this.SenderStatePnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderStatePnl.Controls.Add(this.SenderStateLabel);
            this.SenderStatePnl.Controls.Add(this.StateTextBox);
            this.SenderStatePnl.Location = new System.Drawing.Point(313, 157);
            this.SenderStatePnl.Name = "SenderStatePnl";
            this.SenderStatePnl.Size = new System.Drawing.Size(304, 27);
            this.SenderStatePnl.TabIndex = 3;
            // 
            // SenderStateLabel
            // 
            this.SenderStateLabel.AutoSize = true;
            this.SenderStateLabel.Location = new System.Drawing.Point(8, 6);
            this.SenderStateLabel.Name = "SenderStateLabel";
            this.SenderStateLabel.Size = new System.Drawing.Size(63, 13);
            this.SenderStateLabel.TabIndex = 0;
            this.SenderStateLabel.Text = "Bundesland";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(173, 3);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(125, 20);
            this.StateTextBox.TabIndex = 1;
            // 
            // SenderCountryPnl
            // 
            this.SenderCountryPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderCountryPnl.Controls.Add(this.ApplyGcdDataCountryButton);
            this.SenderCountryPnl.Controls.Add(this.CountryTextBox);
            this.SenderCountryPnl.Controls.Add(this.SenderCountryLabel);
            this.SenderCountryPnl.Location = new System.Drawing.Point(3, 157);
            this.SenderCountryPnl.Name = "SenderCountryPnl";
            this.SenderCountryPnl.Size = new System.Drawing.Size(304, 27);
            this.SenderCountryPnl.TabIndex = 2;
            // 
            // ApplyGcdDataCountryButton
            // 
            this.ApplyGcdDataCountryButton.Image = global::AMANA.IFP.Properties.Resources.nav_refresh_blue_16x16;
            this.ApplyGcdDataCountryButton.Location = new System.Drawing.Point(142, 0);
            this.ApplyGcdDataCountryButton.Name = "ApplyGcdDataCountryButton";
            this.ApplyGcdDataCountryButton.Size = new System.Drawing.Size(25, 25);
            this.ApplyGcdDataCountryButton.TabIndex = 1;
            this.ApplyGcdDataCountryButton.UseVisualStyleBackColor = true;
            this.ApplyGcdDataCountryButton.Visible = false;
            this.ApplyGcdDataCountryButton.Click += new System.EventHandler(this.ApplyGcdDataCountryButton_Click);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(173, 3);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(125, 20);
            this.CountryTextBox.TabIndex = 2;
            // 
            // SenderCountryLabel
            // 
            this.SenderCountryLabel.AutoSize = true;
            this.SenderCountryLabel.Location = new System.Drawing.Point(3, 6);
            this.SenderCountryLabel.Name = "SenderCountryLabel";
            this.SenderCountryLabel.Size = new System.Drawing.Size(31, 13);
            this.SenderCountryLabel.TabIndex = 0;
            this.SenderCountryLabel.Text = "Land";
            // 
            // HomeAddressGrp
            // 
            this.HomeAddressGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAddressGrp.Controls.Add(this.ApplyGcdDataCityButton);
            this.HomeAddressGrp.Controls.Add(this.ApplyGcdDataZipCodeButton);
            this.HomeAddressGrp.Controls.Add(this.ApplyGcdDataStreetButton);
            this.HomeAddressGrp.Controls.Add(this.SenderHomeSubCityLabel);
            this.HomeAddressGrp.Controls.Add(this.HomeCityLabel);
            this.HomeAddressGrp.Controls.Add(this.HomeAddressSubCityTextBox);
            this.HomeAddressGrp.Controls.Add(this.HomeAddressCityTextBox);
            this.HomeAddressGrp.Controls.Add(this.HomeAddressZipCodeTextBox);
            this.HomeAddressGrp.Controls.Add(this.SenderHomeZipCodeLabel);
            this.HomeAddressGrp.Controls.Add(this.HomeAddressStreetTextBox);
            this.HomeAddressGrp.Controls.Add(this.HomeAddressLabel);
            this.HomeAddressGrp.Controls.Add(this.ChkSendHomeAddress);
            this.HomeAddressGrp.Location = new System.Drawing.Point(3, 3);
            this.HomeAddressGrp.Name = "HomeAddressGrp";
            this.HomeAddressGrp.Size = new System.Drawing.Size(304, 148);
            this.HomeAddressGrp.TabIndex = 0;
            this.HomeAddressGrp.TabStop = false;
            this.HomeAddressGrp.Text = "Hausanschrift";
            // 
            // ApplyGcdDataCityButton
            // 
            this.ApplyGcdDataCityButton.Enabled = false;
            this.ApplyGcdDataCityButton.Image = global::AMANA.IFP.Properties.Resources.nav_refresh_blue_16x16;
            this.ApplyGcdDataCityButton.Location = new System.Drawing.Point(142, 90);
            this.ApplyGcdDataCityButton.Name = "ApplyGcdDataCityButton";
            this.ApplyGcdDataCityButton.Size = new System.Drawing.Size(25, 25);
            this.ApplyGcdDataCityButton.TabIndex = 8;
            this.ApplyGcdDataCityButton.UseVisualStyleBackColor = true;
            this.ApplyGcdDataCityButton.Visible = false;
            this.ApplyGcdDataCityButton.Click += new System.EventHandler(this.ApplyGcdDataCityButton_Click);
            // 
            // ApplyGcdDataZipCodeButton
            // 
            this.ApplyGcdDataZipCodeButton.Enabled = false;
            this.ApplyGcdDataZipCodeButton.Image = global::AMANA.IFP.Properties.Resources.nav_refresh_blue_16x16;
            this.ApplyGcdDataZipCodeButton.Location = new System.Drawing.Point(142, 64);
            this.ApplyGcdDataZipCodeButton.Name = "ApplyGcdDataZipCodeButton";
            this.ApplyGcdDataZipCodeButton.Size = new System.Drawing.Size(25, 25);
            this.ApplyGcdDataZipCodeButton.TabIndex = 5;
            this.ApplyGcdDataZipCodeButton.UseVisualStyleBackColor = true;
            this.ApplyGcdDataZipCodeButton.Visible = false;
            this.ApplyGcdDataZipCodeButton.Click += new System.EventHandler(this.ApplyGcdDataZipCodeButton_Click);
            // 
            // ApplyGcdDataStreetButton
            // 
            this.ApplyGcdDataStreetButton.Enabled = false;
            this.ApplyGcdDataStreetButton.Image = global::AMANA.IFP.Properties.Resources.nav_refresh_blue_16x16;
            this.ApplyGcdDataStreetButton.Location = new System.Drawing.Point(142, 38);
            this.ApplyGcdDataStreetButton.Name = "ApplyGcdDataStreetButton";
            this.ApplyGcdDataStreetButton.Size = new System.Drawing.Size(25, 25);
            this.ApplyGcdDataStreetButton.TabIndex = 2;
            this.ApplyGcdDataStreetButton.UseVisualStyleBackColor = true;
            this.ApplyGcdDataStreetButton.Visible = false;
            this.ApplyGcdDataStreetButton.Click += new System.EventHandler(this.ApplyGcdDataStreetButton_Click);
            // 
            // SenderHomeSubCityLabel
            // 
            this.SenderHomeSubCityLabel.AutoSize = true;
            this.SenderHomeSubCityLabel.Location = new System.Drawing.Point(7, 122);
            this.SenderHomeSubCityLabel.Name = "SenderHomeSubCityLabel";
            this.SenderHomeSubCityLabel.Size = new System.Drawing.Size(36, 13);
            this.SenderHomeSubCityLabel.TabIndex = 10;
            this.SenderHomeSubCityLabel.Text = "Teilort";
            // 
            // HomeCityLabel
            // 
            this.HomeCityLabel.AutoSize = true;
            this.HomeCityLabel.Location = new System.Drawing.Point(7, 96);
            this.HomeCityLabel.Name = "HomeCityLabel";
            this.HomeCityLabel.Size = new System.Drawing.Size(25, 13);
            this.HomeCityLabel.TabIndex = 7;
            this.HomeCityLabel.Text = "Ort*";
            // 
            // HomeAddressSubCityTextBox
            // 
            this.HomeAddressSubCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAddressSubCityTextBox.Enabled = false;
            this.HomeAddressSubCityTextBox.Location = new System.Drawing.Point(173, 119);
            this.HomeAddressSubCityTextBox.Name = "HomeAddressSubCityTextBox";
            this.HomeAddressSubCityTextBox.Size = new System.Drawing.Size(125, 20);
            this.HomeAddressSubCityTextBox.TabIndex = 11;
            // 
            // HomeAddressCityTextBox
            // 
            this.HomeAddressCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAddressCityTextBox.Enabled = false;
            this.HomeAddressCityTextBox.Location = new System.Drawing.Point(173, 93);
            this.HomeAddressCityTextBox.Name = "HomeAddressCityTextBox";
            this.HomeAddressCityTextBox.Size = new System.Drawing.Size(125, 20);
            this.HomeAddressCityTextBox.TabIndex = 9;
            // 
            // HomeAddressZipCodeTextBox
            // 
            this.HomeAddressZipCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAddressZipCodeTextBox.Enabled = false;
            this.HomeAddressZipCodeTextBox.Location = new System.Drawing.Point(173, 67);
            this.HomeAddressZipCodeTextBox.Name = "HomeAddressZipCodeTextBox";
            this.HomeAddressZipCodeTextBox.Size = new System.Drawing.Size(125, 20);
            this.HomeAddressZipCodeTextBox.TabIndex = 6;
            // 
            // SenderHomeZipCodeLabel
            // 
            this.SenderHomeZipCodeLabel.AutoSize = true;
            this.SenderHomeZipCodeLabel.Location = new System.Drawing.Point(7, 70);
            this.SenderHomeZipCodeLabel.Name = "SenderHomeZipCodeLabel";
            this.SenderHomeZipCodeLabel.Size = new System.Drawing.Size(31, 13);
            this.SenderHomeZipCodeLabel.TabIndex = 4;
            this.SenderHomeZipCodeLabel.Text = "PLZ*";
            // 
            // HomeAddressStreetTextBox
            // 
            this.HomeAddressStreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAddressStreetTextBox.Enabled = false;
            this.HomeAddressStreetTextBox.Location = new System.Drawing.Point(173, 41);
            this.HomeAddressStreetTextBox.Name = "HomeAddressStreetTextBox";
            this.HomeAddressStreetTextBox.Size = new System.Drawing.Size(125, 20);
            this.HomeAddressStreetTextBox.TabIndex = 3;
            // 
            // HomeAddressLabel
            // 
            this.HomeAddressLabel.AutoSize = true;
            this.HomeAddressLabel.Location = new System.Drawing.Point(7, 44);
            this.HomeAddressLabel.Name = "HomeAddressLabel";
            this.HomeAddressLabel.Size = new System.Drawing.Size(110, 13);
            this.HomeAddressLabel.TabIndex = 1;
            this.HomeAddressLabel.Text = "Straße, Hausnummer*";
            // 
            // ChkSendHomeAddress
            // 
            this.ChkSendHomeAddress.AutoSize = true;
            this.ChkSendHomeAddress.Location = new System.Drawing.Point(10, 19);
            this.ChkSendHomeAddress.Name = "ChkSendHomeAddress";
            this.ChkSendHomeAddress.Size = new System.Drawing.Size(141, 17);
            this.ChkSendHomeAddress.TabIndex = 0;
            this.ChkSendHomeAddress.Text = "Übermittle Hausanschrift";
            this.ChkSendHomeAddress.UseVisualStyleBackColor = true;
            // 
            // BoxAddressGrp
            // 
            this.BoxAddressGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxAddressGrp.Controls.Add(this.SenderBoxNumberLabel);
            this.BoxAddressGrp.Controls.Add(this.SenderBoxCityLabel);
            this.BoxAddressGrp.Controls.Add(this.BoxNumberTextBox);
            this.BoxAddressGrp.Controls.Add(this.BoxCityTextBox);
            this.BoxAddressGrp.Controls.Add(this.BoxZipCodeTextBox);
            this.BoxAddressGrp.Controls.Add(this.SenderBoxZipCodeLabel);
            this.BoxAddressGrp.Controls.Add(this.ChkSendBoxAddress);
            this.BoxAddressGrp.Location = new System.Drawing.Point(313, 3);
            this.BoxAddressGrp.Name = "BoxAddressGrp";
            this.BoxAddressGrp.Size = new System.Drawing.Size(304, 148);
            this.BoxAddressGrp.TabIndex = 1;
            this.BoxAddressGrp.TabStop = false;
            this.BoxAddressGrp.Text = "Postfach";
            // 
            // SenderBoxNumberLabel
            // 
            this.SenderBoxNumberLabel.AutoSize = true;
            this.SenderBoxNumberLabel.Location = new System.Drawing.Point(8, 118);
            this.SenderBoxNumberLabel.Name = "SenderBoxNumberLabel";
            this.SenderBoxNumberLabel.Size = new System.Drawing.Size(46, 13);
            this.SenderBoxNumberLabel.TabIndex = 5;
            this.SenderBoxNumberLabel.Text = "Nummer";
            // 
            // SenderBoxCityLabel
            // 
            this.SenderBoxCityLabel.AutoSize = true;
            this.SenderBoxCityLabel.Location = new System.Drawing.Point(8, 96);
            this.SenderBoxCityLabel.Name = "SenderBoxCityLabel";
            this.SenderBoxCityLabel.Size = new System.Drawing.Size(21, 13);
            this.SenderBoxCityLabel.TabIndex = 3;
            this.SenderBoxCityLabel.Text = "Ort";
            // 
            // BoxNumberTextBox
            // 
            this.BoxNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxNumberTextBox.Enabled = false;
            this.BoxNumberTextBox.Location = new System.Drawing.Point(173, 115);
            this.BoxNumberTextBox.Name = "BoxNumberTextBox";
            this.BoxNumberTextBox.Size = new System.Drawing.Size(125, 20);
            this.BoxNumberTextBox.TabIndex = 6;
            // 
            // BoxCityTextBox
            // 
            this.BoxCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxCityTextBox.Enabled = false;
            this.BoxCityTextBox.Location = new System.Drawing.Point(173, 90);
            this.BoxCityTextBox.Name = "BoxCityTextBox";
            this.BoxCityTextBox.Size = new System.Drawing.Size(125, 20);
            this.BoxCityTextBox.TabIndex = 4;
            // 
            // BoxZipCodeTextBox
            // 
            this.BoxZipCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxZipCodeTextBox.Enabled = false;
            this.BoxZipCodeTextBox.Location = new System.Drawing.Point(173, 63);
            this.BoxZipCodeTextBox.Name = "BoxZipCodeTextBox";
            this.BoxZipCodeTextBox.Size = new System.Drawing.Size(125, 20);
            this.BoxZipCodeTextBox.TabIndex = 2;
            // 
            // SenderBoxZipCodeLabel
            // 
            this.SenderBoxZipCodeLabel.AutoSize = true;
            this.SenderBoxZipCodeLabel.Location = new System.Drawing.Point(8, 70);
            this.SenderBoxZipCodeLabel.Name = "SenderBoxZipCodeLabel";
            this.SenderBoxZipCodeLabel.Size = new System.Drawing.Size(27, 13);
            this.SenderBoxZipCodeLabel.TabIndex = 1;
            this.SenderBoxZipCodeLabel.Text = "PLZ";
            // 
            // ChkSendBoxAddress
            // 
            this.ChkSendBoxAddress.AutoSize = true;
            this.ChkSendBoxAddress.Location = new System.Drawing.Point(10, 19);
            this.ChkSendBoxAddress.Name = "ChkSendBoxAddress";
            this.ChkSendBoxAddress.Size = new System.Drawing.Size(118, 17);
            this.ChkSendBoxAddress.TabIndex = 0;
            this.ChkSendBoxAddress.Text = "Übermittle Postfach";
            this.ChkSendBoxAddress.UseVisualStyleBackColor = true;
            // 
            // AddressUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressGrp);
            this.Name = "AddressUc";
            this.Size = new System.Drawing.Size(639, 218);
            this.AddressGrp.ResumeLayout(false);
            this.AddressesTlp.ResumeLayout(false);
            this.SenderStatePnl.ResumeLayout(false);
            this.SenderStatePnl.PerformLayout();
            this.SenderCountryPnl.ResumeLayout(false);
            this.SenderCountryPnl.PerformLayout();
            this.HomeAddressGrp.ResumeLayout(false);
            this.HomeAddressGrp.PerformLayout();
            this.BoxAddressGrp.ResumeLayout(false);
            this.BoxAddressGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddressGrp;
        private System.Windows.Forms.TableLayoutPanel AddressesTlp;
        private System.Windows.Forms.Panel SenderStatePnl;
        private System.Windows.Forms.Label SenderStateLabel;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.Panel SenderCountryPnl;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label SenderCountryLabel;
        private System.Windows.Forms.GroupBox HomeAddressGrp;
        private System.Windows.Forms.Label SenderHomeSubCityLabel;
        private System.Windows.Forms.Label HomeCityLabel;
        private System.Windows.Forms.TextBox HomeAddressSubCityTextBox;
        private System.Windows.Forms.TextBox HomeAddressCityTextBox;
        private System.Windows.Forms.TextBox HomeAddressZipCodeTextBox;
        private System.Windows.Forms.Label SenderHomeZipCodeLabel;
        private System.Windows.Forms.TextBox HomeAddressStreetTextBox;
        private System.Windows.Forms.Label HomeAddressLabel;
        private System.Windows.Forms.CheckBox ChkSendHomeAddress;
        private System.Windows.Forms.GroupBox BoxAddressGrp;
        private System.Windows.Forms.Label SenderBoxNumberLabel;
        private System.Windows.Forms.Label SenderBoxCityLabel;
        private System.Windows.Forms.TextBox BoxNumberTextBox;
        private System.Windows.Forms.TextBox BoxCityTextBox;
        private System.Windows.Forms.TextBox BoxZipCodeTextBox;
        private System.Windows.Forms.Label SenderBoxZipCodeLabel;
        private System.Windows.Forms.CheckBox ChkSendBoxAddress;
        private System.Windows.Forms.Button ApplyGcdDataStreetButton;
        private System.Windows.Forms.Button ApplyGcdDataCountryButton;
        private System.Windows.Forms.Button ApplyGcdDataCityButton;
        private System.Windows.Forms.Button ApplyGcdDataZipCodeButton;
        private System.Windows.Forms.ToolTip GcdDataTooltip;
    }
}
