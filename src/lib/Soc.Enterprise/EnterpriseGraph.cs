using System.Net.Http.Json;
using Soc.Api.Graph;

namespace Soc.Enterprise;
public class EnterpriseGraph : GraphClient
{
    public EnterpriseGraph(GraphService graph)
        : base(graph, "Enterprise") { }

    public async Task<List<Organization>?> GetOrganizations(string? sort)
    {
        List<Organization>? orgs = await http.GetFromJsonAsync<List<Organization>>(
            $"{endpoint.Url}getOrganizations/${sort}"
        );
        
        return orgs;
    }
}