namespace ad_platform.Infrastructure.Data.Config;

public static class FileValidationConfig
{
    public static bool IsValidFile(string file)
    {
        if (!File.Exists(file))
        {
            return false;
        }
        
        var lines = File.ReadAllLines(file);

        if (!IsValidFileStructure(lines))
        {
            return false;
        }

        return true;
    }

    private static bool IsValidFileStructure(string[] lines)
    {
        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }

            if (!line.Contains(':'))
            {
                return false;
            }

            var parts = line.Split(':');

            if (parts.Length != 2) return false;

            var adPlatform = parts[0].Trim();
            var locations = parts[1].Split(',');

            if (!IsValidPlatformName(adPlatform)) return false;

            if (!IsValidLocationStructure(locations)) return false;
        }

        return true;
    }

    private static bool IsValidPlatformName(string adPlatform)
    {
        if (string.IsNullOrWhiteSpace(adPlatform))
        {
            return false;
        }

        return true;
    }

    private static bool IsValidLocationStructure(string[] locations)
    {
        foreach (var location in locations)
        {
            var loc =  location.Trim();
                
            if (!loc.StartsWith('/'))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(loc))
            {
                return false;
            }
        }

        return true;
    }
}
