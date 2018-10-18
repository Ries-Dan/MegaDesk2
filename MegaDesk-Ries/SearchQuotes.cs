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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotesCloseButton_Click(object sender, EventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }

        private void DrawColumns()
        {
            // Create list columns with headers
            searchResultsList.Columns.Add("#", 30, HorizontalAlignment.Center);
            searchResultsList.Columns.Add("Name", 160, HorizontalAlignment.Center);
            searchResultsList.Columns.Add("Date", 180, HorizontalAlignment.Center);
            searchResultsList.Columns.Add("Width", 70, HorizontalAlignment.Center);
            searchResultsList.Columns.Add("Depth", 70, HorizontalAlignment.Center);
            searchResultsList.Columns.Add("Drawers", 70, HorizontalAlignment.Center);
            searchResultsList.Columns.Add("Material", 120, HorizontalAlignment.Center);
            searchResultsList.Columns.Add("Days", 50, HorizontalAlignment.Center);
            searchResultsList.Columns.Add("Total", 100, HorizontalAlignment.Center);
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            // Populate material search combo box with eNum
            materialSearchComboBox.DataSource = Enum.GetNames(typeof(DeskMaterial));
            DrawColumns();
        }

        private void SearchByMaterialButton_Click(object sender, EventArgs e)
        {
            // Clear the previous listing, if any
            searchResultsList.Clear();
            DrawColumns();
            // Read search request as a string
            string MaterialFilter = materialSearchComboBox.SelectedItem.ToString();

            // Open file and display contents organized
            using (StreamReader sr = new StreamReader(@"quotes.txt"))
            {
                int numQuotes = 0;
                while (!sr.EndOfStream)
                {
                    // Designate each value seperated by a comma character
                    string[] fieldvalue = sr.ReadLine().Split(',');
                    // if the  fieldvalue matches what is selected in the search, display and add quote
                    if (fieldvalue[5] == MaterialFilter)
                    {
                        numQuotes++;
                        searchResultsList.Items.Add(new ListViewItem(new[] { numQuotes.ToString(), fieldvalue[0], fieldvalue[1],
                        fieldvalue[2], fieldvalue[3], fieldvalue[4], fieldvalue[5], fieldvalue[6], "$" + fieldvalue[7]}));
                    }
                }
            }
        }
    }
}
