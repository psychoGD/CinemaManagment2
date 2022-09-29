using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.ViewModels
{
    public class AdminMenuViewModel:BaseViewModel
    {
        public RelayCommand AddMovieCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public AdminMenuViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(1);
                
            });
            AddMovieCommand = new RelayCommand(o =>
            {
                var AddFilmUC = new FilmSearchUC();
                AddFilmUC.DataContext = new FilmSearchViewModel();
                App.MainGrid.Children.Add(AddFilmUC);
            });

        }
    }
}
