using Soc.Api.Schema;

namespace Enterprise.Models.Entities;

public class Organization : Entity
{
    public IEnumerable<OrganizationUser>? Users { get; set; }
}