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
            List<Seat> boughtSeats = new List<Seat>();
            //Getting the theater number
            int theaterNumber = _displayBoard.GetTheaters.Count + 1;

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
            //Get Theater Seats
            tempSeats = _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetSeat;

            int indexSeat = random.Next(1, 16);
            
            //Booking the seat
            if (!tempSeats.ElementAt(indexSeat - 1).GetStatus)
            {
                _displayBoard.GetTheaters.ElementAt(randomNumber - 1).BookSeats((tempSeats.ElementAt(indexSeat - 1)));
                _returnString += GetName + " chooses seat number " + tempSeats.ElementAt(indexSeat - 1).GetRow + tempSeats.ElementAt(indexSeat - 1).GetColumn;
                //Add list of bought seats
                boughtSeats.Add(tempSeats.ElementAt(indexSeat - 1));
            }
            

            if (boughtSeats.Any())
            {
                //Display bought seats
                _displayBoard.GetTheaters.ElementAt(randomNumber - 1).ShowSeats();

                _receipt = new Receipt(this, _displayBoard.GetTheaters.ElementAt(randomNumber - 1), boughtSeats);
                //Calculate total price
                _receipt.CalculateTotalPrice(boughtSeats);
                //Get the full description of the receipt
                _returnString += _receipt.GetFullDescription();

                _displayBoard.GetReceipts.Add(_receipt);
            }
            else
            {
                _returnString += GetName + " didn't like any of the seats, so " + GetName + " went home.";
            }
            return _returnString;
        }
    }
}
