﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    public class Receipt
    {
        private Customer _customer;
        private List<Seat> _seats;
        private Theater _theater;
        private int _totalPrice;

        public Receipt(Customer c, Theater t, List<Seat> s)
        {
            _seats = new List<Seat>();
            _customer = c;
            _seats = s;
            _theater = t;
        }

        public void CalculateTotalPrice(List<Seat> seats)
        {
            _seats = seats;
            foreach(Seat s in _seats)
            {
                _totalPrice += s.GetPrice;
            }
        }

        public string GetFullDescription()
        {
            string seatNames = "";
            
            foreach(Seat s in _seats)
            {
                if (s.Equals(_seats.ElementAt(_seats.Count - 1)))
                {
                    seatNames += s.GetRow.ToString() + s.GetColumn + ".";
                }
                else
                {
                    seatNames += s.GetRow.ToString() + s.GetColumn + ", ";
                }
            }

            return Environment.NewLine +
            "Receipt: " + Environment.NewLine +
            "Name: " + _customer.GetName + Environment.NewLine +
            "Movie: " + _theater.GetMovie.GetName + Environment.NewLine +
            "Theater: " + _theater.GetName + Environment.NewLine +
            "Seats Booked: " + seatNames + Environment.NewLine +
            "Total Price: $" + _totalPrice;
        }

    }
}
