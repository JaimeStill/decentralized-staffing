using Enterprise.Data;
using Enterprise.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Soc.Api.Services;

namespace Enterprise.Services;
public class UserService : EntityService<User>
{
    public UserService(AppDbContext db) : base (db) { }
    
    public async Task<ApiResult<OrganizationUser>> JoinOrganization(int orgId, int userId)
    {
        try
        {
            OrganizationUser orgUser = new()
            {
                OrganizationId = orgId,
                UserId = userId
            };

            await db.OrganizationUsers.AddAsync(orgUser);
            await db.SaveChangesAsync();

            return new(orgUser, "User successfully joined to Organization");
        }
        catch (Exception ex)
        {
            return new("Join Organization", ex);
        }
    }
}