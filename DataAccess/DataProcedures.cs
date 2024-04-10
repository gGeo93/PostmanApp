using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataProcedures : IDataProcedures
    {
        #region GetDataAccess
        private string JsonData { get; set; } = string.Empty;
        
        public string FetchData(string url)
        {
            try 
            {
                using(var client = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, url);
                    HttpResponseMessage responseMessage = client.SendAsync(request).Result;
                    JsonData = responseMessage.Content.ReadAsStringAsync().Result;
                }
                return JsonData;
            }
            catch(Exception ex) 
            {
                JsonData = $"There was an error: {ex.Message}";
                return JsonData;
            }
        }

        public string SendDataToFront()
        {
            return JsonData;
        }
        #endregion
    }
}
