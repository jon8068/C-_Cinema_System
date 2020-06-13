using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaSystem;
using System.Windows.Forms;

namespace CinemaGUI
{
    public partial class ShowTransactions : UserControl
    {
        public ShowTransactions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ShowTransaction(List<Receipt> receiptsList)
        {
            for (int i = 0; i < receiptsList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = receiptsList.ElementAt(i).GetCustName;
                dataGridView1.Rows[i].Cells[1].Value = receiptsList.ElementAt(i).GetTheater.GetName;
                dataGridView1.Rows[i].Cells[2].Value = receiptsList.ElementAt(i).GetMovie.GetName;
                dataGridView1.Rows[i].Cells[3].Value = receiptsList.ElementAt(i).GetSeatName;
                dataGridView1.Rows[i].Cells[4].Value = receiptsList.ElementAt(i).GetTotalPrice;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataGridView1.Rows.Clear();
            this.Parent.Show();
        }
    }
}
