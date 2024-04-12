using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Controllers;

public class BrandController : BaseController
{
    public IActionResult All()
    {
        return View();
    }
}
