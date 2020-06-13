using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    public class DisplayBoard
    {
        private List<Theater> _theaterList;
        private List<Receipt> _receiptList;
        private List<Movie> _movieList;
    
        public DisplayBoard()
        {
            _theaterList = new List<Theater>();
            _receiptList = new List<Receipt>();
            _movieList = new List<Movie>();
        }
        public void AddTheaters(Theater t)
        {
            _theaterList.Add(t);
        }
        public void AddMovies(Movie m)
        {
            _movieList.Add(m);
        }
        public string ShowTheaters(Theater t)
        {
            return t.ShowDetails();
        }
        public void AddReceipts(Receipt r)
        {
            _receiptList.Add(r);
        }
        public string ShowReceipts(Receipt r)
        {
            return r.GetFullDescription();
        }
        public List<Theater> GetTheaters
        {
            get
            {
                return _theaterList;
            }
        }
        public List<Receipt> GetReceipts
        {
            get
            {
                return _receiptList;
            }
        }
        public List<Movie> GetMovies
        {
            get
            {
                return _movieList;
            }
        }

    }
}
