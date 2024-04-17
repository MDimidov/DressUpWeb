using System.Security.Claims;
using static DressUp.Common.GeneralApplicationConstants;

namespace DressUp.Web.Infrastructure.Extensions;

public static class ClaimsPrincipalExtensions
{
	public static string GetId(this ClaimsPrincipal user)
		=> user.FindFirst(ClaimTypes.NameIdentifier)!.Value;

	public static bool IsAdmin(this ClaimsPrincipal user)
		=> user.IsInRole(AdminRoleName);

	public static bool IsModerator(this ClaimsPrincipal user)
		=> user.IsInRole(ModeratorRoleName);
}
