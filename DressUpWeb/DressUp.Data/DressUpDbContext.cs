#nullable disable

using DressUp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DressUp.Web.Data;

public class DressUpDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public DressUpDbContext(DbContextOptions<DressUpDbContext> options)
        : base(options)
    {
    }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<BuyedProduct> BuyedProducts { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductReview> ProductsReviews { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<StoreProduct> StoresProducts { get; set; }

     
    protected override void OnModelCreating(ModelBuilder builder)
    {
        Assembly configAssembly = Assembly.GetAssembly(typeof(DressUpDbContext)) ?? 
                            Assembly.GetExecutingAssembly();
        builder.ApplyConfigurationsFromAssembly(configAssembly); 

        base.OnModelCreating(builder);
    }
}
