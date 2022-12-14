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
    /// Interaction logic for FilmSearchUC.xaml
    /// </summary>
    public partial class FilmSearchUC : UserControl
    {
        public FilmSearchUC(FilmSearchViewModel filmSearchViewModel)
        {
            InitializeComponent();

            //Here Is The Reason I Do This To Throw A ListBox to ViewModel

            FilmSearchViewModel vm = filmSearchViewModel;
            vm.MyPanel = listbox;
            this.DataContext = vm;
        }
        //And Here is Why I am Not Do This In ViewModel.Because In ViewModel I Can't Bind MouseDoubleClick Event To Any Command
        private void listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MovieAddUC movieAddUC = new MovieAddUC();
            var vm = new MovieAddViewModel();
            MovieCellViewModel mvVM = (listbox.SelectedItem as MovieCellUC).DataContext as MovieCellViewModel;
            vm.Movie = mvVM.Movie;
            movieAddUC.DataContext = vm;
            
            App.MainGrid.Children.Add(movieAddUC);
        }
    }
}
