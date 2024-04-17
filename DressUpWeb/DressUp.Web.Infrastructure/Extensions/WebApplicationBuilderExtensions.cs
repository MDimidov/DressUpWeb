using DressUp.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DressUp.Web.Infrastructure.Extensions;

public static class WebApplicationBuilderExtensions
{
    /// <summary>
    /// This method registers all services with their interfaces and implementations of given assembly
    /// The assembly is taken from type of random service interface or implementation provided.
    /// </summary>
    /// <param name="serviceType">Type of random service</param>
    /// <exception cref="InvalidOperationException"></exception>
	public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
    {
        Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);
        if (serviceAssembly == null)
        {
            throw new InvalidOperationException("Invalid service type provider");
        }

        Type[] serviceTypes = serviceAssembly
            .GetTypes()
            .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
            .ToArray();

        foreach (Type implementationType in serviceTypes)
        {
            Type? interfaceType = implementationType
                .GetInterface($"I{implementationType.Name}");

            if (interfaceType == null)
            {
                throw new InvalidOperationException($"No interface is provided for the service with name {implementationType.Name}");
            }

            services.AddScoped(interfaceType, implementationType);
        }
    }

    /// <summary>
    /// This method seeds admin role if it dose not exist.
    /// Passed email shoud be valid email of existing user in application.
    /// </summary>
    /// <param name="app"></param>
    /// <param name="email"></param>
    /// <returns></returns>
    public static IApplicationBuilder SeedRole(this IApplicationBuilder app, string email, string roleName)
    {
        using IServiceScope scopedSerivces = app.ApplicationServices.CreateScope();

        IServiceProvider serviceProvider = scopedSerivces.ServiceProvider;

        UserManager<ApplicationUser> userManager =
            serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        RoleManager<IdentityRole<Guid>> roleManager =
            serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

        Task.Run(async () =>
        {
            if (await roleManager.RoleExistsAsync(roleName))
            {
                return;
            }

            IdentityRole<Guid> role = new(roleName);

            await roleManager.CreateAsync(role);

            ApplicationUser userWithRole = await userManager
                .FindByEmailAsync(email);

            await userManager.AddToRoleAsync(userWithRole, roleName);
        })
        .GetAwaiter()
        .GetResult();

        return app;
    }
}
