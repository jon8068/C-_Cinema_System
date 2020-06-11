﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    public abstract class Customer : Thing
    {
        protected Receipt _receipt;
        protected DisplayBoard _displayBoard;
        protected List<Theater> _theaterList;
        
        public Customer(string name) : base(name)
        {
            _displayBoard = new DisplayBoard();
            _theaterList = new List<Theater>();
            _theaterList = _displayBoard.GetTheaters;
        }
        public abstract void BuyTickets();
        
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
    }
}