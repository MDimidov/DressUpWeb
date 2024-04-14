using DressUp.Data.Models;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Data;

public class UserService : IUserService
{
	private readonly DressUpDbContext dbContext;

	public UserService(DressUpDbContext dbContext)
	{
		this.dbContext = dbContext;
	}

	public async Task<string> GetFullNameByEmailAsync(string email)
	{
		ApplicationUser? user = await dbContext
			.Users
			.FirstOrDefaultAsync(u => u.Email == email);

		if (user == null)
		{
			return string.Empty;
		}
		else if (string.IsNullOrWhiteSpace(user.FirstName) && string.IsNullOrWhiteSpace(user.LastName))
		{
			return user.Email;
		}
		else if(!string.IsNullOrEmpty(user.FirstName) && string.IsNullOrWhiteSpace(user.LastName))
		{
			return user.FirstName;
		}
		else if(string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrWhiteSpace(user.LastName))
		{
			return user.LastName;
		}
		else
		{
			return $"{user.FirstName} {user.LastName}";
		}

	}

	public async Task<bool> IsUserExistByEmailAsync(string email)
		=> await dbContext
			.Users
			.AnyAsync(u => u.Email == email);
}
