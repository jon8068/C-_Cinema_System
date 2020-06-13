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
        public override string BuyTickets()
        {
            //Getting the non booked seats
            List<Seat> tempSeats = new List<Seat>();

            //Getting the theater number
            int theaterNumber = _displayBoard.GetTheaters.Count + 1;

            Random random = new Random();
            int randomNumber = random.Next(1, theaterNumber);

            //Chooses the theater
            _returnString += GetName + " chooses theater " + _displayBoard.GetTheaters.ElementAt(randomNumber-1).GetName + Environment.NewLine;
            //Get Theater Seats
            GetSeats(tempSeats, randomNumber);
            
            return _returnString;
        }
    }
}
