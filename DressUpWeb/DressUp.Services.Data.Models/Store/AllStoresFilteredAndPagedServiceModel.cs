using DressUp.Web.ViewModels.Store;

namespace DressUp.Services.Data.Models.Store;

public class AllStoresFilteredAndPagedServiceModel
{
	public AllStoresFilteredAndPagedServiceModel()
	{
		Stores = new HashSet<AllStoresViewModel>();
	}
	public int TotalProductsCount { get; set; }

	public IEnumerable<AllStoresViewModel> Stores { get; set; }
}
