using Microsoft.EntityFrameworkCore;
using TodosWebAPI.Models;

namespace TodosWebAPI.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // name of database
            optionsBuilder.UseSqlite("Data Source = Todo.db");
        }
    }
}