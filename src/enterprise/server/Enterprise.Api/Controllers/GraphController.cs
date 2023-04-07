using Enterprise.Services;
using Microsoft.AspNetCore.Mvc;
using Soc.Api.Graph;

namespace Enterprise.Api.Controllers;

public class GraphController : GraphControllerBase
{
    readonly OrganizationService orgSvc;

    public GraphController(GraphService graph, OrganizationService orgSvc) : base(graph)
    {
        this.orgSvc = orgSvc;
    }

    [HttpGet("[action]/{sort?}")]
    public async Task<IActionResult> GetOrganizations([FromRoute]string? sort) =>
        Ok(await orgSvc.Get(sort));
}