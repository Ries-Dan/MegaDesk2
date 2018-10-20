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
using System.Runtime.Serialization.Json;
using System.Xml;
using Newtonsoft.Json;

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
            int numQuotes = 1;
            string filePath = @"quotes.json";
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    DeskQuote jsonQuote = JsonConvert.DeserializeObject<DeskQuote>(line);
                    viewResultsList.Items.Add(new ListViewItem(new[] { numQuotes.ToString(), jsonQuote.getCustName(), jsonQuote.getQuoteDate().ToString(), jsonQuote.Desk.Width.ToString(), jsonQuote.Desk.Depth.ToString(),
                                          jsonQuote.Desk.Drawers.ToString(), jsonQuote.Desk.Material.ToString(), jsonQuote.getRushDays().ToString(), jsonQuote.getTotalQuote().ToString() }));
                    numQuotes++;
                }
            }
        }
    }
}

/*
 * 
 */
