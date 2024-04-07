using DressUp.Web.ViewModels.Product;

namespace DressUp.Services.Data.Interfaces;

public interface IFavoriteService
{
	Task AddToFavoriteAsync(int productId, string UserId);

	Task<IEnumerable<AllProductsViewModel>> GetFavoriteProductsAsync(string UserId);
}
