using EN01.ITIModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN01.DatabaseContext
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Stud_Course> stud_Courses  { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }

    }
}
