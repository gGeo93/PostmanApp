using System.Text;

namespace DataAccess
{
    public class DataProcedures : IDataProcedures
    {
        private string JsonData { get; set; } = string.Empty;
        private string ErrorMessage { get; set; } = string.Empty;
        
      
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
    }
}
