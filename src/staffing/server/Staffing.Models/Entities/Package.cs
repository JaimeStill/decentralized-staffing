using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class Package : Entity
{
    public int? WorkflowId { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Tag { get; set; } = string.Empty;

    public Workflow? Workflow { get; set; }

    public Token? Token { get; set; }

    public IEnumerable<PackageAttachment>? Attachments { get; set; }
    public IEnumerable<Resource>? Resources { get; set; }
}