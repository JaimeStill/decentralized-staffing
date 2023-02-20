using Soc.Contracts;

namespace Soc.Staffing;

public class Package : Contract
{
    public string Description { get; set; }
    public string Tag { get; set; }

    public IEnumerable<Resource> Resources { get; set; }
}