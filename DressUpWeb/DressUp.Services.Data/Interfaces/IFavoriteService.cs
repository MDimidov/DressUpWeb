using DressUp.Web.ViewModels.Product;

namespace DressUp.Services.Data.Interfaces;

public interface IFavoriteService
{
	Task AddToFavoriteAsync(int productId, string userId);

	Task RemoveFromFavoriteAsync(int productId, string userId);

	Task<IEnumerable<AllProductsViewModel>> GetFavoriteProductsAsync(string userId);
}
