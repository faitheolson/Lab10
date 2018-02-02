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
        private string movieTitle;
        private string category;


        //properties
        public string MovieTitle
        {
            set { movieTitle = value; }
            get { return movieTitle; }
        }
        public string Category
        {
            set { category = value; }
            get { return category; }
        }

    }
}
