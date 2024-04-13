using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Data;

public class AdminService : IAdminService
{
    private readonly DressUpDbContext dbContext;

    public AdminService(DressUpDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Task<bool> AddUserToRoleAsync(string userEmail, string roleName)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CreateRoleIfNotExistsAsync(string roleForm)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<RoleViewModel>> GetAllRoles()
        => await  dbContext
                .Roles
                .Select(r => new RoleViewModel()
                {
                    Id = r.Id.ToString(),
                    RoleName = r.Name,
                })
                .ToArrayAsync();
}
