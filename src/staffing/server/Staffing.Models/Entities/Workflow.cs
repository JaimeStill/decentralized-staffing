using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class Workflow : UrlEntity
{
    public int OrganizationId { get; set; }
    public string? Description { get; set; }
    public bool IsComplete { get; set; }    
    
    public Package? Package { get; set; }

    public IEnumerable<Process>? Processes { get; set; }
}