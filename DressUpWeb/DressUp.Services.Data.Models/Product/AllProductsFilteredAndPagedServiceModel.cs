using DressUp.Web.ViewModels.Product;

namespace DressUp.Services.Data.Models.Product;

public class AllProductsFilteredAndPagedServiceModel
{
	public AllProductsFilteredAndPagedServiceModel()
	{
		Products = new HashSet<AllProductsViewModel>();
	}
	public int TotalProductsCount { get; set; }

	public IEnumerable<AllProductsViewModel> Products { get; set; }
}
 