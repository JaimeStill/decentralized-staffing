using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soc.Api.Schema;
using Soc.Api.Services;

namespace Soc.Api.Controllers;

public abstract class BaseController<T, Db> : ControllerBase
    where T : Base
    where Db : DbContext
{
    protected readonly IService<T, Db> svc;

    public BaseController(IService<T, Db> svc)
    {
        this.svc = svc;
    }

    [HttpGet("[action]/{id:int}")]
    public virtual async Task<IActionResult> GetById([FromRoute]int id) =>
        Ok(await svc.GetById(id));
        
    [HttpPost("[action]")]
    public virtual async Task<IActionResult> Validate([FromBody]T entity) =>
        Ok(await svc.Validate(entity));

    [HttpPost("[action]")]
    public virtual async Task<IActionResult> Save([FromBody]T entity) =>
        Ok(await svc.Save(entity));

    [HttpDelete("[action]")]
    public virtual async Task<IActionResult> Remove([FromBody]T entity) =>
        Ok(await svc.Remove(entity));
}