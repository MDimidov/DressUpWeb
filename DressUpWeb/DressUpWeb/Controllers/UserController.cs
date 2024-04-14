using DressUp.Data.Models;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.User;
using Griesoft.AspNetCore.ReCaptcha;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static DressUp.Common.NotificationMessagesConstants;

namespace DressUp.Web.Controllers
{
	[AllowAnonymous]
	public class UserController : BaseController
	{
		private readonly SignInManager<ApplicationUser> signInManager;
		private readonly UserManager<ApplicationUser> userManager;
		private readonly IUserStore<ApplicationUser> userStore;
		private readonly IUserService userService;

		public UserController(
			SignInManager<ApplicationUser> signInManager,
			UserManager<ApplicationUser> userManager,
			IUserStore<ApplicationUser> userStore,
			IUserService userService)
		{
			this.signInManager = signInManager;
			this.userManager = userManager;
			this.userStore = userStore;
			this.userService = userService;
		}

		[HttpGet]
		public IActionResult Register()
		{
			if (User.Identity?.IsAuthenticated ?? false)
			{
				TempData[ErrorMessage] = ErrorMessages.AlreadyRegistered;
				return RedirectToAction("Index", "Home");
			}

			return View();
		}

		[HttpPost]
		[ValidateRecaptcha(Action = nameof(Register),
			ValidationFailedAction = ValidationFailedAction.ContinueRequest)]
		public async Task<IActionResult> Register(RegisterFormModel model)
		{
			if (User.Identity?.IsAuthenticated ?? false)
			{
				return RedirectToAction("Index", "Home");
			}

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			ApplicationUser user = new ApplicationUser()
			{
				FirstName = model.FirstName,
				LastName = model.LastName
			};

			await userManager.SetEmailAsync(user, model.Email);
			await userManager.SetUserNameAsync(user, model.Email);

			IdentityResult result =
				await userManager.CreateAsync(user, model.Password);

			if (!result.Succeeded)
			{
				foreach (IdentityError error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}

				return View(model);
			}

			await signInManager.SignInAsync(user, false);
			//this.memoryCache.Remove(UsersCacheKey);

			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult Login(string? returnUrl = null)
		{
			if (User.Identity?.IsAuthenticated ?? false)
			{
				TempData[ErrorMessage] = ErrorMessages.AlreadyLogedIn;
				return RedirectToAction("Index", "Home");
			}

			LoginFormModel model = new LoginFormModel()
			{
				ReturnUrl = returnUrl
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginFormModel model)
		{
			if (User.Identity?.IsAuthenticated ?? false)
			{
				TempData[ErrorMessage] = ErrorMessages.AlreadyLogedIn;
				return RedirectToAction("Index", "Home");
			}

			if (!await userService.IsUserExistByEmailAsync(model.Email))
			{
				ModelState.AddModelError(nameof(model.Email), "User with this Email dose not exist in the system.");
			}

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			var signInResult =
				await signInManager.PasswordSignInAsync(model.Email, model.Password,
														model.RememberMe, false);

			if (!signInResult.Succeeded)
			{
				TempData[ErrorMessage] = ErrorMessages.LogInError;

				return View(model);
			}

			return Redirect(model.ReturnUrl ?? "/Home/Index");
		}
	}
}
