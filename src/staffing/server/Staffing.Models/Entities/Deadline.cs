using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class Deadline : Entity
{
    public int ProcessId { get; set; }
    public string? Description { get; set; }
    public string DueDate { get; set; } = string.Empty;

    public Process? Process { get; set; }
}