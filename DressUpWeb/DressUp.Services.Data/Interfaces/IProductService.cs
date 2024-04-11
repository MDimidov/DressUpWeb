using DressUp.Data.Models.Enums;
using DressUp.Services.Data.Models.Product;
using DressUp.Web.ViewModels.Product;

namespace DressUp.Services.Data.Interfaces;

public interface IProductService
{
	Task<AllProductsViewModel[]> GetAllProductsAsync();

	Task<AllProductsViewModel[]> GetMenProductsAsync();

	Task AddProductAsync(ProductFormModel model);

	IEnumerable<SizeType> GetAllSizeTypes();

	Task<ProductFormModel> GetProductByIdAsync(int id);

	Task EditProductAsync(ProductFormModel model, int id);

	Task<ProductDetailsViewModel> GetProductDetailsByIdAsync(int id);

	Task<ProductPreDeleteDetails> GetProductPreDeleteDetailsByIdAsync(int id);

	Task DeleteProductByIdAsync(int id);

	Task<bool> IsProductExistByIdAsync(int id);

	Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel);
}
