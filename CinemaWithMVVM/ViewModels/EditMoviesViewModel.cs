using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Repostories;
using CinemaWithMVVM.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CinemaWithMVVM.ViewModels
{
    public class EditMoviesViewModel:BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }
        public RelayCommand RefreshCommand { get; set; }


        public MovieRepo movies { get; set; } = App.moviesRepo;
        public ListBox MyPanel { get; set; }
        public EditMoviesViewModel()
        {
            RefreshCommand = new RelayCommand(o =>
            {
                if (MyPanel.Items.Count > 0)
                {
                    MyPanel.Items.Clear();
                }
                if (App.moviesRepo.Movies.Count == 0)
                {
                    MessageBox.Show("There Is No Movie In Data Base", "Error");
                }
                else
                {
                    movies = App.moviesRepo;
                    int x = 10;
                    int y = 10;
                    foreach (var m in movies.Movies)
                    {
                        var ucVM = new MovieCellViewModel
                        {
                            Movie = m,
                        };
                        if (ucVM.Movie.ImagePath == "N/A")
                        {
                            string fileInfo = new FileInfo(@"default-movie.jpg").FullName.Replace(@"bin\Debug", "images");
                            //MessageBox.Show(fileInfo);
                            m.ImagePath = fileInfo;
                        }
                        var uc = new MovieCellUC(ucVM);

                        NumberFormatInfo provider = new NumberFormatInfo();
                        provider.NumberDecimalSeparator = ".";
                        provider.NumberGroupSeparator = ",";
                        double d = Convert.ToDouble(m.Rating, provider);
                        double result = ((d + 1) / 2);
                        //double result=1;
                        int count = (int)(result);
                        for (int i = 0; i < count; i++)
                        {
                            ucVM.StarsPanel.Children.Add(new StartUc());
                        }
                        uc.Width = 300;
                        uc.Height = 200;
                        uc.Margin = new System.Windows.Thickness(x, y, 0, 0);
                        MyPanel.Items.Add(uc);

                    }
                }
                
            });
            BackCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count-1);
            });
        }
    }
}
