#nullable disable

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DressUp.Data.Models;

[Comment("Favorite products mapping table")]
public class Favorite
{
    public Favorite()
    {
        CreatedDate = DateTime.UtcNow;
    }

    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual ApplicationUser User { get; set; }


    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }
}
