using Soc.Api.Schema;

namespace Enterprise.Models.Entities;

public class User : Entity
{
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;

    public IEnumerable<OrganizationUser>? Organizations { get; set; }
}