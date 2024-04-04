using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Controllers;

public class BrandController : BaseController
{
    public IActionResult Index()
    {
        return View();
    }
}
