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
    
        public DisplayBoard()
        {
            _theaterList = new List<Theater>();
            _receiptList = new List<Receipt>();
        }
        public void AddTheaters(Theater t)
        {
            _theaterList.Add(t);
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

    }
}
