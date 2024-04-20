using DressUp.Data.Models;
using DressUp.Data.Processor.ImportDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace DressUp.Data.Configurations;

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
	public void Configure(EntityTypeBuilder<ApplicationUser> builder)
	{
		builder.HasData(GeneratesApplicationUsers());
	}

	private ApplicationUser[] GeneratesApplicationUsers()
	{
		string usersData;
		try
		{
			usersData = File.ReadAllText("../DressUp.Data/Seed/ApplicationUsersSeed.json");
		}
		catch
		{
			usersData = File.ReadAllText("../../../../DressUp.Data/Seed/ApplicationUsersSeed.json");
		}



		ApplicationUserDTO[] users = JsonConvert
				.DeserializeObject<ApplicationUserDTO[]>(usersData)!;

		PasswordHasher<ApplicationUser> passwordHasher = new();

		ApplicationUser[] usersToSeed = users
			.Select(u => new ApplicationUser
			{
				Id = u.Id,
				Email = u.Email,
				NormalizedEmail = u.NormalizedEmail,
				UserName = u.UserName,
				NormalizedUserName = u.NormalizedUserName,
				PasswordHash = passwordHasher.HashPassword(null!, u.Password),
				FirstName = u.FirstName,
				LastName = u.LastName,
				Gender = u.Gender,
				EmailConfirmed = u.EmailConfirmed,
				SecurityStamp = u.SecurityStamp,
				ConcurrencyStamp = u.ConcurrencyStamp
			})
			.ToArray();

		return usersToSeed;
	}
}
