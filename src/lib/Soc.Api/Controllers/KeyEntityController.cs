using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soc.Api.Schema;
using Soc.Api.Services;

namespace Soc.Api.Controllers;

public abstract class KeyEntityController<T, Db> : UrlEntityController<T, Db>
    where T : KeyEntity
    where Db : DbContext
{
    protected readonly KeyEntityService<T, Db> keyEntitySvc;

    public KeyEntityController(KeyEntityService<T, Db> svc) : base(svc)
    {
        keyEntitySvc = svc;
    }

    [HttpGet("[action]/{key:guid}")]
    public virtual async Task<IActionResult> GetByKey([FromRoute]Guid key) =>
        Ok(await keyEntitySvc.GetByKey(key));
}