using Enterprise.Data;
using Enterprise.Models.Entities;
using Soc.Api.Db;

namespace Enterprise.DbCli;
public class OrgUserSeeder : Seeder<OrganizationUser, AppDbContext>
{
    public OrgUserSeeder(AppDbContext db) : base(db) { }

    protected override async Task<List<OrganizationUser>> Generate()
    {
        List<OrganizationUser> orgUsers = new()
        {
            new()
            {
                User = new()
                {
                    Name = "Jaime Still",
                    LastName = "Still",
                    FirstName = "Jaime"
                },
                Organization = new()
                {
                    Name = "Adventureworks"
                }
            }
        };

        await db.OrganizationUsers.AddRangeAsync(orgUsers);
        await db.SaveChangesAsync();

        return orgUsers;
    }
}