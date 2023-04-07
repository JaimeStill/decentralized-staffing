using Soc.Api.Db;
using Staffing.Data;
using Staffing.Models.Entities;

namespace Staffing.DbCli;
public class UserRoleSeeder : Seeder<UserRole, AppDbContext>
{
    public UserRoleSeeder(AppDbContext db) : base(db) { }

    protected override async Task<List<UserRole>> Generate()
    {
        List<UserRole> userRoles = new()
        {
            new()
            {
                UserId = 1,
                Role = new()
                {
                    OrganizationId = 1,
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