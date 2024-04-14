using DressUp.Data.Models;
using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data.Models.Product;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Product;
using DressUp.Web.ViewModels.Product.Enums;
using Microsoft.EntityFrameworkCore;
using static DressUp.Common.EntityValidationConstants;
using Product = DressUp.Data.Models.Product;

namespace DressUp.Services.Data;

public class FavoriteService : IFavoriteService
{
	private readonly DressUpDbContext dbContext;

	public FavoriteService(DressUpDbContext dbContext)
	{
		this.dbContext = dbContext;
	}


	//Add products to favorite
	public async Task AddToFavoriteAsync(int productId, string userId)
	{
		Favorite favorite = new()
		{
			ProductId = productId,
			UserId = Guid.Parse(userId)
		};

		dbContext.Favorites.Add(favorite);
		await dbContext.SaveChangesAsync();
	}

	public async Task<IEnumerable<AllProductsViewModel>> GetFavoriteProductsAsync(string userId)
		=> await dbContext.Products
		.AsNoTracking()
		.Where(p => p.Favorites.Any(f => f.UserId.ToString() == userId))
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

	public async Task RemoveFromFavoriteAsync(int productId, string userId)
	{
		Favorite favoriteToRemove = await dbContext.Favorites
			.FirstAsync(f => f.UserId.ToString() == userId && f.ProductId == productId);

		dbContext.Favorites.Remove(favoriteToRemove);
		await dbContext.SaveChangesAsync();
	}

    public async Task<AllProductsFilteredAndPagedServiceModel> AllFavoritesAsync(AllProductsQueryModel queryModel, string userId)
    {
        IQueryable<Product> productsQuery =  dbContext
                .Products
                .Where(p => p.Favorites
                    .Any(f => f.UserId.ToString() == userId))
                .AsQueryable();

        if (!string.IsNullOrWhiteSpace(queryModel.Category))
        {
            productsQuery = productsQuery
                .Where(p => p.Category.Name == queryModel.Category);
        }

        if (!string.IsNullOrWhiteSpace(queryModel.Brand))
        {
            productsQuery = productsQuery
                .Where(p => p.Brand.Name == queryModel.Brand);
        }

        if (queryModel.SizeType != null)
        {
            productsQuery = productsQuery
                .Where(p => p.SizeType == queryModel.SizeType);
        }

        if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
        {
            string wildCard = $"%{queryModel.SearchString.ToLower()}%";
            productsQuery = productsQuery
                .Where(p => EF.Functions.Like(p.Name, wildCard) ||
                                  EF.Functions.Like(p.Description, wildCard) ||
                                  EF.Functions.Like(p.Brand.Name, wildCard) ||
                                  EF.Functions.Like(p.Category.Name, wildCard));
        }

        productsQuery = queryModel.ProductSorting switch
        {
            ProductSorting.Newest => productsQuery
                .OrderByDescending(p => p.AddedOn),
            ProductSorting.Oldest => productsQuery
                .OrderBy(p => p.AddedOn),
            ProductSorting.PriceDescending => productsQuery
                .OrderByDescending(p => p.Price),
            ProductSorting.PriceAscending => productsQuery
                .OrderBy(p => p.Price),
            ProductSorting.Favorites => productsQuery
                .OrderByDescending(p => p.Favorites.Count),
            ProductSorting.AvaliableQuantity => productsQuery
                .OrderByDescending(p => p.Quantity),
            _ => productsQuery
                .OrderByDescending(p => p.Quantity)
        };

        IEnumerable<AllProductsViewModel> allProducts = await productsQuery
            .Skip((queryModel.CurrentPage - 1) * queryModel.ProductsPerPage)
            .Take(queryModel.ProductsPerPage)
            .Select(p => new AllProductsViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Brand = p.Brand.Name,
                Category = p.Category.Name,
                Images = p.ProductImages
                    .Select(pi => new ProductImagesViewModel()
                    {
                        Id = pi.Id,
                        ImageUrl = pi.ImageUrl,
                    })
                    .ToList(),
                Price = p.Price,
                Quantity = p.Quantity,
            })
            .ToArrayAsync();

        int totalProducts = productsQuery.Count();

        return new AllProductsFilteredAndPagedServiceModel()
        {
            TotalProductsCount = totalProducts,
            Products = allProducts
        };
    }
}
