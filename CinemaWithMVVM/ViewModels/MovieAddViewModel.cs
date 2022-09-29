using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CinemaWithMVVM.ViewModels
{
    public class MovieAddViewModel:BaseViewModel
    {
        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set { movie = value;OnPropertyChanged(); }
        }

        public RelayCommand MovieAddCommand { get; set; }

        public RelayCommand BackCommand { get; set; }

        public MovieAddViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count - 1);
            });

            MovieAddCommand = new RelayCommand(o =>
            {
                if(Movie.Name!=String.Empty && Movie.Price!=String.Empty && Movie.dateTime.ToString() != String.Empty)
                {
                    App.moviesRepo.AddMovie(Movie);
                }
                else
                {
                    MessageBox.Show("");
                }
                
            });
        }
    }
}
