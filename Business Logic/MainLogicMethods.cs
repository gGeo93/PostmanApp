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

    #region GetLogic

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

    public void PostRequest(string url, string jsonBody)
    {
        dataProcedures.PostData(url, jsonBody);
    }

    public void PutRequest(string url, string jsonBody) 
    { 
        dataProcedures.PutData(url, jsonBody);
    }
    public void DeleteRequest(string url)
    {
        dataProcedures.DeleteData(url);
    }
}
