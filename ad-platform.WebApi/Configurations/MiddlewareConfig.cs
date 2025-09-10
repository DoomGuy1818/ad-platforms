using FastEndpoints;

namespace ad_platform.Configurations;

public static class MiddlewareConfig
{
    public static void UseAppMiddleware(this WebApplication app)
    {
        app.UseFastEndpoints()
            .UseSwagger();
        
    }
    
}