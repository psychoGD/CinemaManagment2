using CinemaWithMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CinemaWithMVVM.Views.UserControls
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : UserControl
    {
        public void AddMovies()
        {
            foreach (var item in App.moviesRepo.Movies)
            {
                var movieUC = new MovieUC();
                var movieVM = new MovieViewModel();
                movieUC.DataContext = movieVM;
                movieVM.Movie = item;
                listbox.Items.Add(movieUC);
            }
        }
        public UserMenu()
        {
            InitializeComponent();
            AddMovies();
        }


    }
}
