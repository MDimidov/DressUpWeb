using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Areas.Admin.Controllers;

public class UserController : BaseAdminController
{
        private readonly IUserService userService;

    public UserController(IUserService userService)
    {
        this.userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> All()
    {
        IEnumerable<UserViewModel> model = await userService.AllUsersAsync();

        return View(model);
    }
}
