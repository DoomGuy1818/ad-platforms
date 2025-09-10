using ad_platform.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace ad_platform.Platforms;

public class LoadPlatformValidation : Validator<LoadAdPlatformsRequest>
{
    public LoadPlatformValidation()
    {
            RuleFor(x => x.PlatformPath)
                .NotEmpty()
                .WithMessage("Path is required.")
                .Must(File.Exists)
                .WithMessage("File doesn't exist.")
                .Must(FileValidationConfig.IsValidFile)
                .WithMessage("File must have a valid structure as platform:location.")
                .MinimumLength(2);
    }
}
