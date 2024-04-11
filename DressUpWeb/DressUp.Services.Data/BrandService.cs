using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Brand;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Data;

public class BrandService : IBrandService
{
    private readonly DressUpDbContext dbContext;

    public BrandService(DressUpDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<AllBrandsViewModel>> GetAllBrandsAsync()
        => await dbContext.Brands
            .AsNoTracking()
            .Select(b => new AllBrandsViewModel()
            {
                Id = b.Id,
                Name = b.Name,
            })
            .ToArrayAsync();

	public async Task<IEnumerable<string>> GetBrandsNameAsync()
	    => await dbContext
        .Brands
        .AsNoTracking()
        .Select(b=> b.Name)
        .ToArrayAsync();
}
