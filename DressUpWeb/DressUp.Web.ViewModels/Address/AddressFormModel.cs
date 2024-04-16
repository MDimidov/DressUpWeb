#nullable disable

using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Address;

namespace DressUp.Web.ViewModels.Address;

public class AddressFormModel
{
    public AddressFormModel()
    {
        Cities = new HashSet<CityViewModel>();
        Countries = new HashSet<CountryViewModel>();
    }

    [Display(Name = "Address")]
    [StringLength(StreetMaxLength, MinimumLength = StreetMinLength)]
    public string Street { get; set; }

    [Required]
    [Display(Name = "City")]
    public int CityId { get; set; }

    public IEnumerable<CityViewModel> Cities { get; set; }

    [Required]
    [Display(Name = "Country")]
    public int CountryId { get; set; }

    public IEnumerable<CountryViewModel> Countries { get; set; }
}
