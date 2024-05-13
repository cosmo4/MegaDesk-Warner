using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Warner
{
    public class Desk
    {
        public int width {  get; set; }
        public int depth { get; set; }
        public int drawers { get; set; }
        public string material { get; set; }



        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;

        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

        public Desk(int width, int depth, int drawers, string material) 
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = material;

        }
    }
}
