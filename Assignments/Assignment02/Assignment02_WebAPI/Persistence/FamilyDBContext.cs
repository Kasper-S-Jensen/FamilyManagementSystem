using Assignment02_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment02_WebAPI.Persistence
{
    public class FamilyDBContext : DbContext
    {
        private DbSet<Adult> Adults { get; set; }
        private DbSet<Child> Children { get; set; }
        private DbSet<Family> Families { get; set; }
        private DbSet<Interest> Interests { get; set; }
        private DbSet<Job> Jobs { get; set; }
        private DbSet<Pet> Pets { get; set; }
        private DbSet<Person> Persons { get; set; }
        private DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            // name of database
            optionsBuilder.UseSqlite("Data Source = Families.db");

        }
        
    }

    
   
}