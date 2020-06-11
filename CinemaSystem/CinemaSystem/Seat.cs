using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    public class Seat
    {

        private enum SeatClass
        {
            Gold,
            Silver,
            Bronze
        }

        private bool _status;
        private int _column;
        private char _row;
        private SeatClass _seatClass;
        private int _price;

        public Seat(int column, char row)
        {
            _column = column;
            _row = row;
            _status = false;
            SetSeatClassAndPrice();
        }

        public void ChangeStatus()
        {
            _status = true;
        }

        public void SetSeatClassAndPrice()
        {
            if (_row.Equals('A'))
            {
                _seatClass = SeatClass.Gold;
                _price = 20;
            }
            else if (_row.Equals('B')||_row.Equals('C'))
            {
                _seatClass = SeatClass.Silver;
                _price = 15;

            }
            else if (_row.Equals('D'))
            {
                _seatClass = SeatClass.Bronze;
                _price = 10;
            }
        }

        public bool GetStatus
        {
            get
            {
                return _status;
            }
        }

        public char GetRow
        {
            get
            {
                return _row;
            }
        }

        public int GetColumn
        {
            get
            {
                return _column;
            }
        }

        public int GetPrice
        {
            get
            {
                return _price;
            }
        }
        
    }
}
