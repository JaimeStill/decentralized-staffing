namespace Staffing.Models.Entities;

public class UserRole : Base
{
    public int RoleId { get; set; }
    public int UserId { get; set; }

    public Role Role { get; set; }
    public User User { get; set; }
}