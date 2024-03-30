using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class CityEntityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasData(GeneratesCities());
    }

    private City[] GeneratesCities()
    {

        string categoriesData = File.ReadAllText("../DressUp.Data/Seed/CitiesSeed.json");



        return JsonConvert
                .DeserializeObject<City[]>(categoriesData)!;
    }
}
