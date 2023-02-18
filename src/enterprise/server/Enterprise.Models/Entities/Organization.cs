namespace Enterprise.Models.Entities;

public class Organization : Entity
{
    public IEnumerable<OrganizationUser> Users { get; set; }
    public IEnumerable<Workflow> Workflows { get; set; }
    public IEnumerable<WorkflowT> WorkflowTs { get; set; }
}