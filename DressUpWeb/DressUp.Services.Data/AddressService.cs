using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Address;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Data;

public class AddressService : IAddressService
{
    private readonly DressUpDbContext dbContext;

    public AddressService(DressUpDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<CityViewModel>> GetAllCitiesAsync()
        => await dbContext
        .Cities
        .AsNoTracking()
        .Select(c => new CityViewModel()
        {
            Id = c.Id,
            Name = c.Name
        })
        .ToArrayAsync();

    public async Task<IEnumerable<CountryViewModel>> GetAllCountriesAsync()
    => await dbContext
        .Countries
        .AsNoTracking()
        .Select(c => new CountryViewModel()
        {
            Id = c.Id,
            Name = c.Name
        })
        .ToArrayAsync();

    public async Task<bool> IsCityExistByIdAsync(int id)
        => await dbContext
        .Cities
        .AsNoTracking()
        .AnyAsync(c => c.Id == id);

    public async Task<bool> IsCountryExistByIdAsync(int id)
        => await dbContext
        .Countries
        .AsNoTracking ()
        .AnyAsync(c => c.Id == id);
}
