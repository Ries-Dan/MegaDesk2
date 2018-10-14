namespace MegaDesk_Ries
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.submitQuoteButton = new System.Windows.Forms.Button();
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custNameText = new System.Windows.Forms.TextBox();
            this.custLabel = new System.Windows.Forms.Label();
            this.deskLabel = new System.Windows.Forms.Label();
            this.deskMaterialLabel = new System.Windows.Forms.Label();
            this.deskDrawersLabel = new System.Windows.Forms.Label();
            this.deskDepthLabel = new System.Windows.Forms.Label();
            this.deskWidthLabel = new System.Windows.Forms.Label();
            this.deskWidthText = new System.Windows.Forms.NumericUpDown();
            this.deskDepthText = new System.Windows.Forms.NumericUpDown();
            this.deskDrawersText = new System.Windows.Forms.NumericUpDown();
            this.rushLabel = new System.Windows.Forms.Label();
            this.rushDaysLabel = new System.Windows.Forms.Label();
            this.threeDayRadio = new System.Windows.Forms.RadioButton();
            this.fiveDayRadio = new System.Windows.Forms.RadioButton();
            this.sevenDayRadio = new System.Windows.Forms.RadioButton();
            this.fourteenDayRadio = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.deskMaterialComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidthText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepthText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawersText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitQuoteButton
            // 
            this.submitQuoteButton.Location = new System.Drawing.Point(25, 332);
            this.submitQuoteButton.Name = "submitQuoteButton";
            this.submitQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.submitQuoteButton.TabIndex = 10;
            this.submitQuoteButton.Text = "Submit";
            this.submitQuoteButton.UseVisualStyleBackColor = true;
            this.submitQuoteButton.Click += new System.EventHandler(this.submitQuoteButton_Click);
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.Location = new System.Drawing.Point(149, 332);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.cancelQuoteButton.TabIndex = 11;
            this.cancelQuoteButton.Text = "Close";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(13, 42);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(38, 13);
            this.custNameLabel.TabIndex = 1;
            this.custNameLabel.Text = "Name:";
            // 
            // custNameText
            // 
            this.custNameText.Location = new System.Drawing.Point(69, 39);
            this.custNameText.Name = "custNameText";
            this.custNameText.Size = new System.Drawing.Size(155, 20);
            this.custNameText.TabIndex = 1;
            // 
            // custLabel
            // 
            this.custLabel.AutoSize = true;
            this.custLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLabel.Location = new System.Drawing.Point(13, 13);
            this.custLabel.Name = "custLabel";
            this.custLabel.Size = new System.Drawing.Size(76, 17);
            this.custLabel.TabIndex = 4;
            this.custLabel.Text = "Customer";
            // 
            // deskLabel
            // 
            this.deskLabel.AutoSize = true;
            this.deskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskLabel.Location = new System.Drawing.Point(13, 65);
            this.deskLabel.Name = "deskLabel";
            this.deskLabel.Size = new System.Drawing.Size(44, 17);
            this.deskLabel.TabIndex = 12;
            this.deskLabel.Text = "Desk";
            // 
            // deskMaterialLabel
            // 
            this.deskMaterialLabel.AutoSize = true;
            this.deskMaterialLabel.Location = new System.Drawing.Point(13, 169);
            this.deskMaterialLabel.Name = "deskMaterialLabel";
            this.deskMaterialLabel.Size = new System.Drawing.Size(47, 13);
            this.deskMaterialLabel.TabIndex = 6;
            this.deskMaterialLabel.Text = "Material:";
            // 
            // deskDrawersLabel
            // 
            this.deskDrawersLabel.AutoSize = true;
            this.deskDrawersLabel.Location = new System.Drawing.Point(13, 144);
            this.deskDrawersLabel.Name = "deskDrawersLabel";
            this.deskDrawersLabel.Size = new System.Drawing.Size(49, 13);
            this.deskDrawersLabel.TabIndex = 7;
            this.deskDrawersLabel.Text = "Drawers:";
            // 
            // deskDepthLabel
            // 
            this.deskDepthLabel.AutoSize = true;
            this.deskDepthLabel.Location = new System.Drawing.Point(13, 119);
            this.deskDepthLabel.Name = "deskDepthLabel";
            this.deskDepthLabel.Size = new System.Drawing.Size(39, 13);
            this.deskDepthLabel.TabIndex = 8;
            this.deskDepthLabel.Text = "Depth:";
            // 
            // deskWidthLabel
            // 
            this.deskWidthLabel.AutoSize = true;
            this.deskWidthLabel.Location = new System.Drawing.Point(13, 94);
            this.deskWidthLabel.Name = "deskWidthLabel";
            this.deskWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.deskWidthLabel.TabIndex = 9;
            this.deskWidthLabel.Text = "Width:";
            // 
            // deskWidthText
            // 
            this.deskWidthText.Location = new System.Drawing.Point(69, 90);
            this.deskWidthText.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.deskWidthText.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.deskWidthText.Name = "deskWidthText";
            this.deskWidthText.Size = new System.Drawing.Size(39, 20);
            this.deskWidthText.TabIndex = 2;
            this.deskWidthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deskWidthText.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.deskWidthText.Validating += new System.ComponentModel.CancelEventHandler(this.deskWidthText_Validating);
            this.deskWidthText.Validated += new System.EventHandler(this.deskWidthText_Validated);
            // 
            // deskDepthText
            // 
            this.deskDepthText.Location = new System.Drawing.Point(69, 115);
            this.deskDepthText.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.deskDepthText.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.deskDepthText.Name = "deskDepthText";
            this.deskDepthText.Size = new System.Drawing.Size(39, 20);
            this.deskDepthText.TabIndex = 3;
            this.deskDepthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deskDepthText.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.deskDepthText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deskDepthText_KeyPress);
            // 
            // deskDrawersText
            // 
            this.deskDrawersText.Location = new System.Drawing.Point(69, 141);
            this.deskDrawersText.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.deskDrawersText.Name = "deskDrawersText";
            this.deskDrawersText.Size = new System.Drawing.Size(39, 20);
            this.deskDrawersText.TabIndex = 4;
            this.deskDrawersText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushLabel.Location = new System.Drawing.Point(13, 199);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(92, 17);
            this.rushLabel.TabIndex = 18;
            this.rushLabel.Text = "Rush Order";
            // 
            // rushDaysLabel
            // 
            this.rushDaysLabel.AutoSize = true;
            this.rushDaysLabel.Location = new System.Drawing.Point(13, 228);
            this.rushDaysLabel.Name = "rushDaysLabel";
            this.rushDaysLabel.Size = new System.Drawing.Size(34, 13);
            this.rushDaysLabel.TabIndex = 17;
            this.rushDaysLabel.Text = "Days:";
            // 
            // threeDayRadio
            // 
            this.threeDayRadio.AutoSize = true;
            this.threeDayRadio.Location = new System.Drawing.Point(69, 226);
            this.threeDayRadio.Name = "threeDayRadio";
            this.threeDayRadio.Size = new System.Drawing.Size(31, 17);
            this.threeDayRadio.TabIndex = 6;
            this.threeDayRadio.Text = "3";
            this.threeDayRadio.UseVisualStyleBackColor = true;
            // 
            // fiveDayRadio
            // 
            this.fiveDayRadio.AutoSize = true;
            this.fiveDayRadio.Location = new System.Drawing.Point(69, 249);
            this.fiveDayRadio.Name = "fiveDayRadio";
            this.fiveDayRadio.Size = new System.Drawing.Size(31, 17);
            this.fiveDayRadio.TabIndex = 7;
            this.fiveDayRadio.Text = "5";
            this.fiveDayRadio.UseVisualStyleBackColor = true;
            // 
            // sevenDayRadio
            // 
            this.sevenDayRadio.AutoSize = true;
            this.sevenDayRadio.Location = new System.Drawing.Point(69, 272);
            this.sevenDayRadio.Name = "sevenDayRadio";
            this.sevenDayRadio.Size = new System.Drawing.Size(31, 17);
            this.sevenDayRadio.TabIndex = 8;
            this.sevenDayRadio.Text = "7";
            this.sevenDayRadio.UseVisualStyleBackColor = true;
            // 
            // fourteenDayRadio
            // 
            this.fourteenDayRadio.AutoSize = true;
            this.fourteenDayRadio.Checked = true;
            this.fourteenDayRadio.Location = new System.Drawing.Point(69, 295);
            this.fourteenDayRadio.Name = "fourteenDayRadio";
            this.fourteenDayRadio.Size = new System.Drawing.Size(92, 17);
            this.fourteenDayRadio.TabIndex = 9;
            this.fourteenDayRadio.TabStop = true;
            this.fourteenDayRadio.Text = "Free Standard";
            this.fourteenDayRadio.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // deskMaterialComboBox
            // 
            this.deskMaterialComboBox.FormattingEnabled = true;
            this.deskMaterialComboBox.Location = new System.Drawing.Point(69, 166);
            this.deskMaterialComboBox.Name = "deskMaterialComboBox";
            this.deskMaterialComboBox.Size = new System.Drawing.Size(93, 21);
            this.deskMaterialComboBox.TabIndex = 5;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 374);
            this.Controls.Add(this.deskMaterialComboBox);
            this.Controls.Add(this.fourteenDayRadio);
            this.Controls.Add(this.sevenDayRadio);
            this.Controls.Add(this.fiveDayRadio);
            this.Controls.Add(this.threeDayRadio);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.rushDaysLabel);
            this.Controls.Add(this.deskDrawersText);
            this.Controls.Add(this.deskDepthText);
            this.Controls.Add(this.deskWidthText);
            this.Controls.Add(this.deskLabel);
            this.Controls.Add(this.deskMaterialLabel);
            this.Controls.Add(this.deskDrawersLabel);
            this.Controls.Add(this.deskDepthLabel);
            this.Controls.Add(this.deskWidthLabel);
            this.Controls.Add(this.custLabel);
            this.Controls.Add(this.custNameText);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.cancelQuoteButton);
            this.Controls.Add(this.submitQuoteButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskWidthText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepthText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawersText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitQuoteButton;
        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.TextBox custNameText;
        private System.Windows.Forms.Label custLabel;
        private System.Windows.Forms.Label deskLabel;
        private System.Windows.Forms.Label deskMaterialLabel;
        private System.Windows.Forms.Label deskDrawersLabel;
        private System.Windows.Forms.Label deskDepthLabel;
        private System.Windows.Forms.Label deskWidthLabel;
        private System.Windows.Forms.NumericUpDown deskWidthText;
        private System.Windows.Forms.NumericUpDown deskDepthText;
        private System.Windows.Forms.NumericUpDown deskDrawersText;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.Label rushDaysLabel;
        private System.Windows.Forms.RadioButton threeDayRadio;
        private System.Windows.Forms.RadioButton fiveDayRadio;
        private System.Windows.Forms.RadioButton sevenDayRadio;
        private System.Windows.Forms.RadioButton fourteenDayRadio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox deskMaterialComboBox;
    }
}