namespace ad_platform.Application.Ad_platform.Interfaces;

public interface IReader
{
    public List<Core.Entity.AdPlatform> Read(string path);
}