using CinemaWithMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.ViewModels
{
    public class AdminMenuViewModel:BaseViewModel
    {
        public RelayCommand AddMovieCommand { get; set; }
        public AdminMenuViewModel()
        {
            AddMovieCommand = new RelayCommand(o =>
            {

            });
        }
    }
}
