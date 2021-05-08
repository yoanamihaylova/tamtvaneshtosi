using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.Controllers.Models
{
    public class UserVM
    {

        public int id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "username cannot be longer than 30 characters")]
        [MinLength(1, ErrorMessage = "you need more than 0 charaters for username")]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool role { get; set; }
    }
}
