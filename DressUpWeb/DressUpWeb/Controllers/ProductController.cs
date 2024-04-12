using DressUp.Data.Models.Enums;
using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data.Models.Product;
using DressUp.Web.Infrastructure.Extensions;
using DressUp.Web.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static DressUp.Common.NotificationMessagesConstants;

namespace DressUp.Web.Controllers;


public class ProductController : BaseController
{
	private readonly IProductService productService;
	private readonly IFavoriteService favoriteService;
	private readonly IBrandService brandService;
	private readonly ICategoryService categoryService;

	public ProductController(
		IProductService productService,
		IFavoriteService favoriteService,
		IBrandService brandService,
		ICategoryService categoryService)
	{
		this.productService = productService;
		this.favoriteService = favoriteService;
		this.brandService = brandService;
		this.categoryService = categoryService;
	}

	[HttpGet]
	[AllowAnonymous]
	public async Task<IActionResult> All([FromQuery]AllProductsQueryModel queryModel)
	{
		AllProductsFilteredAndPagedServiceModel serviceModel = await productService.AllAsync(queryModel);

		queryModel.Products = serviceModel.Products;
		queryModel.TotalProducts = serviceModel.TotalProductsCount;
		queryModel.Categories = await categoryService.GetCategoriesNamesAsync();
		queryModel.Brands = await brandService.GetBrandsNameAsync();
		queryModel.SizeTypes = productService.GetAllSizeTypes();


		return View(queryModel);
	}


	public async Task<IActionResult> AddToFavorite(int productId)
	{
		if(!User.Identity?.IsAuthenticated ?? false)
		{
			TempData[ErrorMessage] = ErrorMessages.YouMustLogedInToAddFavorite;
			return RedirectToAction("Index", "Home");
		}

		try
		{
			bool isProductExist = await productService.IsProductExistByIdAsync(productId);
			if (!isProductExist)
			{
				TempData[ErrorMessage] = ErrorMessages.InvalidProductToFavorite;
				return BadRequest();
			}
			await favoriteService.AddToFavoriteAsync(productId, User.GetId());
			TempData[SuccessMessage] = SuccessMessages.AddedToFavorite;
		}
		catch
		{
			throw new ArgumentException("Product is already added to favorites or does not exist");
		}

		return RedirectToAction(nameof(All));
	}

	public async Task<IActionResult> Favorite()
	{
		if (User.Identity?.IsAuthenticated ?? false)
		{
			AllProductsQueryModel viewModel = new();

            try
			{
				viewModel.Products = await favoriteService.GetFavoriteProductsAsync(User.GetId());
            }			
			catch (Exception ex)
			{
				throw new ArgumentException(ex.Message);
			}

			return View(viewModel);
		}

        TempData[ErrorMessage] = ErrorMessages.YouMustLogedInToSeeFavorite;
        return RedirectToAction(nameof(All));
	}

	public async Task<IActionResult> Add()
	{
		ProductFormModel formModel = new()
		{
			Brands = await brandService.GetAllBrandsAsync(),
			Categories = await categoryService.GetAllCategoriesAsync(),
			SizeTypes = productService.GetAllSizeTypes()
		};


		return View(formModel);
	}

	[HttpPost]
	public async Task<IActionResult> Add(ProductFormModel formModel)
	{
		if (!ModelState.IsValid)
		{
			return View(formModel);
		}

		await productService.AddProductAsync(formModel);
		return RedirectToAction(nameof(All));
	}

	[HttpGet]
	public async Task<IActionResult> Edit(int id)
	{
		ProductFormModel formModel = await productService.GetProductByIdAsync(id);

		formModel.Brands = await brandService.GetAllBrandsAsync();
		formModel.Categories = await categoryService.GetAllCategoriesAsync();
		formModel.SizeTypes = productService.GetAllSizeTypes();

		return View(formModel);
	}

	[HttpPost]
	public async Task<IActionResult> Edit(ProductFormModel formModel, int id)
	{
		formModel.Brands = await brandService.GetAllBrandsAsync();
		formModel.Categories = await categoryService.GetAllCategoriesAsync();
		formModel.SizeTypes = productService.GetAllSizeTypes();

		if (!ModelState.IsValid)
		{
			return View(formModel);
		}

		await productService.EditProductAsync(formModel, id);
		return RedirectToAction(nameof(All));
	}

	[HttpGet]
	public async Task<IActionResult> Details(int id)
	{
		ProductDetailsViewModel model = await productService.GetProductDetailsByIdAsync(id);
		return View(model);
	}

	public async Task<IActionResult> Delete(int id)
	{
		if (await productService.IsProductExistByIdAsync(id))
		{
			ProductPreDeleteDetails model = await productService.GetProductPreDeleteDetailsByIdAsync(id);

			return View(model);
		}

		return BadRequest();
	}

	[HttpPost]
	public async Task<IActionResult> Delete(ProductPreDeleteDetails model, int id)
	{
		if (await productService.IsProductExistByIdAsync(id))
		{
			await productService.DeleteProductByIdAsync(id);


			return RedirectToAction(nameof(All));
		}

		return View(model);
	}
}
