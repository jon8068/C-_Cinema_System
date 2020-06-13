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
    public partial class AddTheaters : UserControl
    {
        private DisplayBoard displayBoard;
        public AddTheaters()
        {
            InitializeComponent();
            HideComponents();
        }
        private void HideComponents()
        {
            label5.Hide();
            label6.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public DisplayBoard DisplayBoard
        {
            set
            {
                displayBoard = value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            this.Parent.Show();
        }

        private void AddTheaters_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool addTheater = false;
            try
            {
                TimeSpan theaterTime = TimeSpan.Parse(textBox4.Text);

                Theater tempTheater = new Theater(textBox1.Text, theaterTime);
                foreach (Movie m in displayBoard.GetMovies)
                {
                    if (m.GetName.ToLower().Equals(textBox2.Text.ToLower()))
                    {
                        tempTheater.Movie = m;
                        displayBoard.AddTheaters(tempTheater);
                        label5.Show();
                        label5.BringToFront();
                        addTheater = true;
                    }
                }
            }
            catch
            {

            }
            finally
            {

                if (!addTheater)
                {
                    label6.Show();
                    label6.BringToFront();
                }

                textBox1.Text = textBox2.Text = textBox4.Text = "";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
