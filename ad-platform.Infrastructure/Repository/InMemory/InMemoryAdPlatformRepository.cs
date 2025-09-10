using ad_platform.Core.Entity;
using ad_platform.Core.Repository;

namespace ad_platform.Infrastructure.Repository.InMemory;

public class InMemoryAdPlatformRepository : IAdPlatformRepository 
{
    private readonly List<AdPlatform> _adPlatforms = new();
    
    public void SaveAdPlatform(List<AdPlatform> platforms)
    {
        _adPlatforms.Clear();
        foreach (var platform in platforms)
        {
            _adPlatforms.Add(platform);
        }
        
    }

    public List<AdPlatform> GetByLocation(string location)
    {
        return _adPlatforms
            .Where(p => p.Locations.Any(loc => location.StartsWith(loc)))
            .ToList();
    }
}