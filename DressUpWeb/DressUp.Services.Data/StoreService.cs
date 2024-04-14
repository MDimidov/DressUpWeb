using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Data;

public class StoreService : IStoreService
{
    private readonly DressUpDbContext dbContext;

    public StoreService(DressUpDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<IndexViewModel>> LastThreeOpenStoresAsync()
        => await dbContext
        .Stores
        .Where(s => s.ClosingTime.TimeOfDay > DateTime.Now.TimeOfDay)
        .AsNoTracking()
        .Select(a => new IndexViewModel
        {
            Address = a.Address.Street,
            Id = a.Id,
            ImageUrl = a.ImageUrl,
        })
        .ToArrayAsync();
}
