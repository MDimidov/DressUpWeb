using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data;
using DressUp.Data.Models;
using DressUp.Web.ViewModels.Brand;

namespace DressUp.Services.Test.UnitTests;

[TestFixture]
public class BrandServiceTests : UnitTestBase
{
	private IBrandService brandService;

	[OneTimeSetUp]
	public void SetUp()
		=> brandService = new BrandService(dbContext);

	[Test]
	public async Task ShoudReturnAllBrandsAsync()
	{
		IEnumerable<AllBrandsViewModel> brandsModel = await brandService.GetAllBrandsAsync();

		foreach (Brand brand in Brands)
		{

			Assert.That(brandsModel
				.FirstOrDefault(b => b.Id == brand.Id),
					Is.Not.Null);
		}
	}

	[Test]
	public async Task ShoudReturnAllBrandsNameAsync()
	{
		IEnumerable<string> brandsNames = await brandService.GetBrandsNameAsync();

		foreach (string brand in Brands.Select(b => b.Name))
		{
			Assert.That(brandsNames.Contains(brand), Is.True);
		}
	}
}
