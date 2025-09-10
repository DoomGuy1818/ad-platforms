using ad_platform.Application.Ad_platform.Interfaces;
using ad_platform.Core.Entity;

namespace ad_platform.Infrastructure.Reader.FileReader;

public class FileReader : IReader
{
    public List<AdPlatform> Read(string path)
    {
        var lines = File.ReadAllLines(path);
        var platforms = new List<AdPlatform>();

        foreach (var line in lines)
        {
            var parts = line.Split(':');
            
            var platformName =  parts[0].Trim();
            var paths  = parts[1].Split(',');

            platforms.Add(new AdPlatform(platformName, paths.ToList()));
        }
        
        return platforms;
    }
}