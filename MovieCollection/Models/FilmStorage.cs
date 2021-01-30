using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class FilmStorage
    {
        private static List<FilmModel> Films = new List<FilmModel>();

        public static IEnumerable<FilmModel> ConcatFilms => Films;

        public static void AddFilm(FilmModel Film)
        {
            Films.Add(Film);
        }
    }
}
