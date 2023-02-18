using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class Note : Entity
{
    public int ProcessId { get; set; }
    public int UserId { get; set; }
    public string Body { get; set; }

    public Process Process { get; set; }
}