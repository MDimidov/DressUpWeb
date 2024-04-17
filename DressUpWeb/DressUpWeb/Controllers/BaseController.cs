﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Web.Controllers
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class BaseController : Controller
    {
        
    }
}
