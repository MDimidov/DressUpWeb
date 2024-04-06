using DressUp.Services.Data.Interfaces;
using DressUp.Web.Infrastructure.Extensions;
using DressUp.Web.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Controllers;


public class ProductController : BaseController
{
    private readonly IProductService productService;
    private readonly IFavoriteService favoriteService;

    public ProductController(
        IProductService productService,
        IFavoriteService favoriteService)
    {
        this.productService = productService;
        this.favoriteService = favoriteService;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Men()
    {
        AllProductsQueryModel model = new()
        {
            Products = await productService.GetMenProductsAsync()
        };

        return View(model);
    }

    [AllowAnonymous]
    public async Task<IActionResult> All()
    {
        AllProductsQueryModel model = new()
        {
            Products = await productService.GetAllProductsAsync()
        };

        return View(model);
    }


    public async Task<IActionResult> AddToFavorite(int productId)
    {
        try
        {
            await favoriteService.AddToFavoriteAsync(productId, User.GetId());
        }
        catch
        {
            throw new ArgumentException("Product is already added to favorites");
        }

        return RedirectToAction(nameof(All));
    }

    public async Task<IActionResult> Favorite()
    {
        AllProductsQueryModel viewModel = new()
        {
            Products = await favoriteService.GetFavoriteProductsAsync(User.GetId())
        };
        return View(viewModel);

    }
}
