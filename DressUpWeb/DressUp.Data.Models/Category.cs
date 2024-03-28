#nullable disable

using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Category;
namespace DressUp.Data.Models;

public class Category
{
    public Category()
    {
        Products = new HashSet<Product>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}
