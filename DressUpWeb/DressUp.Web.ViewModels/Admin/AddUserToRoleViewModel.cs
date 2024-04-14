#nullable disable

using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Role;
namespace DressUp.Web.ViewModels.Admin;

public class AddUserToRoleViewModel
{
    public AddUserToRoleViewModel()
    {
        Roles = new List<RoleViewModel>();
    }

    [Required]
    [EmailAddress]
    public string UserEmail { get; set; }

    [Required]
    [StringLength(RoleNameMaxLength, MinimumLength = RoleNameMinLength)]

    public string RoleName { get; set; }

    [Required]
    public IEnumerable<RoleViewModel> Roles { get; set; }
}
