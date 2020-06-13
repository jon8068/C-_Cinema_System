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
    public partial class ShowMovies : UserControl
    {
        public ShowMovies()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ShowMovie(List<Movie> movieList)
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = movieList.ElementAt(i).GetName;
                dataGridView1.Rows[i].Cells[1].Value = movieList.ElementAt(i).GetCategory.ToString();
                dataGridView1.Rows[i].Cells[2].Value = movieList.ElementAt(i).GetStarring.ToString();
                dataGridView1.Rows[i].Cells[3].Value = movieList.ElementAt(i).GetDesc;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataGridView1.Rows.Clear();
            this.Parent.Show();
        }

        private void ShowMovies_Load(object sender, EventArgs e)
        {

        }
    }
}
