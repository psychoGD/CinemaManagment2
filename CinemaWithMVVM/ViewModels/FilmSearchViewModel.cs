﻿using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Services;
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
    public class FilmSearchViewModel:BaseViewModel
    {
        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; OnPropertyChanged(); }
        }
        //RelayCommand Properties
        public RelayCommand SearchCommand { get; set; }

        public RelayCommand BackCommand { get; set; }

        public RelayCommand SelectUcCommand { get; set; }


        public ListBox MyPanel { get; set; }

        public WrapPanel testPanel { get; set; }
        public FilmSearchViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(2);
            });


            SelectUcCommand = new RelayCommand((o) =>
            {
                MessageBox.Show("Test");
                
            });


            SearchCommand = new RelayCommand((e) =>
            {
                if(MyPanel.Items.Count > 0)
                {
                    MyPanel.Items.Clear();
                }
                var movies = MovieService.GetMovies(SearchText);
                int x = 10;
                int y = 10;
                foreach (var m in movies)
                {
                    //MessageBox.Show($"{m.ImagePath}");
                    

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
            });
        }
    }
}
