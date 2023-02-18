using Microsoft.EntityFrameworkCore;
using Soc.Api.Core;
using Soc.Api.Extensions;
using Soc.Api.Query;
using Soc.Api.Schema;

namespace Soc.Api.Services;

public abstract class EntityService<T, Db> : BaseService<T, Db>
    where T : Entity
    where Db : DbContext
{
    public EntityService(Db db) : base(db) { }

    #region Internal

    protected virtual Func<IQueryable<T>, string, IQueryable<T>> Search =>
        (values, term) =>
            values.Where(x =>
                x.Name.ToLower().Contains(term.ToLower())
            );

    protected virtual async Task<QueryResult<E>> Query<E>(
        IQueryable<E> queryable,
        QueryParams queryParams,
        Func<IQueryable<E>, string, IQueryable<E>> search        
    ) where E : Entity
    {
        var container = new QueryContainer<E>(
            queryable, queryParams
        );

        return await container.Query((data, s) => 
            data.SetupSearch(s, search)
        );
    }

    #endregion

    #region Public

    public virtual async Task<QueryResult<T>> Query(QueryParams queryParams) =>
        await Query(
            query, queryParams, Search
        );

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

    #endregion
}