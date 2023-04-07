using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class DeadlineT : TimedEntity
{
    public int ProcessTId { get; set; }
    public string Description { get; set; } = string.Empty;

    public ProcessT? ProcessT { get; set; }
}