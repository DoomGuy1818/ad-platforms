namespace ad_platform.Platforms;

public class LoadAdPlatformsResponse
{
    public LoadAdPlatformsResponse(string message)
    {
        Message =  message;
    }
    
    public string Message { get; set; }
}