using Microsoft.AspNetCore.Mvc;

namespace Soc.Api.Graph;

[Route("graph")]
public abstract class GraphControllerBase : ControllerBase
{
    protected readonly GraphService svc;

    public GraphControllerBase(GraphService svc)
    {
        this.svc = svc;
    }

    [HttpGet]
    public IActionResult Get() => Ok(svc.GraphId);
}