using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Persistence
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite(@"Data Source = D:\Dokumenter D\Git\DNP1_Assignments\Session09\Library\Library.db");
        }
    }
}