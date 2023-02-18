namespace MethodHooks;

public class Service<T>
{
    protected virtual Func<T, Task<T>> OnAction { get; set; }

    public async Task<T> ExecuteAction(T data)
    {
        if (OnAction is not null)
            await OnAction(data);

        Console.WriteLine($"Action executed on {data}");
            
        return data;
    }
}

public class SquareService : Service<int>
{
    protected override Func<int, Task<int>> OnAction => (int value) =>
    {
        value *= value;

        return Task.FromResult(value);
    };
}

public class StringService : Service<string> { }