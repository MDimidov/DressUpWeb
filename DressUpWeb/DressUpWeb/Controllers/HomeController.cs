using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DressUp.Web.Controllers;

//[AllowAnonymous]
public class HomeController : BaseController
{
    private readonly IStoreService storeService;
    public HomeController(IStoreService storeService)
    {
        this.storeService = storeService;
    }

    public async Task<IActionResult> Index()
    {
        IEnumerable<IndexViewModel> viewModel = await storeService.LastThreeStoresAsync();
        return View(viewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
