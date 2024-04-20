using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class StoreEntityConfiguration : IEntityTypeConfiguration<Store>
{
	public void Configure(EntityTypeBuilder<Store> builder)
	{
		builder.HasData(GeneratesStores());
	}

	private Store[] GeneratesStores()
	{
		string storesData;

		try
		{
			storesData = File.ReadAllText("../DressUp.Data/Seed/StoresSeed.json");
		}
		catch
		{
			storesData = File.ReadAllText("../../../../DressUp.Data/Seed/StoresSeed.json");
		}

		return JsonConvert
				.DeserializeObject<Store[]>(storesData)!;
	}
}
