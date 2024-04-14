using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Controllers;

public class StoreController : BaseController
{
	public IActionResult Index()
	{
		return View();
	}
}
