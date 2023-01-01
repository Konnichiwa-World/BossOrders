using Microsoft.EntityFrameworkCore;

namespace BossOrders.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }    
        public DbSet<User> Users { get; set; }
    }
}
