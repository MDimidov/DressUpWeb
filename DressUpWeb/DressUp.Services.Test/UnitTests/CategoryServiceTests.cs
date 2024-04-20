using DressUp.Data.Models;
using DressUp.Services.Data;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.Category;

namespace DressUp.Services.Test.UnitTests;

[TestFixture]
public class CategoryServiceTests : UnitTestBase
{
	private ICategoryService categoryService;

	[OneTimeSetUp]
	public void SetUp()
		=> categoryService = new CategoryService(dbContext);

	[Test]
	public async Task ShoudReturnAllCategoriesAsync()
	{
		IEnumerable<AllCategoriesViewModel> categoriesModel = await categoryService.GetAllCategoriesAsync();

		foreach(Category category in Categories)
		{

			Assert.That(categoriesModel
				.FirstOrDefault(c => c.Id == category.Id), 
					Is.Not.Null);
		}
	}

	[Test]
	public async Task ShoudReturnAllCategoriesNameAsync()
	{
		IEnumerable<string> categoriesModel = await categoryService.GetCategoriesNamesAsync();

		foreach (string category in Categories.Select(c => c.Name))
		{

			Assert.That(categoriesModel.Contains(category), Is.True);
		}
	}
}
