using Microsoft.EntityFrameworkCore;
using VanBox.API.Models;

namespace VanBox.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Value> Values {get; set;}
        
    }
}