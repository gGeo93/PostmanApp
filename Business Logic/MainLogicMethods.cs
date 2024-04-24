using Business_Logic;
using DataAccess;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BusinessLogic;

public class MainLogicMethods : IMainLogicMethods
{
    DataProcedures dataProcedures;
    
    public MainLogicMethods()
    {
        dataProcedures = new DataProcedures();
    }

    public async Task<string> GenericRequest(string url, string dataToSend, string httpMethod) 
    {
        return HelpingMethods.BeautifiedJson(await dataProcedures.CrudOperation(url, 
            dataToSend.WhiteSpacesRemovedFromJson(), 
            httpMethod.RequestMethod()));
    }
}
