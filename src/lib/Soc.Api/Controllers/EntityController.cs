using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soc.Api.Schema;
using Soc.Api.Services;

namespace Soc.Api.Controllers;

public abstract class EntityController<T, Db> : BaseController<T, Db>
    where T : Entity
    where Db : DbContext
{
    protected readonly EntityService<T, Db> entitySvc;

    public EntityController(EntityService<T, Db> svc) : base(svc)
    {
        entitySvc = svc;
    }

    // !!!Build out Query infrastructure!!!!

    [HttpPost("[action]")]
    public virtual async Task<IActionResult> ValidateName([FromBody]T entity) =>
        Ok(await entitySvc.ValidateName(entity));
}