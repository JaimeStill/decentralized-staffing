using Microsoft.EntityFrameworkCore;
using Soc.Api.Core;
using Soc.Api.Query;
using Soc.Api.Schema;

namespace Soc.Api.Services;

public abstract class BaseService<T, Db> : IService<T, Db>
    where T : Base
    where Db : DbContext
{
    protected Db db;
    protected IQueryable<T> query;

    protected virtual Func<T, Task<T>>? OnAdd { get; set; }
    protected virtual Func<T, Task<T>>? OnUpdate { get; set; }
    protected virtual Func<T, Task<T>>? OnSave { get; set; }
    protected virtual Func<T, Task<T>>? OnRemove { get; set; }

    public BaseService(Db db)
    {
        this.db = db;
        query = SetGraph(db.Set<T>());
    }

    #region Internal

    protected virtual IQueryable<T> SetGraph(DbSet<T> data) =>
        data;

    protected async Task<ApiResult<T>> Add(T entity)
    {
        try
        {
            if (OnAdd is not null)
                entity = await OnAdd(entity);

            await db.Set<T>().AddAsync(entity);
            await db.SaveChangesAsync();

            return new(entity, $"{typeof(T)} successfully added");
        }
        catch (Exception ex)
        {
            return new("Add", ex);
        }
    }

    protected async Task<ApiResult<T>> Update(T entity)
    {
        try
        {
            if (OnUpdate is not null)
                entity = await OnUpdate(entity);

            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();

            return new(entity, $"{typeof(T)} successfully updated");
        }
        catch (Exception ex)
        {
            return new("Update", ex);
        }
    }

    #endregion

    #region Public

    public virtual async Task<List<E>> Get<E>(
        IQueryable<E> queryable,
        string sort = "Id"
    ) where E : Base =>
        await queryable
            .ApplySorting(new QueryOptions { Sort = sort })
            .ToListAsync();

    public virtual async Task<T?> GetById(int id) =>
        await query.FirstOrDefaultAsync(x => x.Id == id);

    public virtual Task<ValidationResult> Validate(T entity) =>
        Task.FromResult(new ValidationResult());

    public async Task<ApiResult<T>> Save(T entity)
    {
        ValidationResult validity = await Validate(entity);

        if (validity.IsValid)
        {
            if (OnSave is not null)
                entity = await OnSave(entity);
                
            return entity.Id > 0
                ? await Update(entity)
                : await Add(entity);
        }
        else
            return new(validity);
    }

    public async Task<ApiResult<int>> Remove(T entity)
    {
        try
        {
            if (OnRemove is not null)
                entity = await OnRemove(entity);

            db.Set<T>().Remove(entity);

            int result = await db.SaveChangesAsync();

            return result > 0
                ? new(entity.Id, $"{typeof(T)} successfully removed")
                : new("Remove", new Exception("The operation was not successful"));
        }
        catch (Exception ex)
        {
            return new("Remove", ex);
        }
    }

    #endregion
}