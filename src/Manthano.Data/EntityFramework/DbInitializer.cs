using System;
using System.Threading.Tasks;
using Manthano.Data.EntityFramework.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Manthano.Data.EntityFramework
{
    public static class DbInitializer
    {
        public static async Task Seed(IServiceProvider provider)
        {
            var context = provider.GetRequiredService<AppDbContext>();
            var roleManager = provider.GetRequiredService<RoleManager<AppRole>>();
            var userManager = provider.GetRequiredService<UserManager<AppUser>>();

            if (!await context.Users.AnyAsync())
            {
                await roleManager.CreateAsync(new AppRole(Constants.AdministratorRoleName));
                await roleManager.CreateAsync(new AppRole(Constants.UserRoleName));

                var user = AppUser.SeedNewUser("admin", "The", "Administrator", "admin@admin.com", "a");
                user.Id = 1;
                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();
                await userManager.AddToRoleAsync(user, Constants.AdministratorRoleName);

                var user2 = AppUser.SeedNewUser("sam", "Sam", "Sample", "sam@sample.com", "a");
                user2.Id = 2;
                await context.Users.AddAsync(user2);
                await context.SaveChangesAsync();
                await userManager.AddToRoleAsync(user2, Constants.UserRoleName);
            }
        }
    }
}
