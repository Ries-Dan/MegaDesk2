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
    }
}


