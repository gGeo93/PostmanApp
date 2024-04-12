namespace BusinessLogic;

public interface IMainLogicMethods
{
    string GenericRequest(string url, string? dataToSend, HttpMethod httpMethod);
}