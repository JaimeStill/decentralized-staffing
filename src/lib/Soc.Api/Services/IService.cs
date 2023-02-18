using Microsoft.EntityFrameworkCore;
using Soc.Api.Core;
using Soc.Api.Schema;

namespace Soc.Api.Services;

public interface IService<T, Db>
    where T : Base
    where Db : DbContext
{
    Task<T> GetById(int id);
    Task<ValidationResult> Validate(T entity);
    Task<ApiResult<T>> Save(T entity);
    Task<ApiResult<int>> Remove(T entity);    
}