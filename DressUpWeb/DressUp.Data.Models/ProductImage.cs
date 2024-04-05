#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DressUp.Data.Models;
using static DressUp.Common.EntityValidationConstants.ProductImage;

public class ProductImage
{
    public ProductImage()
    {
        Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

    [Required]
    [MaxLength(ImageUrlMaxLength)]
    public string ImageUrl { get; set; }
}
