using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Helper;
using CinemaWithMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CinemaWithMVVM.ViewModels
{
    public class MovieEditUCViewModel:BaseViewModel
    {
        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set { movie = value;OnPropertyChanged(); }
        }

        public RelayCommand MovieAddCommand { get; set; }

        public RelayCommand BackCommand { get; set; }

        //private string movieName;

        //public string MovieName
        //{
        //    get { return movieName; }
        //    set { movieName = value;OnPropertyChanged(); }
        //}
        //private string moviePrice;

        //public string MoviePrice
        //{
        //    get { return moviePrice; }
        //    set { moviePrice = value;OnPropertyChanged(); }
        //}
        //private DateTime date;

        //public DateTime dateTime
        //{
        //    get { return date; }
        //    set { date = value;OnPropertyChanged(); }
        //}
        public void BackFunc()
        {
            App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count - 1);
        }
        public MovieEditUCViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                BackFunc();
            });

            MovieAddCommand = new RelayCommand(o =>
            {
                //Movie.Name = MovieName;
                //Movie.Price = MoviePrice;
                //Movie.dateTime = dateTime;
                FileHelper.WriteMovies(App.moviesRepo.Movies);
                MessageBox.Show("Movie Changed Succesfully");
                BackFunc();
                //MessageBox.Show("Test");
            });
        }
    }
}
