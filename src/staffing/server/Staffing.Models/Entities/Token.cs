namespace Staffing.Models.Entities;

public class Token : KeyEntity
{
    public int RegistrationId { get; set; }
    public int PackageId { get; set; }

    public Package Package { get; set; }
    public Registration Registration { get; set; }

    public IEnumerable<TokenAttachment> Attachments { get; set; }
}