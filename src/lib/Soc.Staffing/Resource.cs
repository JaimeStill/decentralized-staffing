using Soc.Contracts;

namespace Soc.Staffing;

public class Resource : Contract
{
    public int OriginId { get; set; }
    public string OriginType { get; set; }

    public string Link { get; set; }
    public string Description { get; set; }
}