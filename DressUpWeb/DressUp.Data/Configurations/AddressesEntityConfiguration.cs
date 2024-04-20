using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
{
	public void Configure(EntityTypeBuilder<Address> builder)
	{
		builder.HasData(GeneratesAddresses());
	}

	private Address[] GeneratesAddresses()
	{
		string addressesData;
		try
		{
			addressesData = File.ReadAllText("../DressUp.Data/Seed/AddressesSeed.json");
		}
		catch
		{
			addressesData = File.ReadAllText("../../../../DressUp.Data/Seed/AddressesSeed.json");
		}

		return JsonConvert
				.DeserializeObject<Address[]>(addressesData)!;
	}
}
