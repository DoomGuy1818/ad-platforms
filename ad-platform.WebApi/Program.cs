using System.Reflection;
using ad_platform.Application.Ad_platform.Handler.LoadAdPlatforms;
using ad_platform.Configurations;
using FastEndpoints;
using FastEndpoints.Swagger;
using FluentValidation;


namespace ad_platform;

public partial class Program
{
  private static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    
    builder.Services.AddServiceConfigs();

    builder.Services.AddFastEndpoints()
                    .SwaggerDocument(o =>
                    {
                      o.ShortSchemaNames = true;
                    });
    
    builder.Services.AddSwaggerGen();
    
    var app = builder.Build();

    app.UseAppMiddleware();
    
    app.UseSwaggerUI(c =>
    {
      c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
      c.RoutePrefix = "swagger"; // Доступ по /swagger
    });

    app.Run();
  }
}