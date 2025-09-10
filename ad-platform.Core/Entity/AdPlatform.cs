using System.Collections.Generic;

namespace ad_platform.Core.Entity;

public class AdPlatform
{
    public string Name { get; set; }
    public List<string> Locations { get; set; }
    
    public AdPlatform(string name, List<string> locations)
    {
        Name = name;
        Locations = locations;
    }
}
