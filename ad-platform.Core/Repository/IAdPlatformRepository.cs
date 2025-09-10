using ad_platform.Core.Entity;

namespace ad_platform.Core.Repository;

public interface IAdPlatformRepository
{
    public void SaveAdPlatform(List<AdPlatform> platforms);
    public List<AdPlatform> GetByLocation(string location);
}