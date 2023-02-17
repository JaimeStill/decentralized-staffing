namespace Staffing.Models.Entities;

public class Requirement : Entity
{
    public int ProcessId { get; set; }
    public bool IsComplete { get; set; }

    public Process Process { get; set; }
}