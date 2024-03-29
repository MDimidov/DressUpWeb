using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(GeneratesCategories());
    }

    private Category[] GeneratesCategories()
    {

        string categoriesData = File.ReadAllText("../DressUp.Data/Seed/CategoriesSeed.json");



        return JsonConvert
                .DeserializeObject<Category[]>(categoriesData)!;
    }
}
