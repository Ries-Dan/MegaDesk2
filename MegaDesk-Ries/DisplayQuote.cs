using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Ries
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote newQuote)
        {
            InitializeComponent();
            initializeFields(newQuote);
        }

        private void initializeFields(DeskQuote newQuote)
        {
            // Populate fields with newQuote data
            quoteNameLabel.Text = newQuote.getCustName();
            quoteDateLabel.Text = newQuote.getQuoteDate().ToString("dd MMM yyyy");
            quoteWidthLabel.Text = newQuote.Desk.Width.ToString();
            quoteDepthLabel.Text = newQuote.Desk.Depth.ToString();
            quoteDrawersLabel.Text = newQuote.Desk.Drawers.ToString();
            quoteMaterialLabel.Text = newQuote.Desk.Material.ToString();
            quoteRushDaysLabel.Text = newQuote.getRushDays().ToString();
            quoteTotalQuoteLabel.Text = "$" + newQuote.getTotalQuote().ToString();
        }

        private void submitQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuView = new MainMenu();
            mainMenuView.Tag = this;
            mainMenuView.Show(this);
            Close();
        }
    }
}
