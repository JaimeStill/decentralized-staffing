using Soc.Api.Contracts;

namespace Soc.Staffing;
public class Token : KeyContract
{
    public int PackageId { get; set; }
    public string PackageUrl { get; set; } = string.Empty;

    public int RegistrationId { get; set; }
    public string RegistrationUrl { get; set; } = string.Empty;

    public IEnumerable<TokenAttachment>? Attachments { get; set; }
}