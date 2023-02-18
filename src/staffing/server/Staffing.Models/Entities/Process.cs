using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class Process : Entity
{
    public int RoleId { get; set; }
    public int? UserId { get; set; }
    public int WorkflowId { get; set; }

    public int Index { get; set; }
    public string Description { get; set; }
    public bool? IsApproved { get; set; }
    public bool? IsRejected { get; set; }

    public Role Role { get; set; }
    public Workflow Workflow { get; set; }

    public Deadline Deadline { get; set; }

    public IEnumerable<ProcessAttachment> Attachments { get; set; }
    public IEnumerable<Note> Notes { get; set; }
    public IEnumerable<Requirement> Requirements { get; set; }
    public IEnumerable<Review> Reviews { get; set; }
}