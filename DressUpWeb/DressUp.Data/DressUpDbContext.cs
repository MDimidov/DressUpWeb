using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DressUp.Web.Data;

public class DressUpDbContext : IdentityDbContext
{
    public DressUpDbContext(DbContextOptions<DressUpDbContext> options)
        : base(options)
    {
    }
}
