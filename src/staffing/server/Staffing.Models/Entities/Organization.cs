namespace Staffing.Models.Entities;

public class Organization : UrlEntity
{
    public IEnumerable<OrganizationUser> Users { get; set; }
    public IEnumerable<Workflow> Workflows { get; set; }
    public IEnumerable<WorkflowT> WorkflowTs { get; set; }
}