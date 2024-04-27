using System.Text;

namespace DataAccess;

public class DataProcedures : IDataProcedures
{
    private string JsonData { get; set; } = string.Empty;
    private HttpResponseMessage? Response { get; set; } = new HttpResponseMessage();
  
    public async Task<string> CrudOperation(string url, string? dataToSend, HttpMethod httpMethod)
    {
        try
        {
            Response = await HttpClientCall(url, dataToSend, httpMethod);
            
            return Response.IsSuccessStatusCode ? JsonData : Response.ReasonPhrase!; 
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        finally
        {
            Response?.Dispose();       
        }
    }

    private async Task<HttpResponseMessage> HttpClientCall(string url, string? dataToSend, HttpMethod httpMethod)
    {
        using (var client = new HttpClient())
        {            
            JsonData = string.Empty;
        
            var request = new HttpRequestMessage(httpMethod, url);
        
            if (!string.IsNullOrEmpty(dataToSend))
                request.Content = new StringContent(dataToSend, Encoding.UTF8, "application/json");

            var response = await client.SendAsync(request);

            JsonData = await response.Content.ReadAsStringAsync();
        
            return response;
        }
    }
}
