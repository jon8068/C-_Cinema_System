using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    public class CelebrityFan : Customer
    {
        private string _favorite;
        public CelebrityFan(string name, string favorite) : base(name)
        {
            _favorite = favorite;
        }
        public int CheckCelebs()
        {
            int randomTheaterNumber = 0;
            for(int i = 0; i < _displayBoard.GetTheaters.Count; i++)
            {
                if (_displayBoard.GetTheaters.ElementAt(i).Movie.GetStarring.ToLower().Equals(_favorite.ToLower()))
                {
                    randomTheaterNumber = i + 1;
                }   
            }
            if (randomTheaterNumber != 0)
            {
                return randomTheaterNumber;
            } else
            {
                Random random = new Random();
                return randomTheaterNumber = random.Next(1, _displayBoard.GetTheaters.Count);
            }
           
        }
        public override string BuyTickets()
        {
            //Getting the non booked seats
            List<Seat> tempSeats = new List<Seat>();
            //List the bought seats by the customers for receipt
            List<Seat> boughtSeats = new List<Seat>();
            //Getting the theater number
            int theaterNumber = _displayBoard.GetTheaters.Count + 1;

            List<int> indexSeat = new List<int>();

            Random random = new Random();
            int randomNumber = CheckCelebs();

            //Chooses the theater
            _returnString += GetName + " chooses theater " + _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetName + Environment.NewLine;
            //Get Theater Seats
            tempSeats = _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetSeat;

            GetSeats(tempSeats, randomNumber);

            return _returnString;
        }
    }
}
