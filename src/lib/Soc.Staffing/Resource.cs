using Soc.Api.Contracts;

namespace Soc.Staffing;

public class Resource : Contract
{
    public int OriginId { get; set; }
    public string OriginType { get; set; } = string.Empty;

    public string? Link { get; set; }
    public string? Description { get; set; }
}