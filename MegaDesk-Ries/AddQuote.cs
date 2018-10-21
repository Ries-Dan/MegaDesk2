using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk_Ries;
using System.IO;
using System.Runtime.Serialization.Json;

namespace MegaDesk_Ries
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            // Use List to populate the material box with available options from declared eNum
            List<DeskMaterial> DeskMaterialList = Enum.GetValues(typeof(DeskMaterial)).Cast<DeskMaterial>().ToList();
            deskMaterialComboBox.DataSource = DeskMaterialList;
        }

        private void CloseQuoteButton_Click(object sender, EventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            this.ActiveControl = custNameText;
        }

        /*********************************************************************************************
         * Submit Quote
         * This button will validate all data entered, and prompt user to enter valid data if there is
         * an error.
         * If the data is valid, the method will commit all variavles to the DeskQuote object to store
         * ******************************************************************************************/
        private void SubmitQuoteButton_Click(object sender, EventArgs e)
        {
            // Create a new desk and populate it with the selected values
            Desk desk = new Desk();
            desk.Width = Convert.ToInt32(Math.Round(deskWidthText.Value, 0));
            desk.Depth = Convert.ToInt32(Math.Round(deskDepthText.Value, 0));
            desk.Drawers = Convert.ToInt32(Math.Round(deskDrawersText.Value, 0));
            desk.Material = (DeskMaterial)deskMaterialComboBox.SelectedValue;

            // Create the customer and rushDays preference
            string custName = custNameText.Text;
            int rushDays = 14;

            // Determine if default rush days is changed
            if (threeDayRadio.Checked)
                rushDays = 3;
            if (fiveDayRadio.Checked)
                rushDays = 5;
            if (sevenDayRadio.Checked)
                rushDays = 7;

            // Set the quote date to now
            DateTime quoteDate = DateTime.Now;

            // Create the quote object
            DeskQuote newQuote = new DeskQuote(custName, rushDays, quoteDate, desk);

            // Calculate quote total
            int totalQuote = calcuateQuote(desk);
            newQuote.setTotalQuote(totalQuote);

            // JSON Serialization for storing in a file
            string filePath = @"quotes.json";
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DeskQuote));
            ser.WriteObject(stream1, newQuote);
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath)) { }
            }

            using (StreamWriter sw = File.AppendText(filePath))
            {
                stream1.Position = 0;
                StreamReader sr = new StreamReader(stream1);
                sw.WriteLine(sr.ReadToEnd());
            }

            // Quote file is created at this point. Display the quote in a new form
            DisplayQuote displayQuoteView = new DisplayQuote(newQuote);
            displayQuoteView.Tag = this;
            displayQuoteView.Show(this);
        }

        private void DeskWidthText_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if(!ValidWidth(int.Parse(deskWidthText.Text), out errorMsg))
            {
                e.Cancel = true;
                deskWidthText.Select();

                this.errorProvider1.SetError(deskWidthText, errorMsg);
            }
        }

        private bool ValidWidth(int width, out string errorMessage)
        {
            // validate width
            if (width < 24 || width > 96)
            {
                // ERROR
                errorMessage = "Width must be between 24 and 96";
                return false;
            }
            // Width is valid
            errorMessage = "";
            return true;
        }

        private void DeskWidthText_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(deskWidthText, "");
        }

        private void deskDepthText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            // Valid input
            {
                ;
            }
        }

         // methods
        public int calcuateQuote(Desk desk)
        {
            // Declare and initialize quote variable with base cost
            int totalQuote = BASE_DESK_PRICE;

            // Determine desk area cost if any
            if (desk.getArea() > DESK_AREA_THRESHOLD)
                totalQuote += desk.getArea() * DESK_AREA_PRICE;

            // Determine drawer cost
            totalQuote += desk.Drawers * DRAWER_PRICE;

            // Determine material cost using enum values
            totalQuote += (int)desk.Material;

            // Read rushOrderPrices.txt into 2D array to refer to for costs
            int [,] rushOrderValues = new int[3, 3];

            string cFile = @"rushOrderPrices.txt";
            if (!File.Exists(cFile))
            {
                Console.WriteLine("rushorderPrices.txt does not exist!");
                this.Close();
            }

            // Read the file into a string called input
            string input = File.ReadAllLines();

            // Nested 'for' loop to populate 2D array with input
            for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        rushOrderValues[i, j] = int.Parse(input[j + (3*i)]);
                }


            // Determine rush order cost by rush days - 14 days has no additional cost
            switch (getRushDays())
            {
                

                // 3 day rush order
                case 3:
                    // desk area less than 1000
                    if (desk.getArea() < 1000)
                        totalQuote += rushOrderValues[0,0];
                    // desk area 1000 to 2000
                    else if (desk.getArea() >= 1000 && desk.getArea() <= 2000)
                        totalQuote += rushOrderValues[0,1];
                    // desk area greater than 2000
                    else
                        totalQuote += rushOrderValues[0,2];
                    break;
                // 5 day rush order
                case 5:
                    // desk area less than 1000
                    if (desk.getArea() < 1000)
                        totalQuote += rushOrderValues[1,0];
                    // desk area 1000 to 2000
                    else if (desk.getArea() >= 1000 && desk.getArea() <= 2000)
                        totalQuote += rushOrderValues[1,1];
                    // desk area greater than 2000
                    else
                        totalQuote += rushOrderValues[1,2];
                    break;
                // 7 day rush order
                case 7:
                    // desk area less than 1000
                    if (desk.getArea() < 1000)
                        totalQuote += rushOrderValues[2,0];
                    // desk area 1000 to 2000
                    else if (desk.getArea() >= 1000 && desk.getArea() <= 2000)
                        totalQuote += rushOrderValues[2,1];
                    // desk area greater than 2000
                    else
                        totalQuote += rushOrderValues[2,2];
                    break;
            }


            // total desk quote should be calculated at this point. Return the quote price
            return totalQuote;
        }
    }
}
