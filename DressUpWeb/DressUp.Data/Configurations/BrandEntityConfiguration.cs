using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class BrandEntityConfiguration : IEntityTypeConfiguration<Brand>
{
	public void Configure(EntityTypeBuilder<Brand> builder)
	{
		builder.HasData(GeneratesBrands());
	}

	private Brand[] GeneratesBrands()
	{
		string brandsData;

		try
		{
			brandsData = File.ReadAllText("../DressUp.Data/Seed/BrandsSeed.json");
		}
		catch
		{
			brandsData = File.ReadAllText("../../../../DressUp.Data/Seed/BrandsSeed.json");
		}



		return JsonConvert
				.DeserializeObject<Brand[]>(brandsData)!;
	}
}
