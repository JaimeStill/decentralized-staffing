using Soc.Api.Schema;

namespace Staffing.Models.Entities;

public abstract class Attachment : UrlEntity
{
    public string Type { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
    public string FileType { get; set; } = string.Empty;
    public long Size { get; set; }
}