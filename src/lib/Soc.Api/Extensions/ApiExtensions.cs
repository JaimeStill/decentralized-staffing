namespace Soc.Api.Extensions;

public static class ApiExtensions
{
    public static IQueryable<T> SetupSearch<T>(
        this IQueryable<T> values,
        string search,
        Func<IQueryable<T>, string, IQueryable<T>> action,
        char split = '|'
    )
    {
        if (search.Contains(split))
        {
            string[] searches = search.Split(split);

            foreach (string s in searches)
                values = action(values, s.Trim());

            return values;
        }
            return action(values, search);
    }
}