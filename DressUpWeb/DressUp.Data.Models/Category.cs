#nullable disable

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Category;
namespace DressUp.Data.Models;

[Comment("Dress category")]
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
