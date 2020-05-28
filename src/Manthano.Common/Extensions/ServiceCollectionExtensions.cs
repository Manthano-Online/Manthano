using Manthano.Common.Execution;
using Microsoft.Extensions.DependencyInjection;

namespace Manthano.Common.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddManthanoServices(this IServiceCollection services)
        {
            services.AddScoped<IActionExecutor, ActionExecutor>();
        }
    }
}
