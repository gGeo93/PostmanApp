using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic;

public class MainLogicMethods : IMainLogicMethods
{
    #region GetLogic
    
    DataProcedures dataProcedures;
    
    public MainLogicMethods()
    {
        dataProcedures = new DataProcedures();
    }
    
    /// <summary>
    /// Sends url to fetch data.
    /// </summary>
    /// <param name="url"></param>
    /// <returns>url</returns>
    public void GetRequest(string url)
    {
        dataProcedures.FetchData(url);
    }
    
    /// <summary>
    /// Returns data to front 
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public string GetResponse()
    {
        return dataProcedures.SendDataToFront();
    }
    #endregion
}
