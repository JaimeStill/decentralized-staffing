namespace Soc.Api.Contracts;

public abstract class AttachmentContract : UrlContract
{
    public string Type { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
    public string FileType { get; set; } = string.Empty;
    public long Size { get; set; }
}