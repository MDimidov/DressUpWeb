using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Areas.Admin.Controllers;

public class HomeController : BaseAdminController
{
	public IActionResult Index()
	{
		return View();
	}
}
