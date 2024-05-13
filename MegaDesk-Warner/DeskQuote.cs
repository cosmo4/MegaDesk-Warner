using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Warner
{
    public class DeskQuote
    {
        public string customerName {  get; set; }
        public string rushDays {  get; set; }
        public string quoteDate { get; set; }
        public Desk Desk { get; set; }


        public DeskQuote(string customerName, string rushDays, string quoteDate, Desk desk) 
        { 
            this.customerName = customerName;
            this.rushDays = rushDays;
            this.quoteDate = quoteDate;
            this.Desk = desk;
        
        }
    }
}
