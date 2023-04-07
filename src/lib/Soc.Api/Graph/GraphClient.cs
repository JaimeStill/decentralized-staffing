using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection;

namespace Soc.Api.Graph;

public abstract class GraphClient
{
    protected HttpClient http = new();
    protected Endpoint endpoint;
    protected Guid? endpointId;

    protected bool Available => endpointId.HasValue;

    public GraphClient(GraphService graph, string name)
    {
        endpoint = graph.GetEndpoint(name);
    }

    public async Task<Guid?> Initialize()
    {
        endpointId = await http.GetFromJsonAsync<Guid>(endpoint.Url);
        return endpointId;
    }
}

public static class GraphClientExtensions
{
    public static void AddGraphClient<T>(this IServiceCollection services)
        where T : GraphClient => services.AddScoped<T>();
}