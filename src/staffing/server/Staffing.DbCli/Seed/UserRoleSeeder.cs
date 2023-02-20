using Staffing.Data;
using Staffing.Models.Entities;

namespace Staffing.DbCli.Seed;
public class UserRoleSeeder : Seeder<UserRole, AppDbContext>
{
    readonly int orgId;
    readonly int userId;

    public UserRoleSeeder(AppDbContext db, int orgId, int userId) : base(db)
    {
        this.orgId = orgId;
        this.userId = userId;
    }

    protected override async Task<List<UserRole>> Generate()
    {
        List<UserRole> userRoles = new()
        {
            new()
            {
                UserId = userId,
                Role = new()
                {
                    OrganizationId = orgId,
                    Name = "Approver",
                    Description = "Authorized to approve staffing events"                                        
                }
            }
        };

        await db.UserRoles.AddRangeAsync(userRoles);
        await db.SaveChangesAsync();

        return userRoles;
    }
}