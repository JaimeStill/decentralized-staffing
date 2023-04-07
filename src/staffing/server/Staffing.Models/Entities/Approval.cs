using Soc.Api.Schema;

namespace Staffing.Models.Entities;
public class Approval : Entity
{
    public int ProcessId { get; set; }
    public bool? IsApproved { get; set; }
    public bool? IsRejected { get; set; }

    public Process? Process { get; set; }
}