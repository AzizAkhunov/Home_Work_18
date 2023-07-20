using Home_Work_18.Moduls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_18.DataBases
{
    public class CRUDDB : DbContext
    {
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=56767655;Database=CRUDDB";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Person> children { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Passport> passports { get; set; }
    }
}
