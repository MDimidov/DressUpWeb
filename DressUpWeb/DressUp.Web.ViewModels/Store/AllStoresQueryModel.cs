using DressUp.Web.ViewModels.Store.Enums;
using System.ComponentModel.DataAnnotations;
using static DressUp.Common.GeneralApplicationConstants;

namespace DressUp.Web.ViewModels.Store;

public class AllStoresQueryModel
{
	public AllStoresQueryModel()
	{
		CurrentPage = DefaultPage;
		StoresPerPage = EntitiesPerPage;

		Stores = new HashSet<AllStoresViewModel>();
		StoreStatuses = new HashSet<StoreStatus>();
	}

	[Display(Name = "Search by word")]
	public string? SearchString { get; set; }

	[Display(Name = "Status")]
	public StoreStatus? StoreStatus { get; set; }

	public int CurrentPage { get; set; }

	[Display(Name = "Show Stores On Page")]
	public int StoresPerPage { get; set; }

	public int TotalStores { get; set; }

	public IEnumerable<AllStoresViewModel> Stores { get; set; }

	public IEnumerable<StoreStatus> StoreStatuses { get; set; }
}
