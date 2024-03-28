#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DressUp.Common.EntityValidationConstants.Product;

namespace DressUp.Data.Models;

public class Product
{
    public Product()
    {
        StoresProducts = new HashSet<StoreProduct>();
        Favorites = new HashSet<Favorite>();
        BuyedProducts = new HashSet<BuyedProduct>();
        ProductReviews = new HashSet<ProductReview>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; }

    [Required]
    [MaxLength(DescriptionMaxLength)]
    public string Description { get; set; }

    [Required]
    [ForeignKey(nameof(Brand))]
    public int BrandId { get; set; }
    public virtual Brand Brand { get; set; }

    [Required]
    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public int Quantity { get; set; }

    public virtual ICollection<StoreProduct> StoresProducts { get; set; }
    public virtual ICollection<Favorite> Favorites { get; set; }
    public virtual ICollection<BuyedProduct> BuyedProducts { get; set; }
    public virtual ICollection<ProductReview> ProductReviews { get; set; }
    //public virtual ICollection<ProductSize> ProductsSizes { get; set; } = new HashSet<ProductSize>();
}
