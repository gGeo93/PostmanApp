using DataAccess;
using Newtonsoft.Json.Linq;

namespace BusinessLogic;

public class MainLogicMethods : IMainLogicMethods
{
    
    DataProcedures dataProcedures;
    
    public MainLogicMethods()
    {
        dataProcedures = new DataProcedures();
    }

    public async Task<string> GenericRequest(string url, string? dataToSend, string httpMethod) 
    { 
        return BeautifiedJson(await dataProcedures.CrudOperation(url, dataToSend, RequestMethod(httpMethod)));
    }

    private HttpMethod RequestMethod(string httpMethod) 
    { 
        switch(httpMethod) 
        {
            case "GET": return HttpMethod.Get;
            case "POST": return HttpMethod.Post;
            case "PUT": return HttpMethod.Put;
            case "PATCH": return HttpMethod.Patch;
            case "DELETE": return HttpMethod.Delete;
            default: return null!;
        }
    }
    private string BeautifiedJson(string jsonString)
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
}
