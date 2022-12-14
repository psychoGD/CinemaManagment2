using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Views;
using CinemaWithMVVM.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CinemaWithMVVM.ViewModels
{
    public class MainMenuViewModel:BaseViewModel
    {
        public RelayCommand AdminLoginMenuCommand { get; set; }
        public RelayCommand UserMenuCommand { get; set; }

        public MainMenuViewModel()
        {
            AdminLoginMenuCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(0);
                var adminMenu = new AdminLoginMenuUC();
                adminMenu.DataContext = new AdminLoginMenuViewModel();
                App.MainGrid.Children.Add(adminMenu);
            });
            UserMenuCommand = new RelayCommand(o =>
            {
                //App.MainGrid.Children.RemoveAt(0);
                var adminMenu = new UserMenu();
                adminMenu.DataContext = new UserMenuViewModel();
                App.MainGrid.Children.Add(adminMenu);
            });
        }
    }
}
