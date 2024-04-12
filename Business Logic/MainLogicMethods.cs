using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
