using Soc.Api.Schema;

namespace Enterprise.Models.Entities;

public class User : Entity
{
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public IEnumerable<OrganizationUser> Organizations { get; set; }
}