namespace Mobius.Models.Shop.Request;

/// <summary>
/// 商城请求模型类（泛型）
/// </summary>
/// <typeparam name="T"></typeparam>
public sealed class ShopBaseRequest<T> : IShopBaseRequest where T : class
{
    /// <inheritdoc/>
    public int Id { get; set; }

    /// <inheritdoc cref="IShopBaseRequest.Data"/>
    public T? Data { get; set; }

    /// <inheritdoc/>
    object? IShopBaseRequest.Data => Data;
}

/// <summary>
/// 商城请求模型类
/// </summary>
public sealed class ShopBaseRequest : IShopBaseRequest
{
    /// <inheritdoc/>
    public int Id { get; set; }

    /// <inheritdoc/>
    public object? Data { get; set; }
}
