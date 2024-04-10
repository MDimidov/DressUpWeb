using DressUp.Data.Models;
using DressUp.Services.Data;
using DressUp.Services.Data.Interfaces;
using DressUp.Web.Data;
using DressUp.Web.Infrastructure.Extensions;
using DressUp.Web.Infrastructure.ModelBinders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
	.AddEntityFrameworkStores<DressUpDbContext>()
	.AddDefaultTokenProviders();

builder.Services
	.AddControllersWithViews()
	.AddMvcOptions(options =>
	{
		options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
	});

WebApplication app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
