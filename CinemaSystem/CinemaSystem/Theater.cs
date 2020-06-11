using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
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
        public void AddMovie(Movie movie)
        {
            _movie = movie;

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

        public void ShowSeats()
        {
            Console.WriteLine(GetName + " Theater Seat Chart"+ Environment.NewLine);
            for (int i = 1; i <= _seats.Count; i++)
            {
                if (!_seats.ElementAt(i - 1).GetStatus)
                {
                    Console.Write("{0}{1} ", _seats.ElementAt(i - 1).GetRow, _seats.ElementAt(i - 1).GetColumn);
                } else
                {
                    Console.Write("XX ");
                }
                
                
                if(i % 4 == 0)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
        public void BookSeats(Seat seat)
        {
             seat.ChangeStatus();    
        }

        public Movie GetMovie
        {
            get
            {
                return _movie;
            }
        }
        public TimeSpan GetTime
        {
            get
            {
                return _time;
            }
        }
        public bool IsFull
        {
            get
            {
                foreach(Seat s in _seats)
                {
                    if (!s.GetStatus)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public List<Seat> GetSeat
        {
            get
            {
                return _seats;
            }
        }

        public string ShowDetails()
        {
            return "This is Theater " + this.GetName + Environment.NewLine +
                "It will show the movie " + _movie.GetName + " at " + _time.Hours + " : " + _time.Minutes + Environment.NewLine;
        }
    }
}
