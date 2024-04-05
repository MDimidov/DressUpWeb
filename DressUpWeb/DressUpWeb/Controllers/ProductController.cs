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
        return View();
    }

    public async Task<IActionResult> All()
    {
        AllProductsQueryModel model = new()
        {
            
            Products = await productService.GetAllProductsAsync()
        };

        return View(model);
    }
}
