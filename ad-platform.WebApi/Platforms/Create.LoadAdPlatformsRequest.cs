using System.ComponentModel.DataAnnotations;

namespace ad_platform.Platforms;

public class LoadAdPlatformsRequest
{
    public const string Route = "/ad-platforms";
    
    [Required]
    public required string PlatformPath { get; set; }
}