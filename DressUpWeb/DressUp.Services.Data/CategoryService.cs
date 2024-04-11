using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Brand;
using DressUp.Web.ViewModels.Category;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Data;

public class CategoryService : ICategoryService
{
    private readonly DressUpDbContext dbContext;

    public CategoryService(DressUpDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<AllCategoriesViewModel>> GetAllCategoriesAsync()
        => await dbContext
        .Categories
        .AsNoTracking()
        .Select(c => new AllCategoriesViewModel()
        {
            Id = c.Id,
            Name = c.Name,
        })
        .ToArrayAsync();

	public async Task<IEnumerable<string>> GetCategoriesNamesAsync()
	    => await dbContext
        .Categories
        .AsNoTracking()
        .Select(c => c.Name)
        .ToArrayAsync();
}
