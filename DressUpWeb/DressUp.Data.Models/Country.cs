#nullable disable

using System.ComponentModel.DataAnnotations;
using static DressUp.Common.EntityValidationConstants.Country;

namespace DressUp.Data.Models;

public class Country
{
    public Country()
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
