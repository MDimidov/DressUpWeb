using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class ProductImageEntityConfiguration : IEntityTypeConfiguration<ProductImage>
{
	public void Configure(EntityTypeBuilder<ProductImage> builder)
	{
		builder.HasData(GeneratesProductImages());
	}

	private ProductImage[] GeneratesProductImages()
	{
		string productImagesData;

		try
		{
			productImagesData = File.ReadAllText("../DressUp.Data/Seed/ProductImagesSeed.json");
		}
		catch
		{
			productImagesData = File.ReadAllText("../../../../DressUp.Data/Seed/ProductImagesSeed.json");
		}



		return JsonConvert
				.DeserializeObject<ProductImage[]>(productImagesData)!;
	}
}
