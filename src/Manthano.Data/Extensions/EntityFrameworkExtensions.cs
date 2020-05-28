using Manthano.Data.EntityFramework;
using Manthano.Data.EntityFramework.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Manthano.Data.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static void AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("Default")));
            services.AddIdentityFramework(configuration.GetSection("PasswordOptions").Get<PasswordOptions>());
        }

        public static void AddIdentityFramework(this IServiceCollection services, PasswordOptions options)
        {
            services.AddIdentity<AppUser, AppRole>(setup => setup.Password = options)
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
