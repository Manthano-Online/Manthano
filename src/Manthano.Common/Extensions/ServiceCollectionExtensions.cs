using Manthano.Common.Execution;
using Manthano.Common.Providers.Implementations;
using Manthano.Common.Providers.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Manthano.Common.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddManthanoServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationProvider, AuthenticationProvider>();
            services.AddScoped<IActionExecutor, ActionExecutor>();
        }
    }
}
