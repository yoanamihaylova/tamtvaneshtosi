using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.DataBase.Models
{
    public class Ticket
    {

        public int id { get; set; }
        public virtual Train train_ticket { get; set; }
        public int N { get; set; }

        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string telephone { get; set; }


    }
}
