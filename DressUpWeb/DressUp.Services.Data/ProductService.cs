using DressUp.Data.Models;
using DressUp.Data.Models.Enums;
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

    public async Task AddProductAsync(ProductFormModel model)
    {
        Product product = new()
        {
            Name = model.Name,
            Description = model.Description,
            BrandId = model.BrandId,
            CategoryId  = model.CategoryId,
            SizeType = model.SizeType,
            Price = model.Price,
            Quantity = model.Quantity,
        };

        await dbContext.Products.AddAsync(product);
        await dbContext.SaveChangesAsync();
    }

	public async Task EditProductAsync(ProductFormModel model, int id)
	{
		Product? product = await dbContext
            .Products
            .FindAsync(id);

        if (product == null)
        {
            return;
        }

        product.Name = model.Name;
        product.Description = model.Description;
        product.BrandId = model.BrandId;
        product.CategoryId = model.CategoryId;
        product.SizeType = model.SizeType;
        product.Price = model.Price;
        product.Quantity = model.Quantity;

        await dbContext.SaveChangesAsync();
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
            Images = p.ProductImages
                .Select(pi => new ProductImagesViewModel()
                {
                    Id = pi.Id,
                    ImageUrl = pi.ImageUrl,
                })
                .ToList()
        })
        .ToArrayAsync();

    public IEnumerable<SizeType> GetAllSizeTypes()
    {
        SizeType[] sizeTypes = 
        {
            SizeType.Men,
            SizeType.Women,
            SizeType.Child
        };

        return sizeTypes;
    }

    public async Task<AllProductsViewModel[]> GetMenProductsAsync()
        => await dbContext.Products
        .AsNoTracking()
        .Where(p => p.SizeType == SizeType.Men)
		.Select(p => new AllProductsViewModel
		{
			Id = p.Id,
			Name = p.Name,
			Brand = p.Brand.Name,
			Category = p.Category.Name,
			Price = p.Price,
			Quantity = p.Quantity,
			Images = p.ProductImages
				.Select(pi => new ProductImagesViewModel()
				{
					Id = pi.Id,
					ImageUrl = pi.ImageUrl,
				})
                .ToList()
		})
		.ToArrayAsync();

    public async Task<ProductFormModel> GetProductByIdAsync(int id)
        => await dbContext
        .Products
        .Where(p => p.Id == id)
        .Select(p => new ProductFormModel()
        {
            Name = p.Name,
            Description = p.Description,
            BrandId = p.BrandId,
            CategoryId = p.CategoryId,
            SizeType = p.SizeType,
            Price = p.Price,
            Quantity = p.Quantity,
        })
        .FirstAsync();
}
