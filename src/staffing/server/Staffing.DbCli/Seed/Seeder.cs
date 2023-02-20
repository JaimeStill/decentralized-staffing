using Microsoft.EntityFrameworkCore;
using Soc.Api.Schema;

namespace Staffing.DbCli.Seed;
public abstract class Seeder<E, C> where E : Base where C : DbContext
{
    protected readonly C db;

    public Seeder(C db)
    {
        this.db = db;
    }

    protected virtual Task<List<E>> Generate() =>
        Task.FromResult(new List<E>());

    public virtual async Task<List<E>> Seed()
    {
        if (await db.Set<E>().AnyAsync())
            return await db.Set<E>().ToListAsync();
        else
            return await Generate();
    }
}