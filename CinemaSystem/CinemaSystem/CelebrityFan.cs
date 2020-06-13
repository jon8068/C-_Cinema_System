﻿using System;
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
                if (_displayBoard.GetTheaters.ElementAt(i).GetMovie.GetStarring.ToLower().Equals(_favorite.ToLower()))
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

            //How many tickets do you want to buy
            int randomTickets = random.Next(1, 16);

            //Randomized which seats you want to buy
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
                //Booking the seat
                if (tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetStatus)
                {
                    continue;
                }
                else
                {
                    _displayBoard.GetTheaters.ElementAt(randomNumber - 1).BookSeats((tempSeats.ElementAt(indexSeat.ElementAt(i) - 1)));
                    _returnString += GetName + " chooses seat number " + tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetRow + tempSeats.ElementAt(indexSeat.ElementAt(i) - 1).GetColumn + Environment.NewLine;
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
