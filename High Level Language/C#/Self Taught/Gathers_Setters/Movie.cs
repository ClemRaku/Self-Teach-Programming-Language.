using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gathers_Setters
{
    class Movie
    {
        public string Title;
        public string Director;
        private string Rating;//makes the variable local to this class only
        public Movie(string aTitle, string aDirector, string aRating)
        {
            Title = aTitle;
            Director = aDirector;
            Rating = aRating;
        }
        public string rating
        {
            get
            {
                return Rating;
            }
            set
            {
                if(value == "G" || value == "PG" || value =="PG-13" || value == "R" || value == "NR")
                {
                    Rating = value;
                }
                else
                {
                    Rating = "NR";
                }
            }
        }
    }
}