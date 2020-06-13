using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaSystem;

namespace CinemaGUI
{
    public partial class ShowSeats : UserControl
    {
        private DisplayBoard displayBoard;
        public ShowSeats()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < displayBoard.GetTheaters.Count; i++)
            {
                if (displayBoard.GetTheaters.ElementAt(i).GetName.ToLower().Equals(textBox1.Text.ToLower()))
                {
                    label3.Text = displayBoard.GetTheaters.ElementAt(i).ShowSeats();
                }
            }
        }
        public void ShowSeat()
        {

        }

        private void ShowSeats_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public DisplayBoard DisplayBoard
        {
            set
            {
                displayBoard = value;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Show();
        }
    }
}
