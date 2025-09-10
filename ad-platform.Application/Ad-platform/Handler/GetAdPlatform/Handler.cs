using ad_platform.Core.Entity;
using ad_platform.Core.Repository;
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace ad_platform.Application.Ad_platform.Handler.GetAdPlatform;

public class Handler(IAdPlatformRepository repository) : ICommandHandler<GetAdPlatformsCommand, Result<List<string>>>
{
    public async Task<Result<List<string>>> Handle(
        GetAdPlatformsCommand request,
        CancellationToken cancellationToken)
    {
        try
        {
            var platforms = FindAdPlatforms(repository, request.Location);
            var platformsNameList = new List<string>();

            await Task.CompletedTask;
            
            foreach (var platform in platforms)
            {
                platformsNameList.Add(platform.Name);
            }

            foreach (var platform in platformsNameList)
            {
                Console.WriteLine(platform);
            }
            
            return platformsNameList;
        }
        catch (Exception ex)
        {
            return Result.Error($"Ошибка: {ex.Message}");
        }
    }

    private List<Core.Entity.AdPlatform> FindAdPlatforms(IAdPlatformRepository rep, string location)
    {
        return rep.GetByLocation(location);
    }
    
}