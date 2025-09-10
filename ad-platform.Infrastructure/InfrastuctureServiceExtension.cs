using ad_platform.Application.Ad_platform.Interfaces;
using ad_platform.Core.Repository;
using ad_platform.Infrastructure.Reader.FileReader;
using ad_platform.Infrastructure.Repository.InMemory;
using Microsoft.Extensions.DependencyInjection;

namespace ad_platform.Infrastructure;

public static class InfrastuctureServiceExtension
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services
        )
    {
        RegisterServices(services);
        
        return services;
    }

    private static void RegisterServices(IServiceCollection services)
    {
        services.AddSingleton(typeof(IAdPlatformRepository), typeof(InMemoryAdPlatformRepository))
            .AddScoped(typeof(IReader), typeof(FileReader));
    }
}