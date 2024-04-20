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
	}


}
