using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class WorkflowT : Entity
{
    public int OrganizationId { get; set; }
    public string Description { get; set; }

    public IEnumerable<ProcessT> ProcessTs { get; set; }
}