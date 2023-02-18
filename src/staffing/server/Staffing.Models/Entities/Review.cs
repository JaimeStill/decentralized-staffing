using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class Review : Entity
{
    public int ProcessId { get; set; }
    public int RoleId { get; set; }
    public int? UserId { get; set; }
    public bool? Concur { get; set; }

    public Process Process { get; set; }
    public Role Role { get; set; }
}