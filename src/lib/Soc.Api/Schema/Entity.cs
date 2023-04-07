using Soc.Api.Core;

namespace Soc.Api.Schema;
public abstract class Entity : Base
{
    public string Name { get; set; } = string.Empty;
    public string DateCreated { get; set; } = string.Empty;
    public string LastModified { get; set; } = string.Empty;

    public virtual void OnSaving()
    {
        if (string.IsNullOrWhiteSpace(DateCreated))
            DateCreated = LastModified = JsDateEncoder.JsDate(DateTime.Now);
        else
            LastModified = JsDateEncoder.JsDate(DateTime.Now);
    }
}