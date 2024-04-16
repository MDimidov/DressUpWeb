using DressUp.Data.Models;
using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data.Models.Store;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Home;
using DressUp.Web.ViewModels.Address;
using DressUp.Web.ViewModels.Store;
using DressUp.Web.ViewModels.Store.Enums;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace DressUp.Services.Data;

public class StoreService : IStoreService
{
    private readonly DressUpDbContext dbContext;
    private readonly IAddressService addressService;

    public StoreService(
        DressUpDbContext dbContext,
        IAddressService addressService)
    {
        this.dbContext = dbContext;
        this.addressService = addressService;
    }

    public async Task AddStoreAsync(StoreFormModel formModel)
    {
        Address? address = await GetAddressByModelAsync(formModel.AddressForm);

        if (address == null)
        {
            address = new()
            {
                Street = formModel.AddressForm.Street,
                CityId = formModel.AddressForm.CityId,
                CountryId = formModel.AddressForm.CountryId,
            };
        }

        Store store = new()
        {
            Name = formModel.Name,
            Address = address,
            OpeningTime = formModel.OpeningTime,
            ClosingTime = formModel.ClosingTime,
            ContactInfo = formModel.ContactInfo,
            ImageUrl = formModel.ImageUrl,
        };

        await dbContext.Stores.AddAsync(store);
        await dbContext.SaveChangesAsync();
    }

    public async Task<AllStoresFilteredAndPagedServiceModel> AllStoresAsync(AllStoresQueryModel queryModel)
    {
        IQueryable<Store> storesQuery = dbContext
            .Stores
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
        {
            string wildCard = $"%{queryModel.SearchString.ToLower()}%";
            storesQuery = storesQuery
                .Where(s => EF.Functions.Like(s.Name, wildCard) ||
                                EF.Functions.Like(s.Address.City.Name, wildCard) ||
                                EF.Functions.Like(s.Address.Country.Name, wildCard) ||
                                EF.Functions.Like(s.ContactInfo, wildCard));
        }

        storesQuery = queryModel.StoreStatus switch
        {
            StoreStatus.All => storesQuery,

            StoreStatus.Open => storesQuery
                .Where(s => s.ClosingTime.TimeOfDay > DateTime.Now.TimeOfDay
                    && s.OpeningTime.TimeOfDay <= DateTime.Now.TimeOfDay),

            StoreStatus.Closed => storesQuery
                .Where(s => s.ClosingTime.TimeOfDay <= DateTime.Now.TimeOfDay
                    || s.OpeningTime.TimeOfDay > DateTime.Now.TimeOfDay),

            _ => storesQuery.OrderByDescending(s => s.ClosingTime.TimeOfDay > DateTime.Now.TimeOfDay),
        };


        IEnumerable<AllStoresViewModel> allStores = await storesQuery
            .Skip((queryModel.CurrentPage - 1) * queryModel.StoresPerPage)
            .Take(queryModel.StoresPerPage)
            .Select(s => new AllStoresViewModel()
            {
                Id = s.Id,
                Name = s.Name,
                ImageUrl = s.ImageUrl,
                OpeningTime = s.OpeningTime,
                ClosingTime = s.ClosingTime,
            })
            .ToArrayAsync();

        int totalStores = storesQuery.Count();

        return new AllStoresFilteredAndPagedServiceModel()
        {
            TotalStoresCount = totalStores,
            Stores = allStores
        };
    }

    public async Task EditStoreAsync(StoreFormModel formModel, int storeId)
    {
        Address? address = await GetAddressByModelAsync(formModel.AddressForm);

        if (address == null)
        {
            address = new()
            {
                Street = formModel.AddressForm.Street,
                CityId = formModel.AddressForm.CityId,
                CountryId = formModel.AddressForm.CountryId,
            };
        }

        Store store = await dbContext
            .Stores
            .FirstAsync(s => s.Id == storeId);

        store.Name = formModel.Name;
        store.Address = address;
        store.OpeningTime = formModel.OpeningTime;
        store.ClosingTime = formModel.ClosingTime;
        store.ContactInfo = formModel.ContactInfo;
        store.ImageUrl = formModel.ImageUrl;

        await dbContext.SaveChangesAsync();
    }

    public IEnumerable<StoreStatus> GetAllStoreStatus()
    {
        StoreStatus[] storeStatuses =
        {
            StoreStatus.All,
            StoreStatus.Open,
            StoreStatus.Closed
        };

        return storeStatuses;
    }

    public async Task<StoreFormModel> GetStoreByIdAsync(int storeId)
        => await dbContext
        .Stores
        .AsNoTracking()
        .Where(s => s.Id == storeId)
        .Select(s => new StoreFormModel()
        {
            Name = s.Name,
            AddressForm = new AddressFormModel()
            {
                Street = s.Address.Street,
                CityId = s.Address.CityId,
                CountryId = s.Address.CountryId,
            },
            ClosingTime = s.ClosingTime,
            OpeningTime = s.OpeningTime,
            ContactInfo = s.ContactInfo,
            ImageUrl = s.ImageUrl,
        })
        .FirstAsync();

    public async Task<StoreDetailsViewModel> GetStoreDetailsAsyncById(int storeId)
        => await dbContext
        .Stores
        .AsNoTracking()
        .Where(s => s.Id == storeId)
        .Select(s => new StoreDetailsViewModel()
        {
            Id = s.Id,
            Name = s.Name,
            Address = $"{s.Address.Street}, {s.Address.City.Name}, {s.Address.Country.Name}",
            OpeningTime = s.OpeningTime,
            ClosingTime = s.ClosingTime,
            ContactInfo = s.ContactInfo,
            ImageUrl = s.ImageUrl,
        })
        .FirstAsync();

    public async Task<bool> IsStoreExistByIdAsync(int storeId)
        => await dbContext
        .Stores
        .AsNoTracking()
        .AnyAsync(s => s.Id == storeId);

    public async Task<IEnumerable<IndexViewModel>> LastThreeOpenStoresAsync()
        => await dbContext
        .Stores
        .Where(s => s.ClosingTime.TimeOfDay > DateTime.Now.TimeOfDay
            && s.OpeningTime.TimeOfDay <= DateTime.Now.TimeOfDay)
        .AsNoTracking()
        .Select(a => new IndexViewModel
        {
            Address = $"{a.Address.Street}, {a.Address.City.Name}, {a.Address.Country.Name}",
            Id = a.Id,
            ImageUrl = a.ImageUrl,
        })
        .ToArrayAsync();

    private async Task<Address?> GetAddressByModelAsync(AddressFormModel addressModel)
        => await
            dbContext
            .Addresses
            .FirstOrDefaultAsync(a =>
                a.Street.ToLower() == addressModel.Street.ToLower() &&
                a.CityId == addressModel.CityId &&
                a.CountryId == addressModel.CountryId);
}
