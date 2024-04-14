using DressUp.Services.Data;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static DressUp.Common.GeneralApplicationConstants;
using static DressUp.Common.NotificationMessagesConstants;

namespace DressUp.Web.Controllers;

[Authorize(Roles = AdminRoleName)]
public class AdminController : BaseController
{
	private readonly IAdminService adminService;
	private readonly IUserService userService;

	public AdminController(
		IAdminService adminService,
		IUserService userService)
	{
		this.adminService = adminService;
		this.userService = userService;
	}

	[HttpGet]
	public async Task<IActionResult> AddRole()
	{
		AddRoleViewModel form = new()
		{
			Roles = await adminService.GetAllRoles()
		};

		return View(form);
	}

	[HttpPost]
	public async Task<IActionResult> AddRole(AddRoleViewModel roleForm)
	{
		if (!ModelState.IsValid)
		{
			roleForm.Roles = await adminService.GetAllRoles();
			return View(roleForm);
		}

		if (await adminService.IsRoleExist(roleForm.RoleName))
		{
			TempData[ErrorMessage] = string.Format(ErrorMessages.RoleAlreadyExist, roleForm.RoleName);
			roleForm.Roles = await adminService.GetAllRoles();
			return View(roleForm);
		}

		try
		{
			await adminService.CreateRole(roleForm.RoleName);
			TempData[SuccessMessage] = string.Format(SuccessMessages.CreatedRole, roleForm.RoleName);
		}
		catch (Exception ex)
		{
			throw new ArgumentException(ex.Message, nameof(roleForm));
		}

		return RedirectToAction("Index", "Home");
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

		try
		{
			if (!await adminService.IsRoleExist(userToRoleForm.RoleName))
			{
				TempData[ErrorMessage] = string.Format(ErrorMessages.RoleDoesNotExist, userToRoleForm.RoleName);
				userToRoleForm.Roles = await adminService.GetAllRoles();
				return View(userToRoleForm);
			}

			if (!await userService.IsUserExistByEmailAsync(userToRoleForm.UserEmail))
			{
				TempData[ErrorMessage] = string.Format(ErrorMessages.UserDoesNotExist, userToRoleForm.UserEmail);
				userToRoleForm.Roles = await adminService.GetAllRoles();
				return View(userToRoleForm);
			}

			if(await adminService.IsUserHasRole(userToRoleForm.UserEmail, userToRoleForm.RoleName))
			{
				TempData[ErrorMessage] = string.Format(ErrorMessages.UserAlreadyHasARole, userToRoleForm.UserEmail, userToRoleForm.RoleName);
				userToRoleForm.Roles = await adminService.GetAllRoles();
				return View(userToRoleForm);
			}

			await adminService.AddUserToRoleAsync(userToRoleForm.UserEmail, userToRoleForm.RoleName);
			TempData[SuccessMessage] = string.Format(SuccessMessages.AddedUserToRole, userToRoleForm.UserEmail, userToRoleForm.RoleName);
		}
		catch (Exception ex)
		{
			throw new ArgumentException(ex.Message);
		}


		return RedirectToAction("Index", "Home");
	}
}
