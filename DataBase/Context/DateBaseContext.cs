using Microsoft.EntityFrameworkCore;
using Models.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Context
{
    public class DateBaseContext : DbContext
    {
        public DbSet<Plant> Plants { get; protected set; }

        public DateBaseContext(DbContextOptions<DateBaseContext> options)
          : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}
