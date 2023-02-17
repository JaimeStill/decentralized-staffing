using Staffing.Models.Core;

namespace Staffing.Models.Entities;
public abstract class Entity : Base
{
    public string Name { get; set; }
    public string DateCreated { get; set; }
    public string LastModified { get; set; }

    public virtual void OnSaving()
    {
        if (string.IsNullOrWhiteSpace(DateCreated))
            DateCreated = LastModified = JsDateEncoder.JsDate(DateTime.Now);
        else
            LastModified = JsDateEncoder.JsDate(DateTime.Now);
    }
}