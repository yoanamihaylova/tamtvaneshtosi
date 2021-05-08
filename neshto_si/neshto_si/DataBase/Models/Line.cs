using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.DataBase.Models
{
    public class Line
    {
        public int id { get; set; }
        public string departure { get; set; }
        public string arrival { get; set; }
        public DateTime arrival_time { get; set; }
        public DateTime departure_time { get; set; }
        public virtual Train train_line { get; set; }

    }
}
