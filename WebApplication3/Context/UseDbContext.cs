using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Context
{
    public class UseDbContext:DbContext
    {
        public UseDbContext()
        {
            
        }
        public UseDbContext(DbContextOptions<UseDbContext> options)
            :base(options)
        {

        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
    }
}
