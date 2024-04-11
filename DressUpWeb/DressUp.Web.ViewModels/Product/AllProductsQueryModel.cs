namespace DressUp.Web.ViewModels.Product;

using DressUp.Data.Models.Enums;
using DressUp.Web.ViewModels.Product.Enums;
using System.ComponentModel.DataAnnotations;
using static DressUp.Common.GeneralApplicationConstants;

public class AllProductsQueryModel
{
    public AllProductsQueryModel()
    {
        CurrentPage = DefaultPage;
        ProductsPerPage = EntitiesPerPage;

        Categories = new HashSet<string>();
        Brands = new HashSet<string>();
		SizeTypes = new HashSet<SizeType>();
        Products = new HashSet<AllProductsViewModel>();
    }

    public string? Category { get; set; }

    public string? Brand { get; set; }

    [Display(Name = "Dress for")]
    public SizeType? SizeType { get; set; }

    [Display(Name = "Search by word")]
    public string? SearchString { get; set; }

    [Display(Name = "Sort Products By")]
    public ProductSorting ProductSorting { get; set; }

    public int CurrentPage { get; set; }

    [Display(Name = "Show Products On Page")]
    public int ProductsPerPage { get; set; }

    public int TotalProducts { get; set; }

    public IEnumerable<string> Categories { get; set; }

    public IEnumerable<string> Brands { get; set; }

    public IEnumerable<SizeType> SizeTypes { get; set; }

    public IEnumerable<AllProductsViewModel> Products { get; set; }
}
