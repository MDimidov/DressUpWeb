using DressUp.Data.Models;
using DressUp.Services.Data;
using DressUp.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Test.UnitTests;

[TestFixture]
public class FavoriteServiceTests : UnitTestBase
{
	private IFavoriteService favoriteService;

	[OneTimeSetUp]
	public void SetUp()
		=> favoriteService = new FavoriteService(dbContext);

	[Test]
	public async Task ProductIdShoudReturnTrueIfAddedSuccessfulyToFavorite()
	{

		Product product = Products.First(p => p.Id == 3);
		ApplicationUser user = Users.First();

		await favoriteService.AddToFavoriteAsync(product.Id, user.Id.ToString());

		Favorite? favorite = await dbContext
			.Favorites
			.FirstOrDefaultAsync(f => f.UserId == user.Id && f.ProductId == product.Id);

		Assert.That(favorite, Is.Not.Null);
		Assert.That(favorite.UserId, Is.EqualTo(user.Id));
		Assert.That(favorite.ProductId, Is.EqualTo(product.Id));
	}

	[Test]
	public async Task ProductIdShoudReturnTrueIfRemovedSuccessfulyFromFavorite()
	{

		Product product = Products.First(p => p.Id == 3);
		ApplicationUser user = Users.First();

		await favoriteService.RemoveFromFavoriteAsync(product.Id, user.Id.ToString());

		Favorite? favorite = await dbContext
			.Favorites
			.FirstOrDefaultAsync(f => f.UserId == user.Id && f.ProductId == product.Id);

		Assert.That(favorite, Is.Null);
	}
}
