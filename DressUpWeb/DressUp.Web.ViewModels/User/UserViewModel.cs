namespace DressUp.Web.ViewModels.User;

public class UserViewModel
{
    public UserViewModel()
    {
        Roles = new List<string>();
    }

    public string Id { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FullName { get; set; }

    public IEnumerable<string> Roles { get; set; }
}
