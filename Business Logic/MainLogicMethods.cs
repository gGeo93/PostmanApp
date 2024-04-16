using DataAccess;

namespace BusinessLogic;

public class MainLogicMethods : IMainLogicMethods
{
    
    DataProcedures dataProcedures;
    
    public MainLogicMethods()
    {
        dataProcedures = new DataProcedures();
    }

    public string GenericRequest(string url, string? dataToSend, string httpMethod) 
    { 
        return dataProcedures.CrudOperation(url, dataToSend, RequestMethod(httpMethod));
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
}
