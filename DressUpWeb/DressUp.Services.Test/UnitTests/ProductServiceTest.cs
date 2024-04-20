using DressUp.Data.Models;
using DressUp.Services.Data;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.ViewModels.Product;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Test.UnitTests;


public class ProductServiceTest : UnitTestBase
{
	private IProductService productService;

	[OneTimeSetUp]
	public void SetUp()
		=> productService = new ProductService(dbContext);

	[Test]
	public async Task ProductIdShoudReturnTrueIfExist()
	{

		foreach (Product product in Products)
		{
			bool isProductExist = await productService.IsProductExistByIdAsync(product.Id);

			Assert.IsTrue(isProductExist);
		}
	}

	[Test]
	public async Task ProductIdShoudReturnFalseIfNotExistAsync()
	{

		foreach (Product product in Products)
		{
			bool isProductExist = await productService.IsProductExistByIdAsync(product.Id + 100);

			Assert.IsFalse(isProductExist);
		}
	}

	[Test]
	public async Task AddProductByIdShoudIncreaseCountOfProductBy1()
	{
		int countBeforeAdd = dbContext.Products.Count();

		ProductFormModel testProduct = new()
		{
			Name = "Test",
			Description = "Test ",
			Quantity = 1,
			BrandId = 1,
			CategoryId = 1,
			SizeType = DressUp.Data.Models.Enums.SizeType.Men,
			Price = 12.3m,
		};

		await productService.AddProductAsync(testProduct);

		int countAfterAdd = dbContext.Products.Count();

		Assert.That(countAfterAdd, Is.EqualTo(countBeforeAdd + 1));
	}

	[Test]
	public async Task EditProductByIdShoudBeEqualToModel()
	{
		
		Product productBeforeEdit = Products.First(p => p.Id == 1);

		ProductFormModel testProductToEdit = new()
		{
			Name = "Test",
			Description = "Test ",
			Quantity = 1,
			BrandId = 1,
			CategoryId = 1,
			SizeType = DressUp.Data.Models.Enums.SizeType.Men,
			Price = 12.3m,
		};

		await productService.EditProductAsync(testProductToEdit, productBeforeEdit.Id);

		Product productAfterEdit = dbContext
			.Products.First(p => p.Id == productBeforeEdit.Id);


		Assert.That(testProductToEdit.Name, Is.EqualTo(productAfterEdit.Name));
		Assert.That(testProductToEdit.Description, Is.EqualTo(productAfterEdit.Description));
		Assert.That(testProductToEdit.BrandId, Is.EqualTo(productAfterEdit.BrandId));
		Assert.That(testProductToEdit.CategoryId, Is.EqualTo(productAfterEdit.CategoryId));
		Assert.That(testProductToEdit.SizeType, Is.EqualTo(productAfterEdit.SizeType));
		Assert.That(testProductToEdit.Quantity, Is.EqualTo(productAfterEdit.Quantity));
		Assert.That(testProductToEdit.Price, Is.EqualTo(productAfterEdit.Price));

	}

	[Test]
	public async Task GetProductByIdShoudBeEqualToGivenProduct()
	{
		Product productToGet = Products.First(p => p.Id == 3);

		ProductFormModel getProduct = await productService.GetProductByIdAsync(productToGet.Id);


		Assert.That(productToGet.Name, Is.EqualTo(getProduct.Name));
		Assert.That(productToGet.Description, Is.EqualTo(getProduct.Description));
		Assert.That(productToGet.BrandId, Is.EqualTo(getProduct.BrandId));
		Assert.That(productToGet.CategoryId, Is.EqualTo(getProduct.CategoryId));
		Assert.That(productToGet.SizeType, Is.EqualTo(getProduct.SizeType));
		Assert.That(productToGet.Quantity, Is.EqualTo(getProduct.Quantity));
		Assert.That(productToGet.Price, Is.EqualTo(getProduct.Price));
	}

	[Test]
	public async Task GetProductDetailsByIdShoudBeEqualToGivenProduct()
	{
		Product productToGet = await dbContext
			.Products
			.Include(p => p.Brand)
			.Include(p => p.Category)
			.FirstAsync(p => p.Id == 3);

		ProductDetailsViewModel getProduct = await productService.GetProductDetailsByIdAsync(productToGet.Id);


		Assert.That(productToGet.Name, Is.EqualTo(getProduct.Name));
		Assert.That(productToGet.Description, Is.EqualTo(getProduct.Description));
		Assert.That(productToGet.Brand.Name, Is.EqualTo(getProduct.Brand));
		Assert.That(productToGet.Category.Name, Is.EqualTo(getProduct.Category));
		Assert.That(productToGet.SizeType.ToString(), Is.EqualTo(getProduct.SizeType));
		Assert.That(productToGet.Quantity, Is.EqualTo(getProduct.Quantity));
		Assert.That(productToGet.Price, Is.EqualTo(getProduct.Price));
	}

	[Test]
	public async Task IsProductFavoriteShoudReturnFalse()
	{
		Product notFavoriteProduct = Products.First(p => p.Id == 3);

		ApplicationUser user = Users.First();

		bool isProductFavorite = await productService.IsProductFavorite(user.Id.ToString(), notFavoriteProduct.Id);

		Assert.IsFalse(isProductFavorite);
	}

	[Test]
	public async Task IsProductFavoriteShoudReturnTrue()
	{
		Product favoriteProduct = Products.First(p => p.Id == 2);

		ApplicationUser user = Users.First();

		Favorite favorite = new()
		{
			ProductId = favoriteProduct.Id,
			UserId = user.Id,
		};
		dbContext.Favorites.Add(favorite);
		dbContext.SaveChanges();


		bool isProductFavorite = await productService.IsProductFavorite(user.Id.ToString(), favoriteProduct.Id);

		Assert.IsTrue(isProductFavorite);
	}
}
