using Microsoft.EntityFrameworkCore;
using Soc.Api.Schema;

namespace Soc.Api.Services;

public abstract class KeyEntityService<T, Db> : UrlEntityService<T, Db>
    where T : KeyEntity
    where Db : DbContext
{
    public KeyEntityService(Db db) : base(db) { }

    public async Task<T> GetByKey(Guid key) =>
        await query.FirstOrDefaultAsync(x => x.Key == key);

    protected override Func<T, Task<T>> OnAdd => async (T entity) =>
    {
        entity.Key = await GenerateKey();

        return entity;
    };

    protected async Task<Guid> GenerateKey()
    {
        Guid key = Guid.NewGuid();

        while(await KeyExists(key))
            key = Guid.NewGuid();

        return key;
    }

    protected async Task<bool> KeyExists(Guid key) =>
        await db.Set<T>().AnyAsync(x => x.Key == key);
}