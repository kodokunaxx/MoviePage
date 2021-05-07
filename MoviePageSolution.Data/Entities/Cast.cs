using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Entities
{
    public class Cast
    {
        public int Id {get;set;}
        public string Fullname {get;set;}
        public DateTime DoB {get;set;}
        public int Gender {get;set;}
        public string Nationality {get;set;}
        public string Avatar { get; set; }

    }
}
