﻿using System;
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

        public void ShowMovie(List<Theater> theaterList)
        {
            for (int i = 0; i < theaterList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = theaterList.ElementAt(i).GetMovie.GetName;
                dataGridView1.Rows[i].Cells[1].Value = theaterList.ElementAt(i).GetMovie.GetCategory.ToString();
                dataGridView1.Rows[i].Cells[2].Value = theaterList.ElementAt(i).GetMovie.GetStarring.ToString();
                dataGridView1.Rows[i].Cells[3].Value = theaterList.ElementAt(i).GetMovie.GetDesc;
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
    }
}
