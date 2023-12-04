using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Store> Stores { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=LAPTOP-94UMSFPO;Initial Catalog=ProductsDemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}