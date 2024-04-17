using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static DressUp.Common.GeneralApplicationConstants;
using static DressUp.Common.NotificationMessagesConstants;

namespace DressUp.Web.Controllers;

// Controller Only Admin has Access to it
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

	// Action to Add or Delete role
	[HttpGet]
	public async Task<IActionResult> AddDeleteRole()
	{
		try
		{
			AddRoleViewModel form = new()
			{
				// Get all existing roles and returned it with model
				Roles = await adminService.GetAllRoles()
			};

			return View(form);
		}
		catch
		{
			return GeneralError();
		}
	}

	// Action to Add or Delete role
	[HttpPost]
	public async Task<IActionResult> AddDeleteRole(AddRoleViewModel roleForm)
	{
		if (!ModelState.IsValid)
		{
			// Get all existing roles and returned it with model
			roleForm.Roles = await adminService.GetAllRoles();
			return View(roleForm);
		}

		try
		{
			if (await adminService.IsRoleExist(roleForm.RoleName))
			{
				// If role exist add error message to ModelState
				ModelState.AddModelError(nameof(roleForm.RoleName),
					string.Format(ErrorMessages.RoleAlreadyExist, roleForm.RoleName)); ;

				// Get all existing roles and returned it with model
				roleForm.Roles = await adminService.GetAllRoles();
				return View(roleForm);
			}

			await adminService.CreateRole(roleForm.RoleName);
			TempData[SuccessMessage] = string.Format(SuccessMessages.CreatedRole, roleForm.RoleName);
		}
		catch
		{
			return GeneralError();
		}

		// After creating role return it to the same page
		return RedirectToAction(nameof(AddDeleteRole));
	}

	// Action to Add user in role
	[HttpGet]
	public async Task<IActionResult> AddUserToRolе()
	{
		try
		{
			AddUserToRoleViewModel formModel = new()
			{
				// Get all existing roles and returned it with model
				Roles = await adminService.GetAllRoles()
			};

			return View(formModel);
		}
		catch
		{
			return GeneralError();
		}
	}

	[HttpPost]
	public async Task<IActionResult> AddUserToRolе(AddUserToRoleViewModel userToRoleForm)
	{
		if (!ModelState.IsValid)
		{
			// Get all existing roles and returned it with model
			userToRoleForm.Roles = await adminService.GetAllRoles();
			return View(userToRoleForm);
		}

		try
		{
			if (!await adminService.IsRoleExist(userToRoleForm.RoleName))
			{
				ModelState.AddModelError(nameof(userToRoleForm.RoleName), 
					string.Format(ErrorMessages.RoleDoesNotExist, userToRoleForm.RoleName));

				// Get all existing roles and returned it with model
				userToRoleForm.Roles = await adminService.GetAllRoles();
				return View(userToRoleForm);
			}

			if (!await userService.IsUserExistByEmailAsync(userToRoleForm.UserEmail))
			{
				ModelState.AddModelError(nameof(userToRoleForm.UserEmail),
					string.Format(ErrorMessages.UserDoesNotExist, userToRoleForm.UserEmail));

				// Get all existing roles and returned it with model
				userToRoleForm.Roles = await adminService.GetAllRoles();
				return View(userToRoleForm);
			}

			if (await adminService.IsUserHasRole(userToRoleForm.UserEmail, userToRoleForm.RoleName))
			{
				ModelState.AddModelError(nameof(userToRoleForm.UserEmail), 
					string.Format(ErrorMessages.UserAlreadyHasARole, userToRoleForm.UserEmail, userToRoleForm.RoleName));

				// Get all existing roles and returned it with model
				userToRoleForm.Roles = await adminService.GetAllRoles();
				return View(userToRoleForm);
			}

			await adminService.AddUserToRoleAsync(userToRoleForm.UserEmail, userToRoleForm.RoleName);
			TempData[SuccessMessage] = string.Format(SuccessMessages.AddedUserToRole, 
				userToRoleForm.UserEmail, userToRoleForm.RoleName);
		}
		catch
		{
			return GeneralError();
		}

		// After adding user to role return it to the same page
		return RedirectToAction(nameof(AddUserToRolе));
	}

	// Delete Role if it exist
	[HttpGet]
	public async Task<IActionResult> DeleteRole(string roleId, string roleName)
	{
		try
		{
			// If role does not exist redirecto to AddDeleteRole Action
			if (!await adminService.IsRoleExist(roleName))
			{
				TempData[ErrorMessage] = string.Format(ErrorMessages.RoleDoesNotExist, roleName);
				return RedirectToAction(nameof(AddDeleteRole));
			}

			await adminService.DeleteRoleAsync(roleName, roleId);
			TempData[WarningMessage] = string.Format(WarningMessages.DeletedRole, roleName);

			return RedirectToAction(nameof(AddDeleteRole));
		}
		catch
		{
			return GeneralError();
		}
	}

	private IActionResult GeneralError()
	{
		TempData[ErrorMessage] = ErrorMessages.UnexpextedError;


		return RedirectToAction("Index", "Home");
	}
}
