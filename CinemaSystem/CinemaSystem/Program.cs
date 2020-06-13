using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan theaterOneTime = new TimeSpan(15, 30, 0);
            TimeSpan theaterTwoTime = new TimeSpan(20, 45, 0);

            Theater theaterOne = new Theater("Orchid", theaterOneTime);
            Theater theaterTwo = new Theater("Rose", theaterTwoTime);

            Movie movieOne = new Movie("Avengers Endgame", 3, "Superheroes in action",  "Chris Hemsworth");
            Movie movieTwo = new Movie("Birdbox", 1, "Don't make a sound",  "Sandra Bullock");

            theaterOne.Movie = movieOne;
            theaterTwo.Movie = movieTwo;

            DisplayBoard displayBoardOne = new DisplayBoard();
            displayBoardOne.AddTheaters(theaterOne);
            displayBoardOne.AddTheaters(theaterTwo);

            while (true) 
            {
                int menuChoice;

                Console.WriteLine("Welcome to the Cinema Simulator");
                Console.WriteLine("1. Show Theaters");
                Console.WriteLine("2. Create Customers");
                Console.WriteLine("0. Quit");

                menuChoice = Convert.ToInt32(Console.ReadLine());
                if(menuChoice == 1)
                {
                    //show theater names and details
                    foreach (Theater t in displayBoardOne.GetTheaters)
                    {
                        Console.WriteLine(displayBoardOne.ShowTheaters(t));
                    }
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine("Create Your Customer! Give Them a Name!");
                    string customerName = Console.ReadLine();

                    Console.WriteLine("Select Customer Type");
                    Console.WriteLine("1. Regular Customer");
                    Console.WriteLine("2. Loner Customer");
                    Console.WriteLine("3. Indecisive Customer");
                    Console.WriteLine("4. Celebrity Fan");


                    int custChoice = Convert.ToInt32(Console.ReadLine());

                    if (custChoice == 1)
                    {
                        RegularCustomer regularCustomer = new RegularCustomer(customerName);

                        regularCustomer.DisplayBoard = displayBoardOne;
                        regularCustomer.BuyTickets();
                    }
                    else if (custChoice == 2)
                    {
                        Loner lonerCustomer = new Loner(customerName);

                        lonerCustomer.DisplayBoard = displayBoardOne;
                        lonerCustomer.BuyTickets();
                        
                    } 
                    else if (custChoice == 3)
                    {
                        IndecisiveCustomer indecisiveCustomer = new IndecisiveCustomer(customerName);

                        indecisiveCustomer.DisplayBoard = displayBoardOne;
                        indecisiveCustomer.BuyTickets();
                    }
                    else if (custChoice == 4)
                    {
                        Console.WriteLine("Insert your idol: ");
                        string favorite = Console.ReadLine();
                        CelebrityFan celebrityFan = new CelebrityFan(customerName, favorite);
                        celebrityFan.DisplayBoard = displayBoardOne;
                        celebrityFan.BuyTickets();
                    } 
                    //else if (custChoice == 5)
                    //{
                    //    Console.WriteLine("Insert your favorite genre: ");
                    //    Console.WriteLine("1. Horror");
                    //    Console.WriteLine("2. Romance");
                    //    Console.WriteLine("3. Action");
                    //    Console.WriteLine("4. Animation");

                    //    int genreChoice = Convert.ToInt32(Console.ReadLine());
                    //    if(genreChoice == 1)
                    //    {
                    //        Customer c = new CategoryFans(customerName, genreChoice);
                    //    }
                    //}
                }
                Console.ReadLine();
            }
        }
    }
}
