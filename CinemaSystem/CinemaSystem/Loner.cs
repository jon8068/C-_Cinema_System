using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    public class Loner : Customer
    {
        public Loner(string name) : base(name)
        {

        }
        public override string BuyTickets()
        {
            Random random = new Random();
            //Getting the non booked seats
            List<Seat> tempSeats = new List<Seat>();
            //List the bought seats by the customers for receipt

            int seatNumber = 0;
            int seatNumber2;
            int randomNumber = 1;

            //show theater names and details
            for (int i = 0; i < _displayBoard.GetTheaters.Count; i++)
            {
                seatNumber2 = 0;
                //Selecting the most vacant seats
                foreach(Seat s in _displayBoard.GetTheaters.ElementAt(i).GetSeat)
                {
                    if (!s.GetStatus)
                    {
                        seatNumber2++;
                    }
                }
                if(seatNumber2 > seatNumber)
                {
                    seatNumber = seatNumber2;
                    randomNumber = i+1;
                }
            }

            //Chooses the theater
            _returnString += GetName + " chooses theater " + _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetName + Environment.NewLine;

            GetSeats(tempSeats, randomNumber);
            
            return _returnString;
        }
    }
}
