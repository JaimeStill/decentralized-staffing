namespace Staffing.Models.Entities;

public class Package : Entity
{
    public int? WorkflowId { get; set; }
    public string Description { get; set; }
    public string Tag { get; set; }

    public Workflow Workflow { get; set; }

    public Token Token { get; set; }

    public IEnumerable<PackageAttachment> Attachments { get; set; }
    public IEnumerable<Resource> Resources { get; set; }
}