using LoginAgain.Components.Data;
using LoginAgain.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginAgain.Components.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
            
        }
        public DbSet<User> Users { get; set; }
    }
}
