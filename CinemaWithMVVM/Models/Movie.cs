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
    }
}
