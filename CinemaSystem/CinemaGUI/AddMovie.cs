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
    public partial class AddMovie : UserControl
    {
        private DisplayBoard displayBoard;
        

        public AddMovie()
        {
            InitializeComponent();
            HideComponents();
        }
        private void HideComponents()
        {
            label10.Hide();
            label11.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Show();
            HideComponents();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideComponents();
            bool addTheater = false;
            try
            {
              
                Movie m = new Movie(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox4.Text, textBox3.Text);
                if (Convert.ToInt32(textBox2.Text) <= 4 || Convert.ToInt32(textBox2.Text) > 0)
                {
                    if (textBox1.Text.Trim().Equals("") || textBox2.Text.Trim().Equals("") || textBox3.Text.Trim().Equals("") || textBox4.Text.Trim().Equals(""))
                    {
                        return;
                    }
                    else
                    {
                        displayBoard.AddMovies(m);
                        addTheater = true;
                    }
                }
            }
            catch
            {

            }
            finally
            {
                if (addTheater)
                {
                    label10.Show();
                    label10.BringToFront();
                } else
                {
                    label11.Show();
                    label11.BringToFront();
                }

                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
        }

        public DisplayBoard DisplayBoard
        {
            set
            {
                displayBoard = value;
            }
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
