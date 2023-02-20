using Soc.Contracts;

namespace Soc.Enterprise;

public class User : Contract
{
    public string DisplayName { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
}