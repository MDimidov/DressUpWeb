
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DressUp.Common.EntityValidationConstants.ProductReview;

namespace DressUp.Data.Models;

public class ProductReview
{
    public ProductReview()
    {
        Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(TitleMaxLength)]
    public string Title { get; set; } = null!;

    [MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }

    [Required]
    public int Rate { get; set; }

    [Required]
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual ApplicationUser User { get; set; } = null!;

}
