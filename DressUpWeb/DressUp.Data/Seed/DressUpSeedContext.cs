using DressUp.Data.Models;
using DressUp.Web.Data;
using System.Text.Json;

public static class ApplicationDbContextSeed
{
    public static async Task SeedAsync(DressUpDbContext context)
    {
        if (!context.Products.Any())
        {
            var productsData = File.ReadAllText("products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsData);
            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }

        if (!context.Stores.Any())
        {
            var storesData = File.ReadAllText("stores.json");
            var stores = JsonSerializer.Deserialize<List<Store>>(storesData);
            await context.Stores.AddRangeAsync(stores);
            await context.SaveChangesAsync();
        }

        if (!context.Addresses.Any())
        {
            var addressesData = File.ReadAllText("addresses.json");
            var addresses = JsonSerializer.Deserialize<List<Address>>(addressesData);
            await context.Addresses.AddRangeAsync(addresses);
            await context.SaveChangesAsync();
        }
    }
}