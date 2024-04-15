using DressUp.Services.Data.Models.Product;
using DressUp.Services.Data;
using DressUp.Web.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DressUp.Web.ViewModels.Store;
using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data.Models.Store;

namespace DressUp.Web.Controllers;

public class StoreController : BaseController
{
	private readonly IStoreService storeService;

	public StoreController(IStoreService storeService)
	{
		this.storeService = storeService;
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
}
