using DressUp.Data.Models;
using DressUp.Services.Data.Models.Store;
using DressUp.Web.ViewModels.Address;
using DressUp.Web.ViewModels.Home;
using DressUp.Web.ViewModels.Store;
using DressUp.Web.ViewModels.Store.Enums;

namespace DressUp.Services.Data.Interfaces;

public interface IStoreService
{
    Task<IEnumerable<IndexViewModel>> LastThreeOpenStoresAsync();

    Task<AllStoresFilteredAndPagedServiceModel> AllStoresAsync(AllStoresQueryModel queryModel);

    IEnumerable<StoreStatus> GetAllStoreStatus();

    Task<StoreDetailsViewModel> GetStoreDetailsAsyncById(int storeId);

    Task<bool> IsStoreExistByIdAsync(int storeId);

    Task AddStoreAsync(StoreFormModel formModel);

    Task<StoreFormModel> GetStoreByIdAsync(int storeId);

    Task EditStoreAsync(StoreFormModel formModel, int storeId);
}
