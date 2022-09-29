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

        private string errorTxt;

        public string ErrorTxt
        {
            get { return errorTxt; }
            set { errorTxt = value;OnPropertyChanged(); }
        }


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
                mainMenu.DataContext = new MainMenuViewModel();
                App.MainGrid.Children.Add(mainMenu);
            });
            LoginCommand = new RelayCommand(async o =>
            {
                if(Name=="admin" && Password == "admin")
                {
                    var adminMenu = new AdminMenuUC();
                    adminMenu.DataContext =  new AdminMenuViewModel();
                    App.MainGrid.Children.Add(adminMenu);
                }
                else
                {
                    ErrorTxt = "Name Or Password Is Incorrect";
                    await Task.Delay(5_000);
                    ErrorTxt = string.Empty;
                }
            });
        }
    }
}
