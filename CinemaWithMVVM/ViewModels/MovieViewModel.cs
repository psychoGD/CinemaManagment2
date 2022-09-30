using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Models;
using CinemaWithMVVM.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.ViewModels
{
    public class MovieViewModel:BaseViewModel
    {
        public Movie Movie { get; set; }
        //private string movieName;

        //public string MovieName
        //{
        //    get { return movieName; }
        //    set { movieName = value;OnPropertyChanged(); }
        //}
        //private string movieTime;

        //public string MovieTime
        //{
        //    get { return movieTime; }
        //    set { movieTime = value;OnPropertyChanged(); }
        //}
        //private string moviePrice;

        //public string MoviePrice
        //{
        //    get { return moviePrice; }
        //    set { moviePrice = value;OnPropertyChanged(); }
        //}
        public RelayCommand BtnCommand { get; set; }

        public MovieViewModel()
        {
            BtnCommand = new RelayCommand(o =>
            {
                var buyTicketUc = new BuyTicketMenu();
                var buyTicketVM = new BuyTicketMenuViewModel();
                buyTicketVM.movie = Movie;
                buyTicketUc.DataContext = buyTicketVM;
                App.MainGrid.Children.Add(buyTicketUc);
            });
        }
    }
}
