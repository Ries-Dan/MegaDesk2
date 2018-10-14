using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_Ries
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void viewAllQuotesCancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void DrawColumns()
        {
            // Create list columns with headers
            viewResultsList.Columns.Add("#", 30, HorizontalAlignment.Center);
            viewResultsList.Columns.Add("Name", 160, HorizontalAlignment.Center);
            viewResultsList.Columns.Add("Date", 180, HorizontalAlignment.Center);
            viewResultsList.Columns.Add("Width", 70, HorizontalAlignment.Center);
            viewResultsList.Columns.Add("Depth", 70, HorizontalAlignment.Center);
            viewResultsList.Columns.Add("Drawers", 70, HorizontalAlignment.Center);
            viewResultsList.Columns.Add("Material", 120, HorizontalAlignment.Center);
            viewResultsList.Columns.Add("Days", 50, HorizontalAlignment.Center);
            viewResultsList.Columns.Add("Total", 100, HorizontalAlignment.Center);
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            // Populate All Quotes from file
            DrawColumns();
            DisplayQuotes();
        }

        private void DisplayQuotes()
        {
            // Open file and display contents organized
            using (StreamReader sr = new StreamReader(@"quotes.txt"))
            {
                int numQuotes = 0;
                while (!sr.EndOfStream)
                {
                    // Designate each value seperated by a comma character
                    string[] fieldvalue = sr.ReadLine().Split(',');
                    numQuotes++;
                    viewResultsList.Items.Add(new ListViewItem(new[] { numQuotes.ToString(), fieldvalue[0], fieldvalue[1],
                    fieldvalue[2], fieldvalue[3], fieldvalue[4], fieldvalue[5], fieldvalue[6], "$" + fieldvalue[7]}));
                }
            }
        }
    }
}
