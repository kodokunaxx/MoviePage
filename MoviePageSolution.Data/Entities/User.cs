using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public DateTime DoB { get; set; }
        public string PhoneNumber { get; set; }
        public int Position { get; set; }

    }
}
