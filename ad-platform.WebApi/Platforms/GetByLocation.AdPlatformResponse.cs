namespace ad_platform.Platforms;

public class GetAdPlatformResponse
{
    
    public GetAdPlatformResponse(List<string> locations)
    {
        Location = locations;
    }
    
    public List<string> Location { get; set; }
}