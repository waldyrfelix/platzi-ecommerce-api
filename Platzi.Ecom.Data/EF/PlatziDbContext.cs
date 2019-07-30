using Microsoft.EntityFrameworkCore;
using Platzi.Ecom.Core.Customers;
using Platzi.Ecom.Core.Orders;
using Platzi.Ecom.Core.Products;

namespace Platzi.Ecom.Data.EF
{
    public class PlatziDbContext : DbContext
    {
        public PlatziDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
