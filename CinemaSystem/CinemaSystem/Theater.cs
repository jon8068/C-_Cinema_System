﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    /// <summary>
    /// Theater class, 
    /// contains seats and a movie
    /// </summary>
    public class Theater : Thing
    {
        private Movie _movie;
        private List<Seat> _seats;
        private TimeSpan _time;
        
        public Theater(string name, TimeSpan time) : base(name)
        {
            _seats = new List<Seat>();
            _time = time;
            GenerateSeats();
        }
        public void GenerateSeats()
        {
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Seat seat = new Seat(j, i);
                    _seats.Add(seat);
                }
            }
        }

        public string ShowSeats()
        {
            string theaterSeats = "";
            theaterSeats += GetName + " Theater Seat Chart"+ Environment.NewLine;
            for (int i = 1; i <= _seats.Count; i++)
            {
                if (!_seats.ElementAt(i - 1).GetStatus)
                {
                    theaterSeats += _seats.ElementAt(i - 1).GetRow.ToString() + _seats.ElementAt(i - 1).GetColumn + " ";
                } else
                {
                    theaterSeats += "XX ";
                }
                
                
                if(i % 4 == 0)
                {
                    theaterSeats += " - " + _seats.ElementAt(i-1).GetClass;
                    theaterSeats += Environment.NewLine;
                }
            }
            return theaterSeats;
        }
        public void BookSeats(Seat seat)
        {
             seat.ChangeStatus();    
        }
        public Movie Movie
        {
            get
            {
                return _movie;
            }
            set
            {
                _movie = value;
            }
        }
        public TimeSpan GetTime
        {
            get
            {
                return _time;
            }
        }
        public string IsFull
        {
            get
            {
                foreach(Seat s in _seats)
                {
                    if (!s.GetStatus)
                    {
                        return "Available";
                    }
                }
                return "Full";
            }
        }

        public List<Seat> GetSeat
        {
            get
            {
                return _seats;
            }
        }
    }
}
