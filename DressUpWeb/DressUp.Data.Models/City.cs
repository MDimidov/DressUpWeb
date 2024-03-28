#nullable disable

using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.City;

namespace DressUp.Data.Models;

public class City
{
    public City()
    {
        Addresses = new HashSet<Address>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; }

    public virtual ICollection<Address> Addresses { get; set; }
}
