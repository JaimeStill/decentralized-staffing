namespace Staffing.Models.Entities;

public class User : UrlEntity
{
    public string DisplayName { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
}