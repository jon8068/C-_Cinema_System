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
        public DisplayBoard()
        {
            _theaterList = new List<Theater>();
        }
        public void AddTheaters(Theater t)
        {
            _theaterList.Add(t);
        }
        public string ShowTheaters(Theater t)
        {
            return t.ShowDetails();
        }
        public List<Theater> GetTheaters
        {
            get
            {
                return _theaterList;
            }
        }
      
    }
}
