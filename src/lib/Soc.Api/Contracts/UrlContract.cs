namespace Soc.Api.Contracts;

public abstract class UrlContract : Contract
{
    public string Url { get; set; } = string.Empty;
}