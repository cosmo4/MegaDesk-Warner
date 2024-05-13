using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk_Warner
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show();
            Close();
        }

        private void SubmitNewQuote_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk(
                (int)DeskWidth.Value,
                (int)DeskDepth.Value,
                (int)Drawers.Value,
                SurfaceMaterial.SelectedItem.ToString()
            );

            DeskQuote deskQuote = new DeskQuote(
                CustomerNameTB.Text,
                RushOrderOptions.SelectedItem.ToString(),
                DateTime.Now.ToString("yyyy-MM-dd"),
                desk
            );

            DisplayQuote displayQuoteForm = new DisplayQuote(desk, deskQuote);
            displayQuoteForm.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DeskWidth_Validating(object sender, CancelEventArgs e)
        {
            if (DeskWidth.Value < Desk.MINWIDTH || DeskWidth.Value > Desk.MAXWIDTH)
            {
                MessageBox.Show("Desk width MUST be between 24 and 96 inches!");
                DeskWidth.Focus();
            }
        }

        private void DeskDepth_Validating(object sender, CancelEventArgs e)
        {
            if (DeskDepth.Value < Desk.MINDEPTH || DeskDepth.Value > Desk.MAXDEPTH)
            {
                MessageBox.Show("Desk depth MUST be between 12 and 48 inches!");
                DeskDepth.Focus();
            }
        }

        private void Drawers_Validating(object sender, CancelEventArgs e)
        {
            if (Drawers.Value < Desk.MINDRAWERS || Drawers.Value > Desk.MAXDRAWERS)
            {
                MessageBox.Show("Number of Drawers MUST be between 0 and 7");
            }
        }

        
    }
}
