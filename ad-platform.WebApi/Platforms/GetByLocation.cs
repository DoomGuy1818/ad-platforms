using ad_platform.Application.Ad_platform.Handler.GetAdPlatform;
using FastEndpoints;
using MediatR;

namespace ad_platform.Platforms;

public class GetByLocation(IMediator mediator) : Endpoint<GetAdPlatformRequest, GetAdPlatformResponse>
{
    public override void Configure()
    {
        Get(GetAdPlatformRequest.Route);
        AllowAnonymous();
        Summary(s =>
        {
            s.ExampleRequest = new LoadAdPlatformsRequest() { PlatformPath = "/ru/msk/himki" };
        });
    }

    public override async Task HandleAsync(
        GetAdPlatformRequest request,
        CancellationToken cancellationToken)
    {
            
        var result = await mediator.Send(new GetAdPlatformsCommand(request.Location), cancellationToken);
        
        if (result.IsSuccess)
        {
            Response = new GetAdPlatformResponse(result.Value);
        }
    }
}