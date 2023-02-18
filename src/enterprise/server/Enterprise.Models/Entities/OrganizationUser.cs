namespace Enterprise.Models.Entities;

public class OrganizationUser : Base
{
    public int OrganizationId { get; set; }
    public int UserId { get; set; }

    public Organization Organization { get; set; }
    public User User { get; set; }
}