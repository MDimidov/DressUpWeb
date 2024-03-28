#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace DressUp.Data.Models;

public class StoreProduct
{
    [ForeignKey(nameof(Store))]
    public int StoreId { get; set; }
    public virtual Store Store { get; set; }


    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}
