using DressUp.Services.Data;
using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data.Models.Product;
using DressUp.Web.Infrastructure.Extensions;
using DressUp.Web.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using static DressUp.Common.NotificationMessagesConstants;

namespace DressUp.Web.Areas.Admin.Controllers;

public class Product : BaseAdminController
{
	private readonly IProductService productService;
	private readonly IFavoriteService favoriteService;
	private readonly ICategoryService categoryService;
	private readonly IBrandService brandService;

	public  Product(
		IProductService productService,
		IFavoriteService favoriteService,
		ICategoryService categoryService,
		IBrandService brandService)
	{
		this.productService = productService;
		this.favoriteService = favoriteService;
		this.categoryService = categoryService;
		this.brandService = brandService;
	}

	public async Task<IActionResult> Favorite([FromQuery] AllProductsQueryModel queryModel)
	{
		try
		{
			AllProductsFilteredAndPagedServiceModel serviceModel =
				await favoriteService.AllFavoritesAsync(queryModel, User.GetId());

			queryModel.Products = serviceModel.Products;
			queryModel.TotalProducts = serviceModel.TotalProductsCount;
			queryModel.Categories = await categoryService.GetCategoriesNamesAsync();
			queryModel.Brands = await brandService.GetBrandsNameAsync();
			queryModel.SizeTypes = productService.GetAllSizeTypes();

			return View(queryModel);
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
