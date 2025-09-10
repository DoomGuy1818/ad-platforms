using System.Reflection;
using ad_platform.Application.Ad_platform.Handler.GetAdPlatform;
using ad_platform.Application.Ad_platform.Handler.LoadAdPlatforms;
using ad_platform.Core.Entity;
using ad_platform.Infrastructure;
using Ardalis.SharedKernel;
using MediatR;

namespace ad_platform.Configurations;

public static class MediatrConfig
{
    public static IServiceCollection AddMediatrConfigs(this IServiceCollection services)
    {
        var mediatRAssemblies = new[]
        {
            Assembly.GetAssembly(typeof(AdPlatform)),
            Assembly.GetAssembly(typeof(LoadAdPlatformsCommand)),
            Assembly.GetAssembly(typeof(GetAdPlatformsCommand)), 
            Assembly.GetAssembly(typeof(InfrastuctureServiceExtension)),
        };
        
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(mediatRAssemblies!);
        });

        return services;
        
        return services;
    }
}