using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Business_Logic;

public static class HelpingMethods
{
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
            return jsonString;
        }
    }
    public static string WhiteSpacesRemovedFromJson(this string jsonString)
    {
        return Regex.Replace(jsonString, @"\s+", "");
    }
}
