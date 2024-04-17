using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DressUp.Web.ViewModels.Store;
using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data.Models.Store;
using DressUp.Web.Infrastructure.Extensions;
using static DressUp.Common.NotificationMessagesConstants;

namespace DressUp.Web.Controllers;

public class StoreController : BaseController
{
	private readonly IStoreService storeService;
	private readonly IAddressService addressService;

	public StoreController(
		IStoreService storeService,
		IAddressService addressService)
	{
		this.storeService = storeService;
		this.addressService = addressService;
	}



	[HttpGet]
	[AllowAnonymous]
	public async Task<IActionResult> All([FromQuery] AllStoresQueryModel queryModel)
	{
		try
		{
			AllStoresFilteredAndPagedServiceModel serviceModel = await storeService.AllStoresAsync(queryModel);

			queryModel.Stores = serviceModel.Stores;
			queryModel.TotalStores = serviceModel.TotalStoresCount;
			queryModel.StoreStatuses = storeService.GetAllStoreStatus();

			return View(queryModel);
		}
		catch
		{
			return GeneralError();
		}
	}

	[HttpGet]
	[AllowAnonymous]
	public async Task<IActionResult> Details(int id)
	{
		try
		{
			if (!await storeService.IsStoreExistByIdAsync(id))
			{
				TempData[ErrorMessage] = ErrorMessages.StoreDoesNotExist;
				return NotFound();
			}

			StoreDetailsViewModel viewModel = await storeService.GetStoreDetailsAsyncById(id);
			return View(viewModel);
		}
		catch
		{
			return GeneralError();
		}
	}

	[HttpGet]
	public async Task<IActionResult> Add()
	{
		if (!User.IsAdmin() && !User.IsModerator())
		{
			TempData[ErrorMessage] = ErrorMessages.AdminOrModeratorToAddStore;
			return RedirectToAction(nameof(All));
		}

		try
		{
			StoreFormModel model = new();
			model.AddressForm = new()
			{
				Cities = await addressService.GetAllCitiesAsync(),
				Countries = await addressService.GetAllCountriesAsync(),
			};

			return View(model);
		}
		catch
		{
			return GeneralError();
		}
	}

	[HttpPost]
	public async Task<IActionResult> Add(StoreFormModel formModel)
	{
		if (!ModelState.IsValid)
		{
			formModel.AddressForm.Cities = await addressService.GetAllCitiesAsync();
			formModel.AddressForm.Countries = await addressService.GetAllCountriesAsync();

			return View(formModel);
		}

		if (!User.IsAdmin() && !User.IsModerator())
		{
			TempData[ErrorMessage] = ErrorMessages.AdminOrModeratorToAddStore;
			return RedirectToAction(nameof(All));
		}

		try
		{
			if (!await addressService.IsCityExistByIdAsync(formModel.AddressForm.CityId))
			{
				TempData[ErrorMessage] = ErrorMessages.CityDoesNotExist;

				formModel.AddressForm.Cities = await addressService.GetAllCitiesAsync();
				formModel.AddressForm.Countries = await addressService.GetAllCountriesAsync();

				return View(formModel);
			}

			if (!await addressService.IsCountryExistByIdAsync(formModel.AddressForm.CountryId))
			{
				TempData[ErrorMessage] = ErrorMessages.CountryDoesNotExist;

				formModel.AddressForm.Cities = await addressService.GetAllCitiesAsync();
				formModel.AddressForm.Countries = await addressService.GetAllCountriesAsync();

				return View(formModel);
			}

			await storeService.AddStoreAsync(formModel);
			TempData[SuccessMessage] = SuccessMessages.AddedStore;
		}
		catch
		{
			return GeneralError();
		}

		return RedirectToAction(nameof(All));
	}

	[HttpGet]
	public async Task<IActionResult> Edit(int id)
	{
		if (!User.IsAdmin() && !User.IsModerator())
		{
			TempData[ErrorMessage] = ErrorMessages.AdminOrModeratorToEditStore;
			return RedirectToAction(nameof(All));
		}

		try
		{
			if (!await storeService.IsStoreExistByIdAsync(id))
			{
				TempData[ErrorMessage] = ErrorMessages.StoreDoesNotExist;
				return NotFound();
			}

			StoreFormModel formModel = await storeService.GetStoreByIdAsync(id);
			formModel.AddressForm.Cities = await addressService.GetAllCitiesAsync();
			formModel.AddressForm.Countries = await addressService.GetAllCountriesAsync();

			return View(formModel);
		}
		catch
		{
			return GeneralError();
		}
	}

	[HttpPost]
	public async Task<IActionResult> Edit(StoreFormModel formModel, int id)
	{
		if (!User.IsAdmin() && !User.IsModerator())
		{
			TempData[ErrorMessage] = ErrorMessages.AdminOrModeratorToEditStore;
			return RedirectToAction(nameof(All));
		}

		if (!ModelState.IsValid)
		{
			formModel.AddressForm.Cities = await addressService.GetAllCitiesAsync();
			formModel.AddressForm.Countries = await addressService.GetAllCountriesAsync();
			return View(formModel);
		}

		try
		{
			if (!await storeService.IsStoreExistByIdAsync(id))
			{
				TempData[ErrorMessage] = ErrorMessages.StoreDoesNotExist;
				return NotFound();
			}

			await storeService.EditStoreAsync(formModel, id);
			TempData[SuccessMessage] = string.Format(SuccessMessages.EditedStore, formModel.Name);
			return RedirectToAction(nameof(All));
		}
		catch
		{
			return GeneralError();
		}
	}

	[HttpGet]
	public async Task<IActionResult> Delete(int id)
	{
		if (!User.IsAdmin() && !User.IsModerator())
		{
			TempData[ErrorMessage] = ErrorMessages.AdminOrModeratorToEditStore;
			return RedirectToAction(nameof(All));
		}

		try
		{
			if (!await storeService.IsStoreExistByIdAsync(id))
			{
				TempData[ErrorMessage] = ErrorMessages.StoreDoesNotExist;
				return NotFound();
			}

			StorePreDeleteDetails formModel = await storeService.GetProductPreDeleteDetailsByIdAsync(id);

			return View(formModel);
		}
		catch
		{
			return GeneralError();
		}
	}

	[HttpPost]
	public async Task<IActionResult> Delete(StorePreDeleteDetails formModel, int id)
	{
		if (!User.IsAdmin() && !User.IsModerator())
		{
			TempData[ErrorMessage] = ErrorMessages.AdminOrModeratorToEditStore;
			return RedirectToAction(nameof(All));
		}

		try
		{
			if (!await storeService.IsStoreExistByIdAsync(id))
			{
				TempData[ErrorMessage] = ErrorMessages.StoreDoesNotExist;
				return NotFound();
			}

			await storeService.DeleteStoreByIdAsync(id);
			TempData[WarningMessage] = WarningMessages.DeletedStore;
			return RedirectToAction(nameof(All));
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
