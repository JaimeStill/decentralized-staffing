using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soc.Api.Schema;
using Soc.Api.Services;

namespace Soc.Api.Controllers;

public abstract class UrlEntityController<T, Db> : EntityController<T, Db>
    where T : UrlEntity
    where Db : DbContext
{
    protected readonly UrlEntityService<T, Db> urlEntitySvc;

    public UrlEntityController(UrlEntityService<T, Db> svc) : base(svc)
    {
        urlEntitySvc = svc;
    }

    [HttpGet("[action]/{url}")]
    public virtual async Task<IActionResult> GetByUrl([FromRoute]string url) =>
        Ok(await urlEntitySvc.GetByUrl(url));
}