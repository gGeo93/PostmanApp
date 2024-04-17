using System.Text;

namespace DataAccess
{
    public class DataProcedures : IDataProcedures
    {
        private string JsonData { get; set; } = string.Empty;        
      
        public string CrudOperation(string url, string? dataToSend, HttpMethod httpMethod)
        {
            try
            {
                HttpResponseMessage response;
                using (var client = new HttpClient())
                {
                    response = HttpClientCall(url, dataToSend, httpMethod, client);
                }
                return response.IsSuccessStatusCode ? JsonData : response.ReasonPhrase!; 
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private HttpResponseMessage HttpClientCall(string url, string? dataToSend, HttpMethod httpMethod, HttpClient client)
        {
            HttpResponseMessage response;

            JsonData = string.Empty;
            
            var request = new HttpRequestMessage(httpMethod, url);
            
            if (!string.IsNullOrEmpty(dataToSend))
                request.Content = new StringContent(dataToSend, Encoding.UTF8, "application/json");
           
            response = client.Send(request);
            
            JsonData = response.Content.ReadAsStringAsync().Result;
            
            return response;
        }
    }
}
