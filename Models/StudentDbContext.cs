using Microsoft.EntityFrameworkCore;
using mvc_demo.Models.Entities;

namespace mvc_demo.Models

{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        }

    }
    
}