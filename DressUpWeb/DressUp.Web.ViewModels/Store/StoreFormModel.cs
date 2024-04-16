#nullable disable

using DressUp.Web.ViewModels.Address;
using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Store;

namespace DressUp.Web.ViewModels.Store;

public class StoreFormModel
{
	[Required]
	[StringLength(NameMaxLength, MinimumLength = NameMinLength)]
	public string Name { get; set; }

	[Required]
	[StringLength(ContactInfoMaxLength, MinimumLength = ContactInfoMinLength)]
	public string ContactInfo { get; set; }

	[Required]
	[MaxLength(ImageUrlMaxLength)]
	[Display(Name = "Image Link")]
	public string ImageUrl { get; set; }

	[Required]
	[Display(Name = "Opening time")]
	public DateTime OpeningTime { get; set; }

	[Required]
	[Display(Name = "Closing time")]
	public DateTime ClosingTime { get; set; }

	public AddressFormModel AddressForm { get; set; }
}
