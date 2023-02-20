using Enterprise.Data;
using Enterprise.Models.Entities;
using Soc.Api.Services;

namespace Enterprise.Services;
public class OrganizationService : EntityService<Organization, AppDbContext>
{
    public OrganizationService(AppDbContext db) : base (db) { }

    public static object GenerateException(string message = "An exception occurred") =>
        throw new Exception(message);
}