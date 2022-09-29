using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Views;
using CinemaWithMVVM.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.ViewModels
{
    public class AdminLoginMenuViewModel:BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }

        public RelayCommand LoginCommand { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;OnPropertyChanged(); }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }


        public AdminLoginMenuViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(0);
                var mainMenu = new MainMenu();
                App.MainGrid.Children.Add(mainMenu);
            });
            LoginCommand = new RelayCommand(o =>
            {
                if(Name=="admin" && Password == "admin")
                {
                    App.MainGrid.Children.RemoveAt(0);
                    var adminMenu = new AdminMenuUC();

                    App.MainGrid.Children.Add(mainMenu);
                }
            });
        }
    }
}
