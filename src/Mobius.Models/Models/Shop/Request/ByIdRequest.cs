namespace Mobius.Models.Shop.Request;

public class FMIdRequest<T>
{
    [SystemTextJsonProperty("id")]
    public T? Id { get; set; }
}

public class FMIdDataRequest<TId, TData>
{
    [SystemTextJsonProperty("id")]
    public TId? Id { get; set; }

    [SystemTextJsonProperty("data")]
    public TData? Data { get; set; }
}