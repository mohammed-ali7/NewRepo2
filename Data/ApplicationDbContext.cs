using Microsoft.EntityFrameworkCore;
using ToDoApp.Models.Entities;

namespace ToDoApp.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions options): base(options) 
        {   
        }
        public DbSet<Todo> Tasks { get; set; }
    }
}
