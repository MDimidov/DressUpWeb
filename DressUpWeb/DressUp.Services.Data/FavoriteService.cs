using DressUp.Data.Models;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Product;
using Microsoft.EntityFrameworkCore;

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
}
