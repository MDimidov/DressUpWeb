using DressUp.Web.ViewModels.Product;

namespace DressUp.Web.ViewModels.Store;

public class StoreDetailsViewModel : AllStoresViewModel
{
	public StoreDetailsViewModel()
	{
		
	}
	public string Address { get; set; }

	public string ContactInfo { get; set; }
}
