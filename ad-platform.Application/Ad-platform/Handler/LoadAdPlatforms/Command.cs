using System.Windows.Input;
using ad_platform.Core.Entity;
using Ardalis.Result;
using Ardalis.SharedKernel;
using MediatR;

namespace ad_platform.Application.Ad_platform.Handler.LoadAdPlatforms;

/// <summary>
/// Загрузка платформ из файла.
/// </summary>
/// <param platforms="Platforms"></param>
public record LoadAdPlatformsCommand(List<AdPlatform> Platforms) 
    : ICommand<Result<string>>;
