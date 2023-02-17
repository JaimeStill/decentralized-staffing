namespace Staffing.Models.Entities;

public class WorkflowT : Entity
{
    public int OrganizationId { get; set; }
    public string Description { get; set; }

    public Organization Organization { get; set; }

    public IEnumerable<ProcessT> ProcessTs { get; set; }
}