using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static DressUp.Common.GeneralApplicationConstants;
using static DressUp.Common.NotificationMessagesConstants;

namespace DressUp.Web.Controllers;

// Controller Only Admin has Access to it
[Authorize(Roles = AdminRoleName)]
public class AdminController : BaseController
{
	
}
