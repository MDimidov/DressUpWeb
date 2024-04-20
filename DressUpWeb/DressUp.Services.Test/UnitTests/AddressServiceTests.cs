using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data;
using DressUp.Web.ViewModels.Brand;
using DressUp.Web.ViewModels.Address;
using DressUp.Data.Models;

namespace DressUp.Services.Test.UnitTests;

[TestFixture]
public class AddressServiceTests : UnitTestBase
{
	private IAddressService addressService;

	[OneTimeSetUp]
	public void SetUp()
		=> addressService = new AddressService(dbContext);

	[Test]
	public async Task ShoudReturnAllCitiesAsync()
	{
		IEnumerable<CityViewModel> citiesModel = await addressService.GetAllCitiesAsync();

		foreach (City city in Cities)
		{
			Assert.That(citiesModel
				.FirstOrDefault(c => c.Id == city.Id),
					Is.Not.Null);
		}
	}

	[Test]
	public async Task ShoudReturnAllCountriesAsync()
	{
		IEnumerable<CountryViewModel> countriesModel = await addressService.GetAllCountriesAsync();

		foreach (Country country in Countries)
		{
			Assert.That(countriesModel
				.FirstOrDefault(c => c.Id == country.Id),
					Is.Not.Null);
		}
	}


	[Test]
	public async Task IfCityExistShoudReturnTrueAsync()
	{
		foreach (City city in Cities)
		{
			bool isCityExistById = await addressService.IsCityExistByIdAsync(city.Id);
			Assert.That(isCityExistById, Is.True);
		}
	}

	[Test]
	public async Task IfCountryExistShoudReturnTrueAsync()
	{
		foreach (Country country in Countries)
		{
			bool isCountryExistById = await addressService.IsCountryExistByIdAsync(country.Id);
			Assert.That(isCountryExistById, Is.True);
		}
	}
}
