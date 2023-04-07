using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Soc.Api.Graph;
public class GraphService
{
    readonly Graph graph;

    public GraphService(IConfiguration config)
    {
        graph = config
            .GetSection("Graph")
            .Get<Graph>()
        ?? throw new Exception(
            "Graph configuration is missing or invalid. It must be provided when registering GraphService."
        );
    }

    public Guid GraphId => graph.Id;
    public List<Endpoint> Endpoints => graph.Endpoints;

    public Endpoint GetEndpoint(string name) =>
        graph.Endpoints.First(x =>
            x.Name.ToLower() == name.ToLower()
        );
}

public static class GraphRegistration
{
    public static void AddGraphService(this IServiceCollection services) =>
        services.AddSingleton<GraphService>();
}