namespace Staffing.Models.Entities;

public class PackageAttachment : Attachment
{
    public int PackageId { get; set; }

    public Package Package { get; set; }
}