using CinemaWithMVVM.Helper;
using CinemaWithMVVM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public bool AddMovie(Movie movie)
        {
            foreach (var item in Movies)
            {
                if (item.Name == movie.Name && item.dateTime == movie.dateTime)
                {
                    MessageBox.Show($"This Movie Exist in {item.dateTime}");
                    return false;
                }
            }
            Movies.Add(movie);
            FileHelper.WriteMovies(Movies);
            return true;
        }
    }
}
