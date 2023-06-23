namespace BlazCommerce.Client.Services;

public record Response<T>(bool Success, T? Data, string? ErrorMessage);

public record Response(bool Success, string? ErrorMessage)
{
    public static Response<TData> Ok<TData>(TData data) => new(true, data, null);

    public static Response<TData> Fail<TData>(string errorMessage) => new(false, default, errorMessage);

    public static Response Ok() => new(true, null);

    public static Response Fail(string errorMessage) => new(false, errorMessage);
}
