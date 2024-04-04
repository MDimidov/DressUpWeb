using System.Security.Claims;

namespace DressUp.Web.Infrastructure.Extensions;

public static class ClaimsPrincipalExtensions
{
	public static string GetId(this ClaimsPrincipal user)
		=> user.FindFirst(ClaimTypes.NameIdentifier)!.Value;
}
