using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public class Resource : Entity
{
    public int OriginId { get; set; }
    public string OriginType { get; set; } = string.Empty;

    public int PackageId { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }

    public Package? Package { get; set; }
}