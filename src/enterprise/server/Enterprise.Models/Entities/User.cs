namespace Enterprise.Models.Entities;

public class User : Entity
{
    public string DisplayName { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public IEnumerable<Note> Notes { get; set; }
    public IEnumerable<OrganizationUser> Organizations { get; set; }
    public IEnumerable<Process> Processes { get; set; }
    public IEnumerable<Review> Reviews { get; set; }
    public IEnumerable<UserRole> Roles { get; set; }
}