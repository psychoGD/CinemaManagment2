using CinemaWithMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace CinemaWithMVVM.ViewModels
{
    public class SeatViewModel
    {
        public List<List<bool>> seats { get; set; }
        public bool isEmpty { get; set; }
        public Grid myGrid { get; set; }
        public RelayCommand ClickCommand { get; set; }
        public int row { get; set; }
        public int column { get; set; }

        public SeatViewModel(bool isEmpty)
        {
            this.isEmpty = isEmpty;
            if (!isEmpty)
            {
                myGrid.Background = new SolidColorBrush(Colors.Black);
            }
            ClickCommand = new RelayCommand(o =>
            {
                if (isEmpty)
                {
                    isEmpty = false;
                    myGrid.Background = new SolidColorBrush(Colors.Black);
                    seats[row][column] = isEmpty;
                }
                else
                {
                    isEmpty = true;
                    myGrid.Background = new SolidColorBrush(Colors.White);
                    seats[row][column] = isEmpty;
                }
            });
        }
    }
}
