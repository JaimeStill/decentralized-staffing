using System.Reflection;

namespace Soc.Api.Extensions;
public static class ReflectionExtensions
{
    public static async Task<object?> InvokeAsync(this MethodInfo @this, object obj, params object[] parameters)
    {
        dynamic? awaitable = @this.Invoke(obj, parameters);
        await awaitable;

        return awaitable
            ?.GetAwaiter()
            .GetResult();
    }
}