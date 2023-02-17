namespace Staffing.Models.Entities;

public abstract class KeyEntity : UrlEntity
{
    public Guid Key { get; set; }
}