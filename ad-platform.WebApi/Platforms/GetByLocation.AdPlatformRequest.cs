using System.ComponentModel.DataAnnotations;
using FastEndpoints;

namespace ad_platform.Platforms;

public class GetAdPlatformRequest
{ 
        public const string Route = "/ad-platforms";
        
        [QueryParam]
        [Required]
        public required string Location { get; set; }
}