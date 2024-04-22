namespace PostmanWebAssemblyUI.UIModel;

public class RequestModel
{
    public string Url { get; set; } = string.Empty;
    public string Method { get; set; } = "GET";
    public string? DataToSend { get; set; } = string.Empty;
}
