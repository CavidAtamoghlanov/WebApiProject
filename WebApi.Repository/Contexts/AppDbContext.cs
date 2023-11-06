using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApi.Core.Entities;

namespace WebApi.Repository.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext( DbContextOptions<AppDbContext> options)
        :base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }


    // DbSets (My Tables)
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }


}
