using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace BusinessLogic;

internal static class HelpingMethods
{
    private static readonly string errorMessage = "Wrong API call.";
    public static bool IsValidApiUrl(this string url)
    {
        string pattern = @"^https?://(((\w|\.)+(com|org|gr))|(localhost:\d{4}))((/|(\w+))+((\d+)?))(\?((\w+=\w+((\&\w+=\w+)+)?))?)?";
        return Regex.IsMatch(url, pattern);
    }
    public static HttpMethod RequestMethod(this string httpMethod)
    {
        switch (httpMethod)
        {
            case "GET": return HttpMethod.Get;
            case "POST": return HttpMethod.Post;
            case "PUT": return HttpMethod.Put;
            case "PATCH": return HttpMethod.Patch;
            case "DELETE": return HttpMethod.Delete;
            default: return null!;
        }
    }
    public static string BeautifiedJson(this string jsonString)
    {
        try
        {
            JToken parsedJson = JToken.Parse(jsonString);
            var beautifiedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return beautifiedJson;
        }
        catch
        {
            return errorMessage;
        }
    }
    public static string WhiteSpacesRemovedFromJson(this string jsonString)
    {
        return Regex.Replace(jsonString, @"\s+", "");
    }
}
