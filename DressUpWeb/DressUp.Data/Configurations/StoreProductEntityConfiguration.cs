using DressUp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DressUp.Data.Configurations;

public class StoreProductEntityConfiguration : IEntityTypeConfiguration<StoreProduct>
{
    public void Configure(EntityTypeBuilder<StoreProduct> builder)
    {
        builder
            .HasKey(sp => new
            {
                sp.ProductId,
                sp.StoreId
            });

        builder
            .HasOne(sp => sp.Product)
            .WithMany(p => p.StoresProducts)
            .HasForeignKey(sp => sp.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(sp => sp.Store)
            .WithMany(s => s.StoresProducts)
            .HasForeignKey(sp => sp.StoreId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
