using ad_platform.Core.Entity;
using ad_platform.Core.Repository;
using Ardalis.Result;
using Ardalis.SharedKernel;
using MediatR;

namespace ad_platform.Application.Ad_platform.Handler.LoadAdPlatforms;

public class Handler : ICommandHandler<LoadAdPlatformsCommand, Result<string>>
{
    private readonly IAdPlatformRepository _repository;

    public Handler(IAdPlatformRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<string>> Handle(
        LoadAdPlatformsCommand request,
        CancellationToken cancellationToken)
    {
        try
        {
            _repository.SaveAdPlatform(request.Platforms);
            await Task.CompletedTask;

            foreach (var platform in request.Platforms)
            {
                foreach (var loc in platform.Locations)
                {
                    Console.WriteLine(loc);
                }
            }
            
            return Result.Success($"Сохранено {request.Platforms.Count} площадок");
        }
        catch (Exception ex)
        {
            return Result.Error($"Ошибка: {ex.Message}");
        }
    }
}
