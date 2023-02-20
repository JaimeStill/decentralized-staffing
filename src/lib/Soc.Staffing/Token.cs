using Soc.Contracts;

namespace Soc.Staffing;
public class Token : KeyContract
{
    public int PackageId { get; set; }
    public string PackageUrl { get; set; }

    public int RegistrationId { get; set; }
    public string RegistrationUrl { get; set; }

    public IEnumerable<TokenAttachment> Attachments { get; set; }
}