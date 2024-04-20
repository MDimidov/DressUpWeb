using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class CountryEntityConfiguration : IEntityTypeConfiguration<Country>
{
	public void Configure(EntityTypeBuilder<Country> builder)
	{
		builder.HasData(GeneratesCountries());
	}

	private Country[] GeneratesCountries()
	{
		string countriesData;
		try
		{
			countriesData = File.ReadAllText("../DressUp.Data/Seed/CountriesSeed.json");
		}
		catch
		{
			countriesData = File.ReadAllText("../../../../DressUp.Data/Seed/CountriesSeed.json");
		}

		return JsonConvert
				.DeserializeObject<Country[]>(countriesData)!;
	}
}
