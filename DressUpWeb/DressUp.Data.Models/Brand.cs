#nullable disable

namespace DressUp.Data.Models;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Brand;

[Comment("Dress brand")]
public class Brand
{
    public Brand()
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
