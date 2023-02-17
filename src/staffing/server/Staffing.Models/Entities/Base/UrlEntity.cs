using Staffing.Models.Core;

namespace Staffing.Models.Entities;
public abstract class UrlEntity : Entity
{
    public string Url { get; private set; }

    protected static string Encode(string prop) => UrlEncoder.Encode(prop);

    public override void OnSaving()
    {
        base.OnSaving();
        Url = Encode(Name);
    }
}