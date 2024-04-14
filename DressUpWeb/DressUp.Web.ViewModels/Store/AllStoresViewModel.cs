#nullable disable

using DressUp.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DressUp.Web.ViewModels.Store;

public class AllStoresViewModel
{
	public string Name { get; set; }
	
	public string Address { get; set; }
	
	public string ContactInfo { get; set; }

	public string ImageUrl { get; set; }

	public DateTime OpeningTime { get; set; }
	
	public DateTime ClosingTime { get; set; }
}
