using DressUp.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DressUp.Data.Models;

public class ApplicationUser : IdentityUser<Guid>
{
    public ApplicationUser()
    {
        Favorites = new HashSet<Favorite>();
        BuyedProducts = new HashSet<BuyedProduct>();
        ProductReviews = new HashSet<ProductReview>();
        Cards = new HashSet<Card>();
    }
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public GenderType? Gender {  get; set; }

    [ForeignKey(nameof(Address))]
    public Guid? AddressId { get; set; }
    public virtual Address? Address { get; set; }


    public virtual ICollection<Favorite> Favorites { get; set; }
    public virtual ICollection<BuyedProduct> BuyedProducts { get; set; }
    public virtual ICollection<ProductReview> ProductReviews { get; set; }
    public virtual ICollection<Card> Cards { get; set; }


}
