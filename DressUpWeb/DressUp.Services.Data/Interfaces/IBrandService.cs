using DressUp.Web.ViewModels.Brand;

namespace DressUp.Services.Data.Interfaces;

public interface IBrandService
{
    Task<IEnumerable<AllBrandsViewModel>> GetAllBrandsAsync();
}
