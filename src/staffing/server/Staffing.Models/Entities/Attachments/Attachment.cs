namespace Staffing.Models.Entities;

public abstract class Attachment : UrlEntity
{
    public string Type { get; set; }
    public string Path { get; set; }
    public string File { get; set; }
    public string FileType { get; set; }
    public long Size { get; set; }
}