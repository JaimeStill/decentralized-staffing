using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soc.Api.Schema;
using Soc.Api.Services;

namespace Soc.Api.Controllers;

public abstract class BaseController<T, Db> : ControllerBase
    where T : Base
    where Db : DbContext
{
    protected readonly IService<T, Db> baseSvc;

    public BaseController(IService<T, Db> svc)
    {
        baseSvc = svc;
    }

    [HttpGet("[action]/{sort?}")]
    public virtual async Task<IActionResult> Get([FromRoute] string? sort) =>
        Ok(await baseSvc.Get(sort));

    [HttpGet("[action]/{id:int}")]
    public virtual async Task<IActionResult> GetById([FromRoute]int id) =>
        Ok(await baseSvc.GetById(id));
        
    [HttpPost("[action]")]
    public virtual async Task<IActionResult> Validate([FromBody]T entity) =>
        Ok(await baseSvc.Validate(entity));

    [HttpPost("[action]")]
    public virtual async Task<IActionResult> Save([FromBody]T entity) =>
        Ok(await baseSvc.Save(entity));

    [HttpDelete("[action]")]
    public virtual async Task<IActionResult> Remove([FromBody]T entity) =>
        Ok(await baseSvc.Remove(entity));
}