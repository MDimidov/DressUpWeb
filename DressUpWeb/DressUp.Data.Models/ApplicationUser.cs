namespace DressUp.Data.Models;

public class ApplicationUser
{
    public ApplicationUser()
    {
        Favorites = new HashSet<Favorite>();
        BuyedProducts = new HashSet<BuyedProduct>();
        ProductReviews = new HashSet<ProductReview>();
        Cards = new HashSet<Card>();
    }

    public virtual ICollection<Favorite> Favorites { get; set; }
    public virtual ICollection<BuyedProduct> BuyedProducts { get; set; }
    public virtual ICollection<ProductReview> ProductReviews { get; set; }
    public virtual ICollection<Card> Cards { get; set; }


}
