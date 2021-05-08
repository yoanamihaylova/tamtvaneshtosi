using neshto_si.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.DataBase.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool role { get; set; }
        public User()
        {

        }
        public User(UserVM other)  
        {
         //   id = other.id;
            username = other.username;
            password = other.password;
            first_name = other.first_name;
            last_name = other.last_name;
            role = other.role;
        }


    }
}
