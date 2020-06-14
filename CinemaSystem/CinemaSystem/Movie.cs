using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystem
{
    /// <summary>
    /// Movie Class,  
    /// the genre, description, and starring
    /// Can have properties to get the description, starring, and category
    /// </summary>
    public class Movie : Thing
    {

        private enum MovieCategory
        {
            Horror,
            Romance,
            Action,
            Animation
        }

        private MovieCategory _category;
        private string _description;
        private string _starring;
        
        public Movie(string name, int category, string description, string starring) : base(name)
        {
            if(category == 1)
            {
                _category = MovieCategory.Horror;
            } else if (category == 2)
            {
                _category = MovieCategory.Romance;
            } else if (category == 3)
            {
                _category = MovieCategory.Action;
            } else if (category == 4)
            {
                _category = MovieCategory.Animation;
            }

            _starring = starring;
            _description = description;

        }

        public string GetStarring
        {
            get
            {
               return _starring;
            }
        }

        public string GetDesc
        {
            get
            {
                return _description;
            }
        }

        public Enum GetCategory
        {
            get
            {
                return _category;
            }
        }
    }
}
