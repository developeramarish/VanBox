using Microsoft.EntityFrameworkCore;
using VanBox.Models;

namespace VanBox.Persistence
{
    public class VanBoxDbContext : DbContext 
    {

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }

        public DbSet<Feature> Features { get; set; }
        
        public VanBoxDbContext(DbContextOptions<VanBoxDbContext> options):base(options)
        {
            
        }
        
    }
}