namespace MegaDesk_Ries
{
    partial class SearchQuotes
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
            this.SearchQuotesCloseButton = new System.Windows.Forms.Button();
            this.SearchByMaterialButton = new System.Windows.Forms.Button();
            this.materialSearchComboBox = new System.Windows.Forms.ComboBox();
            this.searchResultsList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // SearchQuotesCloseButton
            // 
            this.SearchQuotesCloseButton.Location = new System.Drawing.Point(21, 395);
            this.SearchQuotesCloseButton.Name = "SearchQuotesCloseButton";
            this.SearchQuotesCloseButton.Size = new System.Drawing.Size(75, 23);
            this.SearchQuotesCloseButton.TabIndex = 0;
            this.SearchQuotesCloseButton.Text = "Close";
            this.SearchQuotesCloseButton.UseVisualStyleBackColor = true;
            this.SearchQuotesCloseButton.Click += new System.EventHandler(this.SearchQuotesCloseButton_Click);
            // 
            // SearchByMaterialButton
            // 
            this.SearchByMaterialButton.Location = new System.Drawing.Point(148, 20);
            this.SearchByMaterialButton.Name = "SearchByMaterialButton";
            this.SearchByMaterialButton.Size = new System.Drawing.Size(75, 23);
            this.SearchByMaterialButton.TabIndex = 1;
            this.SearchByMaterialButton.Text = "Search";
            this.SearchByMaterialButton.UseVisualStyleBackColor = true;
            this.SearchByMaterialButton.Click += new System.EventHandler(this.SearchByMaterialButton_Click);
            // 
            // materialSearchComboBox
            // 
            this.materialSearchComboBox.FormattingEnabled = true;
            this.materialSearchComboBox.Location = new System.Drawing.Point(21, 21);
            this.materialSearchComboBox.Name = "materialSearchComboBox";
            this.materialSearchComboBox.Size = new System.Drawing.Size(121, 21);
            this.materialSearchComboBox.TabIndex = 2;
            // 
            // searchResultsList
            // 
            this.searchResultsList.Location = new System.Drawing.Point(21, 49);
            this.searchResultsList.Name = "searchResultsList";
            this.searchResultsList.Size = new System.Drawing.Size(885, 337);
            this.searchResultsList.TabIndex = 3;
            this.searchResultsList.UseCompatibleStateImageBehavior = false;
            this.searchResultsList.View = System.Windows.Forms.View.Details;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 427);
            this.Controls.Add(this.searchResultsList);
            this.Controls.Add(this.materialSearchComboBox);
            this.Controls.Add(this.SearchByMaterialButton);
            this.Controls.Add(this.SearchQuotesCloseButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchQuotesCloseButton;
        private System.Windows.Forms.Button SearchByMaterialButton;
        private System.Windows.Forms.ComboBox materialSearchComboBox;
        private System.Windows.Forms.ListView searchResultsList;
    }
}