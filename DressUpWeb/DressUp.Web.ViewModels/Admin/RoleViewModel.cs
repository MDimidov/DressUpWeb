#nullable disable

using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Role;
namespace DressUp.Web.ViewModels.Admin;

public class RoleViewModel
{
    [Required]
    public string Id { get; set; }

    [Required]
    [StringLength(RoleNameMaxLength, MinimumLength = RoleNameMinLength)]

    public string RoleName { get; set; }
}
