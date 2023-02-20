namespace Soc.Contracts;

public abstract class AttachmentContract : UrlContract
{
    public string Type { get; set; }
    public string File { get; set; }
    public string FileType { get; set; }
    public long Size { get; set; }
}