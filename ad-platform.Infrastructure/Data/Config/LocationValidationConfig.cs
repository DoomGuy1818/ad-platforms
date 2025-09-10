namespace ad_platform.Infrastructure.Data.Config;

public static class LocationValidationConfig
{
    public static bool IsValidLocation(string location)
    {
        if (string.IsNullOrWhiteSpace(location)) return false;
        
        if (location.StartsWith('/'))
        {
            return true;
        }
        
        return false;
    }
}