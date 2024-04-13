using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
