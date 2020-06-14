using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    /// <summary>
    /// Indecisive customer will have a random indecisive meter, if it is high enough, 
    /// they will change their mind after choosing the movie and go home instead.
    /// </summary>
    public class IndecisiveCustomer : Customer
    {
        private int _indecisiveMeter;
        public IndecisiveCustomer(string name) : base(name)
        {
            Random random = new Random();
            _indecisiveMeter = random.Next(1, 10);
        }
        public override string BuyTickets()
        {
            List<Seat> tempSeats = new List<Seat>();
            int theaterNumber = _displayBoard.GetTheaters.Count + 1;

            Random random = new Random();
            int randomNumber = random.Next(1, theaterNumber);

            _returnString += GetName + " chooses theater " + _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetName + Environment.NewLine;

            if (_indecisiveMeter < 5)
            {
                _returnString += GetName + " changed his/her/their mind. " + GetName + " decided to go home ";
                return _returnString;
            }

            GetSeats(tempSeats, randomNumber);

            return _returnString;
        }
    }
}
