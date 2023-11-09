using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5___Enums
{
    internal class Movie
    {
        public string Name { get; set; }
        public MovieGenre Genre { get; set; }

        public Movie(string name, MovieGenre genre)
        {
            Name = name;
            Genre = genre;
        }

    }
}
