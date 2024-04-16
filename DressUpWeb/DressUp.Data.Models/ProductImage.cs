#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using static DressUp.Common.EntityValidationConstants.ProductImage;

[Comment("Image link for Product")]
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
    [Comment("Image link")]
    public string ImageUrl { get; set; }
}
