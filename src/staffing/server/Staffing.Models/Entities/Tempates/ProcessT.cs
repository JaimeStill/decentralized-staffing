using Soc.Api.Schema;

namespace Staffing.Models.Entities;
public class ProcessT : Entity
{
    public int RoleId { get; set; }
    public int WorkflowTId { get; set; }
    
    public int Index { get; set; }
    public string Description { get; set; }

    public Role Role { get; set; }
    public WorkflowT WorkflowT { get; set; }

    public DeadlineT DeadlineT { get; set; }

    public IEnumerable<RequirementT> RequirementTs { get; set; }
    public IEnumerable<ReviewT> ReviewTs { get; set; }
}