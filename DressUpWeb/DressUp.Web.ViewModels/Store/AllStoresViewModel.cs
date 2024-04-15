#nullable disable

namespace DressUp.Web.ViewModels.Store;

public class AllStoresViewModel
{
	public int Id { get; set; }

	public string Name { get; set; }

	public string Address { get; set; }

	public string ContactInfo { get; set; }

	public string ImageUrl { get; set; }

	public DateTime OpeningTime { get; set; }

	public DateTime ClosingTime { get; set; }

	public bool Status
	{
		get =>
			OpeningTime.TimeOfDay <= DateTime.Now.TimeOfDay &&
			ClosingTime.TimeOfDay > DateTime.Now.TimeOfDay;
	}
}
