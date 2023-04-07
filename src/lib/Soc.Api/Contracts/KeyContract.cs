namespace Soc.Api.Contracts;

public abstract class KeyContract : UrlContract
{
    public Guid Key { get; set; }
}