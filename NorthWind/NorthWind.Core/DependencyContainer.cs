using Microsoft.Extensions.DependencyInjection;
using NorthWind.Core.Services;

namespace Microsoft.Extension.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddServices(
        this IServiceCollection services)
    {
        services.AddSingleton<IAppLogger, AppLogger>();
        return services;
    }

}
