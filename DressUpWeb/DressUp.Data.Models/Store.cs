#nullable disable

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DressUp.Common.EntityValidationConstants.Store;
namespace DressUp.Data.Models;

[Comment("Phisical shop/store")]
public class Store
{
    public Store()
    {
        StoresProducts = new HashSet<StoreProduct>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; }

    [Required]
    [ForeignKey(nameof(Address))]
    public Guid AddressId { get; set; }
    public virtual Address Address { get; set; }

    [Required]
    [MaxLength(ContactInfoMaxLength)]
    [Comment("Contact information with store")]
    public string ContactInfo { get; set; }

    [Required]
    [MaxLength(ImageUrlMaxLength)]
    public string ImageUrl { get; set; }

    [Required]
    [Comment("Time when store open")]
    public DateTime OpeningTime { get; set; }

    [Required]
    [Comment("Time when store close")]
    public DateTime ClosingTime { get; set; }

    public virtual ICollection<StoreProduct> StoresProducts { get; set; }
}
