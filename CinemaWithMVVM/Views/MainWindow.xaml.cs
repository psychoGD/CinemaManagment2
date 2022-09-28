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
        public MainWindow()
        {
            InitializeComponent();
            //MainGrid.Children.Add(new FilmSearchUC());
            MainGrid.Children.Add(new MainMenu());
            mediaElement1.Source = new Uri(@"C:\Users\Huseyn\source\repos\CinemaProject_Copy\CinemaWithMVVM\Songs\daily_download_20181210_128.mp3");
            mediaElement1.Play();
        }
    }
}
