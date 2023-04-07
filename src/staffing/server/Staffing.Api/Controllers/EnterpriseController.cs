using Microsoft.AspNetCore.Mvc;
using Soc.Enterprise;

namespace Staffing.Api.Controllers;

[Route("graph/[controller]")]
public class EnterpriseController : Controller
{
    readonly EnterpriseGraph graph;

    public EnterpriseController(EnterpriseGraph graph)
    {
        this.graph = graph;
    }

    [HttpGet]
    public async Task<IActionResult> Get() =>
        Ok(await graph.Initialize());

    [HttpGet("[action]/{sort?}")]
    public async Task<IActionResult> GetOrganizations(
        [FromRoute] string? sort
    ) => Ok(await graph.GetOrganizations(sort));
}