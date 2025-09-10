using ad_platform.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace ad_platform.Platforms;

public class GetAdPlatformValidation : Validator<GetAdPlatformRequest>
{
    public GetAdPlatformValidation()
    {
        RuleFor(x => x.Location)
            .NotEmpty()
            .WithMessage("Path is required.")
            .Must(LocationValidationConfig.IsValidLocation)
            .WithMessage("location must starts with /")
            .MinimumLength(2);
    }
    
}