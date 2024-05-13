using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Warner
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;
        private Desk desk;
        public DisplayQuote(Desk desk, DeskQuote deskQuote)
        {
            InitializeComponent();
            this.deskQuote = deskQuote;
            this.desk = desk;

            widthLabel.Text = $"Width: {desk.width} inches";
            depthLabel.Text = $"Depth: {desk.depth} inches";
            drawersLabel.Text = $"Drawers: {desk.drawers}";
            materialLabel.Text = $"Material: {desk.material}";
            rushDaysLabel.Text = $"Rush Days: {deskQuote.rushDays}";

            Calculate();
        }

        private void Calculate()
        {

            int surfaceArea = desk.width * desk.depth;

            decimal totalCost = 200;

            if (surfaceArea > 1000)
            {
                totalCost += (surfaceArea - 1000) * 1;
            }

            totalCost += desk.drawers * 50;


            switch (desk.material)
            {
                case "Oak":
                    totalCost += 200;
                    break;
                case "Laminate":
                    totalCost += 100;
                    break;
                case "Pine":
                    totalCost += 50;
                    break;
                case "Rosewood":
                    totalCost += 300;
                    break;
                case "Veneer":
                    totalCost += 125;
                    break;
                default:

                    break;
            }

            switch (deskQuote.rushDays)
            {
                case "3 Day":
                    if (surfaceArea < 1000)
                    {
                        totalCost += 60;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        totalCost += 70;
                    }
                    else if (surfaceArea > 2000)
                    {
                        totalCost += 80;
                    }
                    break;
                case "5 Day":
                    if (surfaceArea < 1000)
                    {
                        totalCost += 40;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        totalCost += 50;
                    }
                    else if (surfaceArea > 2000)
                    {
                        totalCost += 60;
                    }
                    break;
                case "7 Day":
                    if (surfaceArea < 1000)
                    {
                        totalCost += 30;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        totalCost += 35;
                    }
                    else if (surfaceArea > 2000)
                    {
                        totalCost += 40;
                    }
                    break;
                default:
                    break;
            }

            costLabel.Text = $"Total Cost: {totalCost:C}";
        }


        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show();
            Close();
        }
    }
}
