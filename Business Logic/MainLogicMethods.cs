using DataAccess;

namespace BusinessLogic;

public class MainLogicMethods : IMainLogicMethods
{
    DataProcedures dataProcedures;
    private readonly string invalidUrlErrorCase = "Invalid Api Url.";
    public MainLogicMethods()
    {
        dataProcedures = new DataProcedures();
    }
    public async Task<string> GenericRequest(string url, string dataToSend, string httpMethod) 
    {
        return 
            url.IsValidApiUrl() 
            ? HelpingMethods.BeautifiedJson(await dataProcedures.CrudOperation(
                                                url, 
                                                dataToSend.WhiteSpacesRemovedFromJson(), 
                                                httpMethod.RequestMethod()))
            : invalidUrlErrorCase;
    }
}
