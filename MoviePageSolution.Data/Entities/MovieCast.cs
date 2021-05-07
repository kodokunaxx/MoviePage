using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Entities
{
    public class MovieCast
    {
        public int Id {get;set;}
        public int? IdMovie {get;set;}
        public int? IdCast {get;set;}
        public string Character { get; set; }

    }
}
