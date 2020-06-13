using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaSystem;

namespace CinemaGUI
{
    public partial class Form1 : Form
    {
        private TimeSpan theaterOneTime, theaterTwoTime;
        private Theater theaterOne, theaterTwo;
        private Movie movieOne, movieTwo;
        private DisplayBoard displayBoardOne;
        public Form1()
        {
            InitializeComponent();
            InitializeItems();
            HideComponents();
        }

        private void HideComponents()
        {
            viewTheaters1.Hide();
            createCustomers1.Hide();
            showTransactions1.Hide();
            showMovies1.Hide();
            showSeats1.Hide();
            addTheaters1.Hide();
            addMovie1.Hide();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewTheaters1.Show();
            viewTheaters1.BringToFront();

            viewTheaters1.ShowTheaters(displayBoardOne.GetTheaters);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            showTransactions1.Show();
            showTransactions1.BringToFront();

            showTransactions1.ShowTransaction(displayBoardOne.GetReceipts);

            
        }

        private void viewTheaters1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            createCustomers1.DisplayBoard = displayBoardOne;
            createCustomers1.Show();
            createCustomers1.BringToFront();
        }

        private void createCustomers1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            showMovies1.Show();
            showMovies1.BringToFront();
            showMovies1.ShowMovie(displayBoardOne.GetMovies);
        }

        private void showMovies1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSeats1.Show();
            showSeats1.BringToFront();
            showSeats1.DisplayBoard = displayBoardOne;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addTheaters1.Show();
            addTheaters1.BringToFront();
            addTheaters1.DisplayBoard = displayBoardOne;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayBoardOne.GetMovies.Clear();
            displayBoardOne.GetTheaters.Clear();
            displayBoardOne.GetTheaters.Clear();
            label2.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            addMovie1.Show();
            addMovie1.BringToFront();
            addMovie1.DisplayBoard = displayBoardOne;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void InitializeItems()
        {
            theaterOneTime = new TimeSpan(15, 30, 0);
            theaterTwoTime = new TimeSpan(20, 45, 0);

            theaterOne = new Theater("Orchid", theaterOneTime);
            theaterTwo = new Theater("Rose", theaterTwoTime);

            movieOne = new Movie("Avengers Endgame", 3, "Superheroes in action", "Chris Hemsworth");
            movieTwo = new Movie("Birdbox", 1, "Don't make a sound", "Sandra Bullock");

            theaterOne.Movie = movieOne;
            theaterTwo.Movie = movieTwo;

            displayBoardOne = new DisplayBoard();
            displayBoardOne.AddTheaters(theaterOne);
            displayBoardOne.AddTheaters(theaterTwo);
            displayBoardOne.AddMovies(movieOne);
            displayBoardOne.AddMovies(movieTwo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
