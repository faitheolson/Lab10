using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movies
    {
        //fields
        private string movieName;
        private string genre;

        //properties
        public string MovieName
        {
            set { movieName = value; }
            get { return movieName; }
        }
        public string Genre
        {
            set { genre = value; }
            get { return genre; }
        }

    }
}
