using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Controllers;

[AllowAnonymous]
public class ProductController : BaseController
{
    private readonly IProductService productService;

    public ProductController(IProductService productService)
    {
        this.productService = productService;
    }

    public async Task<IActionResult> Men()
    {
        AllProductsQueryModel model = new()
        {
            Products = await productService.GetMenProductsAsync()
        };

        return View(model);
    }

    public async Task<IActionResult> All()
    {
        AllProductsQueryModel model = new()
        {
            Products = await productService.GetAllProductsAsync()
        };

        return View(model);
    }
<<<<<<< HEAD


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
        if (User.Identity?.IsAuthenticated ?? false)
        {
            AllProductsQueryModel viewModel = new()
            {
                Products = await favoriteService.GetFavoriteProductsAsync(User.GetId())
            };

            return View(viewModel);
        }

        return RedirectToAction(nameof(All));
    }
=======
>>>>>>> parent of e896abb (Add Favorite products)
}
