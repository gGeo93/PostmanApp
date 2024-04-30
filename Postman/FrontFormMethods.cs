using System.Text.RegularExpressions;

namespace Postman;

public static class FrontFormMethods
{
    public static bool IsValidUrl(this string url)
    {
        string pattern = @"^https?://(\w|\.)+(com|org|gr)((/|(\w+))+(\d+)?)?";
        return Regex.IsMatch(url, pattern);
    }
}
