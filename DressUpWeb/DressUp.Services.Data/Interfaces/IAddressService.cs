using DressUp.Web.ViewModels.Address;

namespace DressUp.Services.Data.Interfaces;

public interface IAddressService
{
    Task<IEnumerable<CityViewModel>> GetAllCitiesAsync();

    Task<bool> IsCityExistByIdAsync(int id);

    Task<IEnumerable<CountryViewModel>> GetAllCountriesAsync();

    Task<bool> IsCountryExistByIdAsync(int id);
}
