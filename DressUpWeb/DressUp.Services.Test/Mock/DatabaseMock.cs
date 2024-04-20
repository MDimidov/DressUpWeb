using DressUp.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Services.Test.Mock;

public static class DatabaseMock
{
    public static DressUpDbContext Instance
    {
        get
        {
            DbContextOptions<DressUpDbContext> dbContextOptions =
                new DbContextOptionsBuilder<DressUpDbContext>()
                .UseInMemoryDatabase("DressUpInMomoryDb" + DateTime.Now.Ticks.ToString())
                .Options;

            return new DressUpDbContext(dbContextOptions);
        }
    }
}
