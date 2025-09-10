using ad_platform.Infrastructure.Reader.FileReader;
using ad_platform.Application.Ad_platform.Handler.LoadAdPlatforms;
using ad_platform.Application.Ad_platform.Interfaces;
using FastEndpoints;
using MediatR;

namespace ad_platform.Platforms;

public class Create(IMediator mediator, IReader reader) : Endpoint<LoadAdPlatformsRequest, LoadAdPlatformsResponse>
{
    
    public override void Configure()
    {
        Post(LoadAdPlatformsRequest.Route);
        AllowAnonymous();
        Summary(s =>
        {
            s.ExampleRequest = new LoadAdPlatformsRequest() { PlatformPath = "/путь/к/файлу" };
        });
    }

    public override async Task HandleAsync(
        LoadAdPlatformsRequest request,
        CancellationToken cancellationToken)
    {
        var platforms = reader.Read(request.PlatformPath);
            
        var result = await mediator.Send(new LoadAdPlatformsCommand(platforms));
        
        if (result.IsSuccess)
        {
            Response = new LoadAdPlatformsResponse(result.Value);
        }
    }
}
