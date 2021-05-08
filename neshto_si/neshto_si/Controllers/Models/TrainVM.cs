using neshto_si.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.Controllers.Models
{
    public class TrainVM
    {
        public List<Train> trains { get; set; }
        public int id { get; set; }       
        [Required]
        public string type { get; set; }
 
        [Required]
        public int capacity { get; set; }      
       
       // [(1, ErrorMessage = "you need more than 0 charaters for username")]

    }
}
