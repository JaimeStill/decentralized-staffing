using Enterprise.Models.Entities;
using Enterprise.Models.Query;
using Enterprise.Models.Validation;

namespace Enterprise.Services;
public interface IService<T> where T : Entity
{
    Task<QueryResult<T>> Query(QueryParams queryParams);
    Task<T> GetById(int id);
    Task<T> GetByUrl(string url);
    Task<bool> ValidateName(T entity);
    Task<ValidationResult> Validate(T entity);
    Task<T> Save(T entity);
    Task<int> Remove(T entity);
}