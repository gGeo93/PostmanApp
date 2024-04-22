namespace BusinessLogic;

public interface IMainLogicMethods
{
    Task<string> GenericRequest(string url, string? dataToSend, string httpMethod);
}