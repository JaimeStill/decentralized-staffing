using Microsoft.EntityFrameworkCore;
using Soc.Api.Core;
using Soc.Api.Schema;

namespace Soc.Api.Services;

public abstract class EntityService<T, Db> : BaseService<T, Db>
    where T : Entity
    where Db : DbContext
{
    public EntityService(Db db) : base(db) { }

    // !!!Build out Query infrastructure!!!!

    public virtual async Task<bool> ValidateName(T entity) =>
        !await db.Set<T>()
            .AnyAsync(x =>
                x.Id != entity.Id
                && x.Name.ToLower() == entity.Name.ToLower()
            );

    public override async Task<ValidationResult> Validate(T entity)
    {
        ValidationResult result = new();

        if (string.IsNullOrWhiteSpace(entity.Name))
            result.AddMessage("Name is required");

        if (!await ValidateName(entity))
            result.AddMessage("Name is already in use");

        return result;
    }
}