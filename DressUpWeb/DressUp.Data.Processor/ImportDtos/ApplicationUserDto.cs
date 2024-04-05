#nullable disable

using DressUp.Data.Models.Enums;

namespace DressUp.Data.Processor.ImportDtos;

public class ApplicationUserDTO
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string NormalizedEmail { get; set; }
    public string UserName { get; set; }
    public string NormalizedUserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public GenderType Gender { get; set; }
    public bool EmailConfirmed { get; set; }
    public string SecurityStamp { get; set; }
}
