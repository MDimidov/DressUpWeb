using DressUp.Services.Data.Models.Product;
using DressUp.Web.ViewModels.Product;

namespace DressUp.Services.Data.Interfaces;

public interface IFavoriteService
{
	Task AddToFavoriteAsync(int productId, string userId);

	Task RemoveFromFavoriteAsync(int productId, string userId);

	Task<AllProductsFilteredAndPagedServiceModel> AllFavoritesAsync(AllProductsQueryModel queryModel, string userId);
}
