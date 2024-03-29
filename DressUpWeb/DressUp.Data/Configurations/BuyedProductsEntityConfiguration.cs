using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DressUp.Data.Configurations
{
    public class BuyedProductsEntityConfiguration : IEntityTypeConfiguration<BuyedProduct>
    {
        public void Configure(EntityTypeBuilder<BuyedProduct> builder)
        {
            builder
                .HasKey(bp => new
                {
                    bp.BuyerId,
                    bp.ProductId
                });

            builder
                .HasOne(bp => bp.Product)
                .WithMany(p => p.BuyedProducts)
                .HasForeignKey(bp => bp.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder 
                .HasOne(bp => bp.Buyer)
                .WithMany(b => b.BuyedProducts)
                .HasForeignKey(bp => bp.BuyerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
