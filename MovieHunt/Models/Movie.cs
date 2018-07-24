using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieHunt.Models
{
    public class Movie
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

    }
}