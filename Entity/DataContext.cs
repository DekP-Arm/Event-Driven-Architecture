
using Microsoft.EntityFrameworkCore;
using EDA.Entity;

namespace EDA{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<UserDbo> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}