using DressUp.Data.Models;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.User;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Data;

public class UserService : IUserService
{
    private readonly DressUpDbContext dbContext;
    private readonly IAdminService adminService;

    public UserService(
        DressUpDbContext dbContext,
        IAdminService adminService)
    {
        this.dbContext = dbContext;
        this.adminService = adminService;
    }

    public async Task<IEnumerable<UserViewModel>> AllUsersAsync()
    {
        IEnumerable<UserViewModel> users = await dbContext
            .Users
            .AsNoTracking()
            .Select(u => new UserViewModel
            {
                Id = u.Id.ToString(),
                Email = u.Email,
                FullName = $"{u.FirstName} {u.LastName}",
            })
            .ToArrayAsync();

        foreach (UserViewModel user in users)
        {
            user.Roles =
                await adminService.GetUserRolesByEmailAsync(user.Email);
        }

        return users;
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
        else if (!string.IsNullOrEmpty(user.FirstName) && string.IsNullOrWhiteSpace(user.LastName))
        {
            return user.FirstName;
        }
        else if (string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrWhiteSpace(user.LastName))
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
