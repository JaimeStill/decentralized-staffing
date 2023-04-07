using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class ReviewT : Entity
{
    public int ProcessTId { get; set; }
    public int RoleId { get; set; }

    public ProcessT? ProcessT { get; set; }
    public Role? Role { get; set; }
}