using DressUp.Data.Models;
using DressUp.Web.ViewModels.Home;

namespace DressUp.Services.Data.Interfaces;

public interface IStoreService
{
    Task<IEnumerable<IndexViewModel>> LastThreeOpenStoresAsync();
}
