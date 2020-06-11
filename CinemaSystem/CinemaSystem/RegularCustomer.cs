using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    public class RegularCustomer : Customer
    {

        public RegularCustomer(string name) : base(name)
        {
            
        }
        public override void BuyTickets()
        {
            //Getting the non booked seats
            List<Seat> tempSeats = new List<Seat>();
            //List the bought seats by the customers for receipt
            List<Seat> boughtSeats = new List<Seat>();
            //Getting the theater number
            int theaterNumber = _displayBoard.GetTheaters.Count + 1;
            
            List<int> indexSeat = new List<int>();

            Random random = new Random();
            int randomNumber = random.Next(1, theaterNumber);
            

            //Chooses the theater
            Console.WriteLine(GetName + " chooses theater " + _displayBoard.GetTheaters.ElementAt(randomNumber-1).GetName + Environment.NewLine);
            //Get Theater Seats
            tempSeats = _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetSeat;

            //How many tickets do you want to buy
            int randomTickets = random.Next(1, 16);

            //Randomized which seats you want to buy
            for(int i = 0; i < randomTickets; i++)
            {
                int randomSeat;
                while (true)
                {
                    randomSeat = random.Next(1, 16);
                    if (!indexSeat.Contains(randomSeat)) break;
                }
                indexSeat.Add(randomSeat);
            }

            for(int i = 0; i < indexSeat.Count; i++)
            {
                //Booking the seat
                if (tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetStatus)
                {
                    continue;
                }
                else
                {
                    _displayBoard.GetTheaters.ElementAt(randomNumber - 1).BookSeats((tempSeats.ElementAt(indexSeat.ElementAt(i) - 1)));
                    Console.WriteLine(GetName + " chooses seat number " + tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetRow + tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetColumn);
                    //Add list of bought seats
                    boughtSeats.Add(tempSeats.ElementAt(indexSeat.ElementAt(i) - 1));
                }
            }

            if (boughtSeats.Any())
            {
                //Display bought seats
                _displayBoard.GetTheaters.ElementAt(randomNumber - 1).ShowSeats();

                _receipt = new Receipt(this, _displayBoard.GetTheaters.ElementAt(randomNumber - 1), boughtSeats);
                //Calculate total price
                _receipt.CalculateTotalPrice(boughtSeats);
                //Get the full description of the receipt
                Console.WriteLine(_receipt.GetFullDescription());
            } else
            {
                Console.WriteLine(GetName + " didn't like any of the seats, so " + GetName + " went home.");
            }
        }
    }
}
