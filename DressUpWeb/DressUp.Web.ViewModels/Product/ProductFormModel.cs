#nullable disable

using System.ComponentModel.DataAnnotations;
using DressUp.Web.ViewModels.Brand;
using DressUp.Web.ViewModels.Category;
using DressUp.Data.Models.Enums;
using System.ComponentModel;
using static DressUp.Common.EntityValidationConstants.Product;

namespace DressUp.Web.ViewModels.Product;

public class ProductFormModel
{
    public ProductFormModel()
    {
        Brands = new HashSet<AllBrandsViewModel>();
        Categories = new HashSet<AllCategoriesViewModel>();
        SizeTypes = new HashSet<SizeType>();
        Images = new HashSet<ProductImagesViewModel>();
    }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string Name { get; set; }

    [Required]
    [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
    public string Description { get; set; }

    [DisplayName("Brand")]
    public int BrandId { get; set; }

    [Required]
    public IEnumerable<AllBrandsViewModel> Brands { get; set; }

    [DisplayName("Category")]
    public int CategoryId { get; set; }

    [Required]
    public IEnumerable<AllCategoriesViewModel> Categories { get; set; }

    [DisplayName("Dress for")]
    public SizeType SizeType { get; set; }

    [Required]
    public IEnumerable<SizeType> SizeTypes { get; set; }

    [Required]
    [Range(typeof(decimal), PriceMinRange, PriceMaxRange)]
    public decimal Price { get; set; }

    [Required]
    public int Quantity { get; set; }

    public ICollection<ProductImagesViewModel> Images { get; set; }
}
