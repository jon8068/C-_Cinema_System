using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    /// <summary>
    /// Loner will choose the theatre with the most empty seats, 
    /// and will only buy 1 ticket for him/herself
    /// </summary>
    public class Loner : Customer
    {
        public Loner(string name) : base(name)
        {

        }
        public override string BuyTickets()
        {
            Random random = new Random();
            List<Seat> tempSeats = new List<Seat>();

            int seatNumber = 0;
            int seatNumber2;
            int randomNumber = 1;

            for (int i = 0; i < _displayBoard.GetTheaters.Count; i++)
            {
                seatNumber2 = 0;
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

            _returnString += GetName + " chooses theater " + _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetName + Environment.NewLine;

            GetSeats(tempSeats, randomNumber);
            
            return _returnString;
        }
    }
}
