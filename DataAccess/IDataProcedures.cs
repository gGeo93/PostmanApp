namespace DataAccess;

public interface IDataProcedures
{
    string CrudOperation(string url,string? dataToSend,HttpMethod httpMethod);
}