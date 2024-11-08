using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderService.Infrastructure.Entities;

namespace OrderService.Infrastructure.Data
{
    public class OrderDbContext : DbContext 
    {
        public OrderDbContext()
        {
            
        }

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
