using ad_platform.Core.Entity;
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace ad_platform.Application.Ad_platform.Handler.GetAdPlatform;

    /// <summary>
    /// Загрузка платформ из файла.
    /// </summary>
    /// <param platforms="Platforms"></param>
    public record GetAdPlatformsCommand(string Location) 
        : ICommand<Result<List<string>>>;
