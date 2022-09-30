using CinemaWithMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.ViewModels
{
    public class UserMenuViewModel:BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }
        public UserMenuViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count - 1);
            });
        }
    }
}
