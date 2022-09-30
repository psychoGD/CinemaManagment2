using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.Models
{
    public class Movie
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string OriginalDescription { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string ImagePath { get; set; }
        public string Price { get; set; }
        public DateTime dateTime { get; set; }
        public int Count { get; set; } = 0;
        public int Capacity { get; set; } = 30;
        //first for lenght 7 second for lenght 8 All seat count 56
        //public List<List<bool>> Seats { get; set; }
        //public Movie()
        //{
        //    Seats=new List<List<bool>>();
        //    for (int i = 0; i < 7; i++)
        //    {
        //        var newList = new List<bool>();
        //        for (int k = 0; k < 8; k++)
        //        {
        //            newList.Add(true);
        //        }
        //        Seats.Add(newList);
        //    }
        //}
    }
}
