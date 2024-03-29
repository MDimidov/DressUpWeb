#nullable disable

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DressUp.Data.Models.Enums;
using static DressUp.Common.EntityValidationConstants.Card;

namespace DressUp.Data.Models;

public class Card
{
    public Card()
    {
        AddedDate = DateTime.UtcNow;
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NumberMaxLength)]
    public string Number { get; set; }

    [Required]
    [MaxLength(CvcExactLength)]
    public string Cvc { get; set; }

    [Required]  
    public CardType Type { get; set; } // may be CardType here

    [Required]
    public DateTime AddedDate { get; set; }

    [Required]
    [ForeignKey(nameof(Holder))]
    public Guid HolderId { get; set; }
    public virtual ApplicationUser Holder { get; set; }
}
