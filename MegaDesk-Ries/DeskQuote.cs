using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace MegaDesk_Ries
{
    [DataContract]
    public class DeskQuote
    {
        // variables
        [DataMember]
        private string   CustName;
        [DataMember]
        private int      RushDays;
        [DataMember]
        private DateTime QuoteDate;
        [DataMember]
        private int      TotalQuote;
        [DataMember]
        public Desk      Desk;

        // constants
        public const int BASE_DESK_PRICE     = 200;
        public const int DESK_AREA_THRESHOLD = 1000;
        public const int DESK_AREA_PRICE     = 1;
        public const int DRAWER_PRICE        = 50;

        // constructors
        public DeskQuote()
        {

        }

        public DeskQuote(string CustName, int rushDays, DateTime quoteDate, Desk desk)
        {
            this.CustName = CustName;
            this.RushDays = rushDays;
            this.QuoteDate = quoteDate;
            this.Desk = desk;
        }

        // getters and setters
        public string getCustName()
        {
            return this.CustName;
        }

        public void setCustName(string custName)
        {
            this.CustName = custName;
        }

        public int getRushDays()
        {
            return this.RushDays;
        }

        public void setRushDays(int rushDays)
        {
            this.RushDays = rushDays;
        }

        public DateTime getQuoteDate()
        {
            return this.QuoteDate;
        }

        public void setQuoteDate(DateTime quoteDate)
        {
            this.QuoteDate = quoteDate;
        }

        public int getTotalQuote()
        {
            return this.TotalQuote;
        }

        public void setTotalQuote(int totalQuote)
        {
            this.TotalQuote = totalQuote;
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

            // Determine rush order cost by rush days - 14 days has no additional cost
            switch (getRushDays())
            {
                // 3 day rush order
                case 3:
                    // desk area less than 1000
                    if (desk.getArea() < 1000)
                        totalQuote += 60;
                    // desk area 1000 to 2000
                    else if (desk.getArea() >= 1000 && desk.getArea() <= 2000)
                        totalQuote += 70;
                    // desk area greater than 2000
                    else
                        totalQuote += 80;
                    break;
                // 5 day rush order
                case 5:
                    // desk area less than 1000
                    if (desk.getArea() < 1000)
                        totalQuote += 40;
                    // desk area 1000 to 2000
                    else if (desk.getArea() >= 1000 && desk.getArea() <= 2000)
                        totalQuote += 50;
                    // desk area greater than 2000
                    else
                        totalQuote += 60;
                    break;
                // 7 day rush order
                case 7:
                    // desk area less than 1000
                    if (desk.getArea() < 1000)
                        totalQuote += 30;
                    // desk area 1000 to 2000
                    else if (desk.getArea() >= 1000 && desk.getArea() <= 2000)
                        totalQuote += 35;
                    // desk area greater than 2000
                    else
                        totalQuote += 40;
                    break;
            }


            // total desk quote should be calculated at this point. Return the quote price
            return totalQuote;
        }
    }
}


