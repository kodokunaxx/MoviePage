using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public DateTime Release_date { get; set; }
        public string Director { get; set; }
        public string Backdrop { get; set; }
        public string Poster { get; set; }
        public int Time { get; set; }
        public string Nation { get; set; }
        public int Episodes { get; set; }
        public string Language { get; set; }
        public string Youtube { get; set; }

}
}
