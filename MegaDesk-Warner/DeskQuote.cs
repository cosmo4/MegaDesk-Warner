using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Warner
{
    internal class DeskQuote
    {
        public string customerName {  get; set; }
        public int rushDays {  get; set; }
        public string quoteDate { get; set; }
        public Desk Desk { get; set; }



        public DeskQuote() 
        { 
        
        }
    }
}
