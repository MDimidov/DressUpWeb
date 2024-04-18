using DressUp.Services.Data.Interfaces;
using DressUp.Web.Infrastructure.Extensions;
using DressUp.Web.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static DressUp.Common.NotificationMessagesConstants;
using static DressUp.Common.GeneralApplicationConstants;

namespace DressUp.Web.Controllers;

[AllowAnonymous]
public class HomeController : BaseController
{
	private readonly IStoreService storeService;
	public HomeController(IStoreService storeService)
	{
		this.storeService = storeService;
	}

	public async Task<IActionResult> Index()
	{
		if (User.IsAdmin())
		{
			return RedirectToAction(nameof(Index), "Home", new { Area = AdminAreaName });
		}

		IEnumerable<IndexViewModel> viewModel;

		try
		{
			// Show Last three open stores
			viewModel = await storeService.LastThreeOpenStoresAsync();
		}
		catch
		{
			TempData[ErrorMessage] = ErrorMessages.UnexpextedError;
			viewModel = new List<IndexViewModel>();
		}

		return View(viewModel);
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error(int statusCode)
	{
		if (statusCode == 400 || statusCode == 404)
		{
			return View("Error404");
		}
		else if (statusCode == 401)
		{
			return View("Error401");
		}

		return View();
	}
}
