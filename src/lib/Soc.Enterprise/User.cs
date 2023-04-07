using Soc.Contracts;

namespace Soc.Enterprise;

public class User : Contract
{
    public string DisplayName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
}