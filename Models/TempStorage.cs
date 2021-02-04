using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSite.Models
{
    public class TempStorage
    {
        private static List<MovieModel> MovieList = new List<MovieModel>();

        public static IEnumerable<MovieModel> Movies => MovieList;

        public static void addMovie(MovieModel newMovie)
        {
            MovieList.Add(newMovie);
        }
    }
}
