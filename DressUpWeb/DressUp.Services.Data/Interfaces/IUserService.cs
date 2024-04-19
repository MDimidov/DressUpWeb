using DressUp.Web.ViewModels.User;

namespace DressUp.Services.Data.Interfaces;

public interface IUserService
{
	Task<string> GetFullNameByEmailAsync(string email);

	Task<bool> IsUserExistByEmailAsync(string email);

	Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
}
