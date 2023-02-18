using Microsoft.EntityFrameworkCore;
using Soc.Api.Core;
using Soc.Api.Schema;

namespace Soc.Api.Services;

public abstract class UrlEntityService<T, Db> : EntityService<T, Db>
    where T : UrlEntity
    where Db : DbContext
{
    public UrlEntityService(Db db) : base(db) { }

    public virtual async Task<T> GetByUrl(string url) =>
        await query.FirstOrDefaultAsync(x => x.Url.ToLower() == url.ToLower());
}