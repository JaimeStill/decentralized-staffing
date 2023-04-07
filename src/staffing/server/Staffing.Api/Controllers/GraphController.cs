using Soc.Api.Graph;

namespace Staffing.Api.Controllers;
public class GraphController : GraphControllerBase
{
    public GraphController(GraphService graph) : base(graph) { }
}