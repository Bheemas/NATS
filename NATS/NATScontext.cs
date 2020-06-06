using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace NATS
{
    public class NATScontext : Microsoft.EntityFrameworkCore.DbContext
    {
        public System.Data.Entity.DbSet<Users> Users { get; set; } 

       // private readonly string connectionString;

        public NATScontext(DbContextOptions<NATScontext> options) : base (options)
        {
            //this.connectionString = conn;

        }

        //protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.usesql
        //}



    }
}
