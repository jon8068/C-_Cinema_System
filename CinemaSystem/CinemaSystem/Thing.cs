using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    public class Thing
    {
        private string _name;

        public Thing(string name)
        {
            _name = name;
        }
        public String GetName
        {
            get
            {
                return _name;
            }
        }
    }
}
