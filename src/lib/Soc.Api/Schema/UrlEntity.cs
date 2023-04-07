using Soc.Api.Core;

namespace Soc.Api.Schema;
public abstract class UrlEntity : Entity
{
    public string Url { get; private set; } = string.Empty;

    protected static string Encode(string prop) =>
        UrlEncoder.Encode(prop);

    public override void OnSaving()
    {
        base.OnSaving();
        Url = Encode(Name);
    }
}