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
	public async Task AddToFavoriteAsync(int productId, string UserId)
	{
		bool isAlreadyAdded = dbContext
			.Favorites
			.Any(f => f.UserId.ToString() == UserId && f.ProductId == productId);

		if (isAlreadyAdded)
		{
			return;
		}

		Favorite favorite = new()
		{
			ProductId = productId,
			UserId = Guid.Parse(UserId)
		};

		dbContext.Favorites.Add(favorite);
		await dbContext.SaveChangesAsync();
	}

	public async Task<IEnumerable<AllProductsViewModel>> GetFavoriteProductsAsync(string UserId)
		=> await dbContext.Products
		.AsNoTracking()
		.Where(p => p.Favorites.Any(f => f.UserId.ToString() == UserId))
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
}
