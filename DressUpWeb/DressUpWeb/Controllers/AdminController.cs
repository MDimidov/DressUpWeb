using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static DressUp.Common.GeneralApplicationConstants;

namespace DressUp.Web.Controllers;

//[Authorize(Roles = AdminRoleName)]
public class AdminController : BaseController
{
    private readonly IAdminService adminService;

    public AdminController(IAdminService adminService)
    {
        this.adminService = adminService;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpGet]
    public async Task<IActionResult> AddUserToRolе()
    {
        AddUserToRoleViewModel formModel = new()
        {
            Roles = await adminService.GetAllRoles()
        };

        return View(formModel);
    }

    [HttpPost]
    public async Task<IActionResult> AddUserToRolе(AddUserToRoleViewModel userToRoleForm)
    {
        if (!ModelState.IsValid)
        {
            userToRoleForm.Roles = await adminService.GetAllRoles();
            return View(userToRoleForm);
        }

        var res = adminService.AddUserToRoleAsync(userToRoleForm.UserEmail, userToRoleForm.RoleName);

        return RedirectToAction("Index", "Home");
    }
}
