using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7.Models
{
    public class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public User(string? name,  string? password)
        {
            Name = name;
            Password = password;
        }
    }
}