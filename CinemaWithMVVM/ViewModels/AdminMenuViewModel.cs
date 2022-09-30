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
        public RelayCommand HomeCommand { get; set; }
        public RelayCommand EditMenuCommand { get; set; }

        public AdminMenuViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(1);
                
            });
            AddMovieCommand = new RelayCommand(o =>
            {
                var filmSearchViewModel = new FilmSearchViewModel();
                var AddFilmUC = new FilmSearchUC(filmSearchViewModel);
                
                App.MainGrid.Children.Add(AddFilmUC);
            });
            HomeCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.Clear();
                var mainMenu = new MainMenu();
                mainMenu.DataContext = new MainMenuViewModel();
                App.MainGrid.Children.Add(mainMenu);
            });
            EditMenuCommand = new RelayCommand(o =>
            {
                var vm = new EditMoviesViewModel();
                var editMenu = new AdminEditMoviesUC(vm);

                App.MainGrid.Children.Add(editMenu);
            });

        }
    }
}
