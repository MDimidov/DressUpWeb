using DressUp.Web.ViewModels.Admin;

namespace DressUp.Services.Data.Interfaces;

public interface IAdminService
{
    Task<IEnumerable<RoleViewModel>> GetAllRoles();

    Task<bool> CreateRoleIfNotExistsAsync(string roleForm);

    Task<bool> AddUserToRoleAsync(string userEmail, string roleName);
}
