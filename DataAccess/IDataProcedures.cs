namespace DataAccess;

public interface IDataProcedures
{
    string FetchData(string url);
    string SendDataToFront();

    void PostData(string url, string dataToPost);

    void PutData(string url, string dataToPut);

    void DeleteData(string url);
}