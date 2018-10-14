namespace MegaDesk_Ries
{
    partial class ViewAllQuotes
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
            this.ViewAllQuotesCloseButton = new System.Windows.Forms.Button();
            this.viewResultsList = new System.Windows.Forms.ListView();
            this.ViewAllQuotesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewAllQuotesCloseButton
            // 
            this.ViewAllQuotesCloseButton.Location = new System.Drawing.Point(21, 395);
            this.ViewAllQuotesCloseButton.Name = "ViewAllQuotesCloseButton";
            this.ViewAllQuotesCloseButton.Size = new System.Drawing.Size(75, 23);
            this.ViewAllQuotesCloseButton.TabIndex = 0;
            this.ViewAllQuotesCloseButton.Text = "Close";
            this.ViewAllQuotesCloseButton.UseVisualStyleBackColor = true;
            this.ViewAllQuotesCloseButton.Click += new System.EventHandler(this.viewAllQuotesCancelButton_Click);
            // 
            // viewResultsList
            // 
            this.viewResultsList.Location = new System.Drawing.Point(21, 49);
            this.viewResultsList.Name = "viewResultsList";
            this.viewResultsList.Size = new System.Drawing.Size(885, 337);
            this.viewResultsList.TabIndex = 4;
            this.viewResultsList.UseCompatibleStateImageBehavior = false;
            this.viewResultsList.View = System.Windows.Forms.View.Details;
            // 
            // ViewAllQuotesLabel
            // 
            this.ViewAllQuotesLabel.AutoSize = true;
            this.ViewAllQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllQuotesLabel.Location = new System.Drawing.Point(21, 21);
            this.ViewAllQuotesLabel.Name = "ViewAllQuotesLabel";
            this.ViewAllQuotesLabel.Size = new System.Drawing.Size(154, 20);
            this.ViewAllQuotesLabel.TabIndex = 5;
            this.ViewAllQuotesLabel.Text = "All Quotes On File";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 427);
            this.Controls.Add(this.ViewAllQuotesLabel);
            this.Controls.Add(this.viewResultsList);
            this.Controls.Add(this.ViewAllQuotesCloseButton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewAllQuotesCloseButton;
        private System.Windows.Forms.ListView viewResultsList;
        private System.Windows.Forms.Label ViewAllQuotesLabel;
    }
}