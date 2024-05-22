namespace Mobius.Models.Shop.Response;

/// <summary>
/// 商城响应模型类
/// </summary>
/// <typeparam name="T"></typeparam>
public sealed class ShopBaseResponse<T> : IShopBaseResponse
{
    /// <inheritdoc/>
    public bool Status { get; set; }

    /// <inheritdoc cref="IShopBaseResponse.Data"/>
    public T? Data { get; set; }

    /// <inheritdoc/>
    public string? Msg { get; set; }

    /// <inheritdoc/>
    object? IShopBaseResponse.Data => Data;
}
