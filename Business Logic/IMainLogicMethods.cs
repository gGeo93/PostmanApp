namespace BusinessLogic;

public interface IMainLogicMethods
{
    void GetRequest(string url);
    string GetResponse();

    void PostRequest(string url, string jsonBody);

    void PutRequest(string url, string jsonBody);

    void DeleteRequest(string url);
}