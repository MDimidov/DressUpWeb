using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(GeneratesProducts());
    }

    private Product[] GeneratesProducts()
    {

        string categoriesData = File.ReadAllText("../DressUp.Data/Seed/ProductsSeed.json");



        return JsonConvert
                .DeserializeObject<Product[]>(categoriesData)!;
    }
}
