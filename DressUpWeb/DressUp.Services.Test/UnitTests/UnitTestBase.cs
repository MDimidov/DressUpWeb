using DressUp.Data.Models;
using DressUp.Services.Test.Mock;
using DressUp.Web.Data;
using Newtonsoft.Json;

namespace DressUp.Services.Test.UnitTests;

public class UnitTestBase
{
    protected DressUpDbContext dbContext;

    [OneTimeSetUp]
    public void SetUpBase()
    {
        dbContext = DatabaseMock.Instance;
        SeedDatabase();
    }

    public IEnumerable<Product> Products { get; private set; }

    public IEnumerable<ApplicationUser> Users { get; private set; }

    public IEnumerable<Category> Categories { get; private set; }

    public IEnumerable<Brand> Brands { get; private set; }

    public IEnumerable<Address> Addresses { get; private set; }

    public IEnumerable<City> Cities { get; private set; }
    
	public IEnumerable<Country> Countries { get; private set; }

    private void SeedDatabase()
    {
        //Products
		string productsData = File.ReadAllText("../../../../DressUp.Data/Seed/ProductsSeed.json");

        Products = JsonConvert.
            DeserializeObject<IEnumerable<Product>>(productsData)!;

		//Users
		string usersData = File.ReadAllText("../../../../DressUp.Data/Seed/ApplicationUsersSeed.json");

		Users = JsonConvert.
			DeserializeObject<IEnumerable<ApplicationUser>>(usersData)!;

		//Categories
		string categoriesData = File.ReadAllText("../../../../DressUp.Data/Seed/CategoriesSeed.json");

		Categories = JsonConvert.
			DeserializeObject<IEnumerable<Category>>(categoriesData)!;

		//Brands
		string brandsData = File.ReadAllText("../../../../DressUp.Data/Seed/BrandsSeed.json");

		Brands = JsonConvert.
			DeserializeObject<IEnumerable<Brand>>(brandsData)!;

		//Addresses
		string addressesData = File.ReadAllText("../../../../DressUp.Data/Seed/AddressesSeed.json");

		Addresses = JsonConvert.
			DeserializeObject<IEnumerable<Address>>(addressesData)!;

		//Cities
		string citiesData = File.ReadAllText("../../../../DressUp.Data/Seed/CitiesSeed.json");

		Cities = JsonConvert.
			DeserializeObject<IEnumerable<City>>(citiesData)!;

		//Countries
		string CountriesData = File.ReadAllText("../../../../DressUp.Data/Seed/CountriesSeed.json");

		Countries = JsonConvert.
			DeserializeObject<IEnumerable<Country>>(CountriesData)!;
	}
}
