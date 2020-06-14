using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    /// <summary>
    /// Customer Class (Abstract), will be the ones 
    /// who are buying the tickets to the theater
    /// </summary>
    public abstract class Customer : Thing
    {
        protected Receipt _receipt;
        protected DisplayBoard _displayBoard;
        protected List<Theater> _theaterList;
        protected string _returnString;
        
        public Customer(string name) : base(name)
        {
            _displayBoard = new DisplayBoard();
            _theaterList = new List<Theater>();
            _theaterList = _displayBoard.GetTheaters;
        }
        public abstract string BuyTickets();
        
        public Receipt GetReceipt
        {
            get
            {
                return _receipt;
            }
        }

        public DisplayBoard DisplayBoard
        {
            get
            {
                return _displayBoard;
            }
            set
            {
                _displayBoard = value;
            }
        }

        public string GetSeats(List<Seat> tempSeats, int randomNumber)
        {
            List<int> indexSeat = new List<int>();
            List<Seat> boughtSeats = new List<Seat>();
            Random random = new Random();
            int randomTickets;

            tempSeats = _displayBoard.GetTheaters.ElementAt(randomNumber - 1).GetSeat;

            Type type = this.GetType();

            if (type.Name.Equals("Loner"))
            {
                randomTickets = 1;
            }
            else
            {
                randomTickets = random.Next(1, 17);
            }

            for (int i = 0; i < randomTickets; i++)
            {
                int randomSeat;
                while (true)
                {
                    randomSeat = random.Next(1, 16);
                    if (!indexSeat.Contains(randomSeat)) break;
                }
                indexSeat.Add(randomSeat);
            }

            for (int i = 0; i < indexSeat.Count; i++)
            {
                if (tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetStatus)
                {
                    continue;
                }
                else
                {
                    _displayBoard.GetTheaters.ElementAt(randomNumber - 1).BookSeats((tempSeats.ElementAt(indexSeat.ElementAt(i) - 1)));
                    _returnString += GetName + " chooses seat number " + tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetRow + tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetColumn + Environment.NewLine;
                    boughtSeats.Add(tempSeats.ElementAt(indexSeat.ElementAt(i) - 1));
                }
            }

            if (boughtSeats.Any())
            {
                _displayBoard.GetTheaters.ElementAt(randomNumber - 1).ShowSeats();

                _receipt = new Receipt(this, _displayBoard.GetTheaters.ElementAt(randomNumber - 1), boughtSeats);
             
                _receipt.CalculateTotalPrice(boughtSeats);
             
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
