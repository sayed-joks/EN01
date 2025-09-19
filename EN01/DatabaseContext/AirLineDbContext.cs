using EN01.AirLineModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.DatabaseContext
{
    internal class AirLineDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AirLine;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<AirLine> AirLines { get; set; }
        public DbSet<Aircraft_Route> Aircraft_Routes { get; set; }
        public DbSet<AirLinePhones> AirLinePhones { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Emp_Qualifications> Emp_Qualification { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
