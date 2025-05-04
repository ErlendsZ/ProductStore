using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ProductStore.Helpers;

public static class IdentitySeeder
{
    public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
        var config = serviceProvider.GetRequiredService<IOptions<IdentitySeedSettings>>().Value;

        foreach (var role in config.Roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        if (await userManager.FindByEmailAsync(config.AdminEmail) == null)
        {
            var user = new IdentityUser
            {
                UserName = config.AdminEmail,
                Email = config.AdminEmail,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(user, config.AdminPassword);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }

}
