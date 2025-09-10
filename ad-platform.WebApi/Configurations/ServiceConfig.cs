using ad_platform.Infrastructure;

namespace ad_platform.Configurations;

public static class ServiceConfig
{
    public static IServiceCollection AddServiceConfigs(
        this IServiceCollection services)
    {
        services.AddInfrastructureServices()
            .AddMediatrConfigs();
        

        return services;
    }
}