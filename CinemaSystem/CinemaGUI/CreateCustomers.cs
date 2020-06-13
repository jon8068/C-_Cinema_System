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
    public partial class CreateCustomers : UserControl
    {
        DisplayBoard displayBoard = new DisplayBoard();
        public CreateCustomers()
        {
            InitializeComponent();
            HideElements();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegularCustomer customer = new RegularCustomer(textBox1.Text);
            customer.DisplayBoard = displayBoard;
            textBox2.Text = customer.BuyTickets();
            CleanTextboxes();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
        }
        public DisplayBoard DisplayBoard
        {
            set
            {
               displayBoard = value;
            }
        }

        private void CreateCustomers_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loner customer = new Loner(textBox1.Text);
            customer.DisplayBoard = displayBoard;
            textBox2.Text = customer.BuyTickets();
            CleanTextboxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IndecisiveCustomer customer = new IndecisiveCustomer(textBox1.Text);
            customer.DisplayBoard = displayBoard;
            textBox2.Text = customer.BuyTickets();
            CleanTextboxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Show();
            textBox3.Show();
            label5.Show();
            button4.Hide();
        }

        private void HideElements()
        {
            label4.Hide();
            textBox3.Hide();
            label5.Hide();
            button4.Show();
        }
        private void CleanTextboxes()
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CelebrityFan customer = new CelebrityFan(textBox1.Text, textBox3.Text);
            customer.DisplayBoard = displayBoard;
            textBox2.Text = customer.BuyTickets();
            CleanTextboxes();
            HideElements();
        }
    }
}
