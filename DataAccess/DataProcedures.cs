using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataProcedures : IDataProcedures
    {
        private string JsonData { get; set; } = string.Empty;
        private string ErrorMessage { get; set; } = string.Empty;
        
        #region GetDataAccess
        
        public string FetchData(string url)
        {
            try 
            {
                using(var client = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, url);
                    HttpResponseMessage responseMessage = client.Send(request);
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

        #region PostDataAccess
        public void PostData(string url, string dataToPost)
        {
            try 
            { 
                using(var client = new HttpClient()) 
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, url);
                    request.Content = new StringContent(dataToPost, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.Send(request);                
                }
            }
            catch 
            {
                throw;
            }
        }

        #endregion

        #region PutDataAccess
        public void PutData(string url, string dataToPut)
        {
            try 
            {
                using(var client = new HttpClient()) 
                { 
                    var request = new HttpRequestMessage(HttpMethod.Put, url);
                    request.Content = new StringContent(dataToPut, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.Send(request);
                }
            }
            catch 
            {
                throw;
            }
        }

        #endregion

        #region DeleteDataAccess
        public void DeleteData(string url)
        {
            try 
            { 
                using(var client = new HttpClient()) 
                { 
                    var request = new HttpRequestMessage(HttpMethod.Delete, url);
                    var response = client.Send(request);
                }                
            }
            catch 
            {
                throw;
            }
        }

        public string CrudOperation(string url, string? dataToSend, HttpMethod httpMethod)
        {
            try 
            { 
                using (var client = new HttpClient()) 
                {
                    var request = new HttpRequestMessage(httpMethod, url);
                    if (!string.IsNullOrEmpty(dataToSend))
                        request.Content = new StringContent(dataToSend, Encoding.UTF8, "application/json");
                    var response = client.Send(request);
                    JsonData = response.Content.ReadAsStringAsync().Result;
                }
                return string.IsNullOrEmpty(JsonData) ? "Operation Completed Succesfully!" : JsonData;
            }
            catch(Exception ex) 
            {
                ErrorMessage = ex.Message;
                return ErrorMessage;
            }
        }

        #endregion
    }
}
