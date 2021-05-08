using neshto_si.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.DataBase.Models
{
    public class Train
    {
        public int id { get; set; }
        public string type { get; set; }
        public int capacity { get; set; }
        public Train()
        {

        }
        public Train(TrainVM other)
        {
            //   id = other.id;
            type = other.type;
            capacity = other.capacity;
        }

    }
}
