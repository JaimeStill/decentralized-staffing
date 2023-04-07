using Soc.Api.Schema;

namespace Staffing.Models.Entities;
public class ApprovalT : Entity
{
    public int ProcessTId { get; set; }

    public ProcessT? ProcessT { get; set; }
}