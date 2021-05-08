using Microsoft.EntityFrameworkCore;
using neshto_si.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.DataBase
{
    public class Madura3 : DbContext
    {
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Line> lines { get; set; }
        public virtual DbSet<Train> trains { get; set; }
        public virtual DbSet<Ticket> tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\.; Database = madura3vol1;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
