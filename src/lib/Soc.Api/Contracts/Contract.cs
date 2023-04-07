namespace Soc.Api.Contracts;

public abstract class Contract
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}