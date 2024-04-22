namespace DataAccess;

public interface IDataProcedures
{
    Task<string> CrudOperation(string url,string? dataToSend,HttpMethod httpMethod);
}