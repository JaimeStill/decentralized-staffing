using EnterpriseData;
using Enterprise.Models.Entities;
using Enterprise.Services;
using Microsoft.AspNetCore.Mvc;
using Soc.Api.Controllers;

namespace Enterprise.Api.Controllers;

[Route("api/[controller]")]
public class UserController : EntityController<User, AppDbContext>
{
    readonly UserService userSvc;

    public UserController(UserService svc)
        : base (svc)
    {
        userSvc = svc;
    }

    [HttpGet("[action]/{orgId:int}/{userId:int}")]
    public async Task<IActionResult> JoinOrganization([FromRoute]int orgId, [FromRoute]int userId) =>
        Ok(await userSvc.JoinOrganization(orgId, userId));
}