﻿using DressUp.Data.Models;
using DressUp.Services.Data.Models.Store;
using DressUp.Web.ViewModels.Home;
using DressUp.Web.ViewModels.Store;
using DressUp.Web.ViewModels.Store.Enums;

namespace DressUp.Services.Data.Interfaces;

public interface IStoreService
{
    Task<IEnumerable<IndexViewModel>> LastThreeOpenStoresAsync();

    Task<AllStoresFilteredAndPagedServiceModel> AllStoresAsync(AllStoresQueryModel queryModel);

    IEnumerable<StoreStatus> GetAllStoreStatus();

}
