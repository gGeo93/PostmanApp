using DataAccess;

namespace BusinessLogic;

public class MainLogicMethods : IMainLogicMethods
{
    
    DataProcedures dataProcedures;
    
    public MainLogicMethods()
    {
        dataProcedures = new DataProcedures();
    }

    public string GenericRequest(string url, string? dataToSend, HttpMethod httpMethod) 
    { 
        return dataProcedures.CrudOperation(url, dataToSend, httpMethod);
    }
}
