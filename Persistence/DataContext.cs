using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet is a collection of entities that we can query from our database
        // We can query our database using this DbSet
        // We can query our Activities table using this DbSet
        public DbSet<Activity> Activities { get; set; }
    }
}