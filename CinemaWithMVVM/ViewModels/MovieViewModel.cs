using CinemaWithMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.ViewModels
{
    public class MovieViewModel:BaseViewModel
    {
        private string movieName;

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value;OnPropertyChanged(); }
        }
        private string movieTime;

        public string MovieTime
        {
            get { return movieTime; }
            set { movieTime = value;OnPropertyChanged(); }
        }
        private string moviePrice;

        public string MoviePrice
        {
            get { return moviePrice; }
            set { moviePrice = value;OnPropertyChanged(); }
        }
        public RelayCommand BtnCommand { get; set; }
    }
}
