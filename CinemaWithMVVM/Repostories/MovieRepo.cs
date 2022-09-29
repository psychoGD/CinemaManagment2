using CinemaWithMVVM.Helper;
using CinemaWithMVVM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.Repostories
{
    public class MovieRepo
    {
        public List<Movie> Movies { get; set; }
        public MovieRepo()
        {
            if (!File.Exists("movies.json"))
            {
                Movies = new List<Movie>();
                FileHelper.WriteMovies(Movies);
            }
            else
            {
                Movies = FileHelper.ReadMovies();
            }
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
            FileHelper.WriteMovies(Movies);
        }
    }
}
