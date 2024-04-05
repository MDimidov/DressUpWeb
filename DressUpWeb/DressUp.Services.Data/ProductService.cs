using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Product;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Data;

public class ProductService : IProductService
{
    private readonly DressUpDbContext dbContext;

    public ProductService(DressUpDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<AllProductsViewModel[]> GetAllProductsAsync()
        => await dbContext.Products
        .AsNoTracking()
        .Select(p => new AllProductsViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Brand = p.Brand.Name,
            Category = p.Category.Name,
            Price = p.Price,
            Quantity = p.Quantity,
        })
        .ToArrayAsync();

    public async Task<AllProductsViewModel[]> GetMenProductsAsync()
        => throw new NotImplementedException();
}
