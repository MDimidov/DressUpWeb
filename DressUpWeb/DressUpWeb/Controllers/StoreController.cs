using DressUp.Services.Data.Models.Product;
using DressUp.Services.Data;
using DressUp.Web.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Controllers;

public class StoreController : BaseController
{
	//[HttpGet]
	//[AllowAnonymous]
	//public async Task<IActionResult> All([FromQuery] AllProductsQueryModel queryModel)
	//{
	//	try
	//	{
	//		AllProductsFilteredAndPagedServiceModel serviceModel = await productService.AllAsync(queryModel);

	//		queryModel.Products = serviceModel.Products;
	//		queryModel.TotalProducts = serviceModel.TotalProductsCount;
	//		queryModel.Categories = await categoryService.GetCategoriesNamesAsync();
	//		queryModel.Brands = await brandService.GetBrandsNameAsync();
	//		queryModel.SizeTypes = productService.GetAllSizeTypes();


	//		return View(queryModel);
	//	}
	//	catch (Exception ex)
	//	{
	//		throw new ArgumentException(ex.Message);
	//	}
	//}
}
