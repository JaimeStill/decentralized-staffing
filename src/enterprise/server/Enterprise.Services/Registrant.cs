using Microsoft.Extensions.DependencyInjection;
using Soc.Api.Services;

namespace Enterprise.Services;
public class Registrant : ServiceRegistrant
{
    public Registrant(IServiceCollection services) : base(services) { }

    public override void Register()
    {
        services.AddScoped<OrganizationService>();
        services.AddScoped<UserService>();
    }
}