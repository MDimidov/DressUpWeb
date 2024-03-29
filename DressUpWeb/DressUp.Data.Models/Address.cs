#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DressUp.Common.EntityValidationConstants.Address;
namespace DressUp.Data.Models;

public class Address
{
    public Address()
    {
        Id = Guid.NewGuid();
        Stores = new HashSet<Store>();
        Users = new HashSet<ApplicationUser>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(StreetMaxLength)]
    public string Street { get; set; }


    [ForeignKey(nameof(City))]
    public int CityId { get; set; }
    public virtual City City { get; set; }


    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }

    public virtual ICollection<Store> Stores { get; set; }
    public virtual ICollection<ApplicationUser> Users { get; set; }
}
