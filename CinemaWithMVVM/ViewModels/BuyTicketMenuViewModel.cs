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
    public class BuyTicketMenuViewModel:BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }
        public Movie movie { get; set; }
        private string total;

        public string Total
        {
            get { return total; }
            set { total = value;OnPropertyChanged(); }
        }

        private string count;

        public string Count
        {
            get { return count; }
            set { count = value;TotalRefresh();OnPropertyChanged(); }
        }

        public RelayCommand BuyCommand { get; set; }
        public void TotalRefresh()
        {
            if (Count == string.Empty)
            {
                Total = "Total: 0";
            }
            else
            {
                Total = "Total: "+(double.Parse(movie.Price) * double.Parse(count)).ToString();

            }
        }
        public void BackFunc()
        {
            App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count - 1);
        }
        public BuyTicketMenuViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                BackFunc();
            });
            BuyCommand = new RelayCommand(o =>
            {
                var count = movie.Capacity - movie.Count;
                if (count>0 && count <= int.Parse(Count))
                {
                    movie.Count+=count;
                    MessageBox.Show("Operation Succesfully");
                    BackFunc();
                }
                else
                {
                    MessageBox.Show($"Operation Unsuccesfully.number of tickets remaining: {count}");
                }
            });
        }
    }
}
