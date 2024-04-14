using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Store;

namespace DressUp.Web.ViewModels.Store;

public class StoreFormModel
{
	[Required]
	[StringLength(NameMaxLength, MinimumLength = NameMinLength)]
	public string Name { get; set; }

	[Required]
	public string AddressId { get; set; }

	[Required]
	[StringLength(ContactInfoMaxLength, MinimumLength = ContactInfoMinLength)]
	public string ContactInfo { get; set; }

	[Required]
	[MaxLength(ImageUrlMaxLength)]
	public string ImageUrl { get; set; }

	[Required]
	public DateTime OpeningTime { get; set; }

	[Required]
	public DateTime ClosingTime { get; set; }
}
