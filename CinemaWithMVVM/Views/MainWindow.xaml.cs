using CinemaWithMVVM.ViewModels;
using CinemaWithMVVM.Views;
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

namespace CinemaWithMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void PlaySound()
        {
            mediaElement1.Source = new Uri(@"C:\Users\Huseyn\source\repos\CinemaProject_Copy\CinemaWithMVVM\Songs\daily_download_20181210_128.mp3");
            mediaElement1.Volume = 1;
            mediaElement1.Play();
        }
        public MainWindow()
        {
            InitializeComponent();
            //MainGrid.Children.Add(new FilmSearchUC());
            App.MainGrid = MainGrid;
            //var mainMenu = new MainMenu();
            //mainMenu.DataContext = new MainMenuViewModel();
            //MainGrid.Children.Add(mainMenu);

            //For Test
            var vievmodel = new FilmSearchViewModel();
            FilmSearchUC filmSearchUC = new FilmSearchUC(vievmodel);
            MainGrid.Children.Add(filmSearchUC);




        }
    }
}
