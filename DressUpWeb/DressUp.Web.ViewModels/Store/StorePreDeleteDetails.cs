#nullable disable

using System.ComponentModel.DataAnnotations;

namespace DressUp.Web.ViewModels.Store;

public class StorePreDeleteDetails
{
	public int Id { get; set; }

	public string Name { get; set; }

	[Display(Name = "Contact info")]
	public string ContactInfo { get; set; }

	public string ImageUrl {  get; set; }

	public string Address { get; set; }
}
