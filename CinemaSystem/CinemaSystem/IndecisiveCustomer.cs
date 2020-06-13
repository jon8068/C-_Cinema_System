using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
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
            //Getting the non booked seats
            List<Seat> tempSeats = new List<Seat>();
            //List the bought seats by the customers for receipt
            //Getting the theater number
            int theaterNumber = _displayBoard.GetTheaters.Count + 1;

            Random random = new Random();
            int randomNumber = random.Next(1, theaterNumber);


            //Chooses the theater
            _returnString += GetName + " chooses theater " + _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetName + Environment.NewLine;

            //Indecisiveness
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
