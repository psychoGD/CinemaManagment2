using CinemaWithMVVM.ViewModels;
using CinemaWithMVVM.Views.UserControls;
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

namespace CinemaWithMVVM.Views
{
    /// <summary>
    /// Interaction logic for AdminEditMoviesUC.xaml
    /// </summary>
    public partial class AdminEditMoviesUC : UserControl
    {
        public AdminEditMoviesUC(EditMoviesViewModel editMoviesViewModel)
        {
            InitializeComponent();
            EditMoviesViewModel vm = editMoviesViewModel;
            vm.MyPanel = listbox;
            this.DataContext = vm;
        }

        private void listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MovieAddUC movieAddUC = new MovieAddUC();
            //var vm = new MovieAddViewModel();
            //MovieCellViewModel mvVM = (listbox.SelectedItem as MovieCellUC).DataContext as MovieCellViewModel;
            //vm.Movie = mvVM.Movie;
            //movieAddUC.DataContext = vm;

            //App.MainGrid.Children.Add(movieAddUC);
            MovieEditUC movieEditUC = new MovieEditUC();
            var vm = new MovieEditUCViewModel();
            MovieCellViewModel mvVM = (listbox.SelectedItem as MovieCellUC).DataContext as MovieCellViewModel;
            vm.Movie = mvVM.Movie;
            movieEditUC.DataContext = vm;

            App.MainGrid.Children.Add(movieEditUC);
        }
    }
}
