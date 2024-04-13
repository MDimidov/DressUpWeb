using DressUp.Data.Models;
using DressUp.Services.Data;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.Infrastructure.Extensions;
using DressUp.Web.Infrastructure.ModelBinders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static DressUp.Common.GeneralApplicationConstants;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DressUpDbContext>(options =>
	options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddApplicationServices(typeof(IProductService));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
	options.SignIn.RequireConfirmedAccount = builder
					.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
	options.Password.RequireNonAlphanumeric = builder
		.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
	options.Password.RequireLowercase = builder
		.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
	options.Password.RequireUppercase = builder
		.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
	options.Password.RequireDigit = builder
		.Configuration.GetValue<bool>("Identity:Password:RequireDigit");
	options.Password.RequiredLength = builder
		.Configuration.GetValue<int>("Identity:Password:RequiredLength");
})
	.AddRoles<IdentityRole<Guid>>()
	.AddEntityFrameworkStores<DressUpDbContext>()
	.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(cfg =>
{
	cfg.LoginPath = "/User/Login";
	//cfg.AccessDeniedPath = "/Home/Error/401";
});

builder.Services
	.AddControllersWithViews()
	.AddMvcOptions(options =>
	{
		options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
	});

WebApplication app = builder.Build();



if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseExceptionHandler("/Home/Error/500");

	app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.SeedAdministrator(DevelopmentAdminEmail);

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		  name: "ProtectingUrlPattern",
		  pattern: "/{controller}/{action}/{id}/{information}",
		  defaults: new { Controller = "Product", Action = "Details"});
	endpoints.MapDefaultControllerRoute();
	endpoints.MapRazorPages();
});
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
//app.MapDefaultControllerRoute();
//app.MapRazorPages();

app.Run();
