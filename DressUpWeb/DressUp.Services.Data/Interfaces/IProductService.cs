using DressUp.Web.ViewModels.Product;

namespace DressUp.Services.Data.Interfaces;

public interface IProductService
{
    Task<AllProductsViewModel[]> GetAllProductsAsync();
}
