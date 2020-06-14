using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    /// <summary>
    /// Regular Customer will 
    /// randomly pick the theatre and seats.
    /// </summary>
    public class RegularCustomer : Customer
    {

        public RegularCustomer(string name) : base(name)
        {
            
        }
        public override string BuyTickets()
        {
            List<Seat> tempSeats = new List<Seat>();

            int theaterNumber = _displayBoard.GetTheaters.Count + 1;

            Random random = new Random();
          
            int randomNumber = random.Next(1, theaterNumber);

            _returnString += GetName + " chooses theater " + _displayBoard.GetTheaters.ElementAt(randomNumber-1).GetName + Environment.NewLine;

            GetSeats(tempSeats, randomNumber);
            
            return _returnString;
        }
    }
}
