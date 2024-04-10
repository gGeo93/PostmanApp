namespace DataAccess;

public interface IDataProcedures
{
    string FetchData(string url);
    string SendDataToFront();
}