using Assignment02_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment02_WebAPI.Persistence
{
    public class FamilyDBContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>()
                .HasKey(j => new { j.Salary, j.JobTitle });
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            // name of database
            optionsBuilder.UseSqlite("Data Source = Families.db");

        }
        
    }

    
   
}