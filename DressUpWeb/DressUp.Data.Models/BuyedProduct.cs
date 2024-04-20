#nullable disable

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DressUp.Data.Models;

public class BuyedProduct
{
	[ForeignKey(nameof(Buyer))]
	public Guid BuyerId { get; set; }
	public virtual ApplicationUser Buyer { get; set; }


	[ForeignKey(nameof(Product))]
	public int ProductId { get; set; }
	public virtual Product Product { get; set; }

	[Required]
	public int Quantity { get; set; }
}
