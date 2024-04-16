using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DressUp.Web.ViewModels.Store;
using DressUp.Web.ViewModels.Address;
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
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
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
                return NotFound();
            }

            StoreDetailsViewModel viewModel = await storeService.GetStoreDetailsAsyncById(id);
            return View(viewModel);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        if (!User.IsAdmin())
        {
            TempData[ErrorMessage] = ErrorMessages.AdminToAdd;
            return RedirectToAction(nameof(All));
        }

        StoreFormModel model = new();
        model.AddressForm = new()
        {
            Cities = await addressService.GetAllCitiesAsync(),
            Countries = await addressService.GetAllCountriesAsync(),
        };

        return View(model);
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

        if (!User.IsAdmin())
        {
            TempData[ErrorMessage] = ErrorMessages.AdminToAdd;
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
        catch (Exception ex)
        {
            throw new InvalidOperationException(ex.Message);
        }

        return RedirectToAction(nameof(All));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        if (!User.IsAdmin())
        {
            TempData[ErrorMessage] = ErrorMessages.AdminToEdit;
            return RedirectToAction(nameof(All));
        }

        try
        {

            if (!await storeService.IsStoreExistByIdAsync(id))
            {
                TempData[ErrorMessage] = ErrorMessages.StoreDoesNotExist;
                return RedirectToAction(nameof(All));
            }

            StoreFormModel formModel = await storeService.GetStoreByIdAsync(id);
            formModel.AddressForm.Cities = await addressService.GetAllCitiesAsync();
            formModel.AddressForm.Countries = await addressService.GetAllCountriesAsync();

            return View(formModel);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Edit(StoreFormModel formModel, int id)
    {
        return Ok();
    }
}
