using DressUp.Web.ViewModels.Brand;
using DressUp.Web.ViewModels.Category;

namespace DressUp.Services.Data.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<AllCategoriesViewModel>> GetAllCategoriesAsync();
}
