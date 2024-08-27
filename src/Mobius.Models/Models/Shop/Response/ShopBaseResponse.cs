namespace Mobius.Models.Shop.Response;

/// <summary>
/// 商城响应模型类
/// </summary>
/// <typeparam name="TData"></typeparam>
public class ShopBaseResponse<TData> : IShopBaseResponse
{
    /// <inheritdoc/>
    public bool Status { get; set; }

    /// <inheritdoc cref="IShopBaseResponse.Data"/>
    public TData? Data { get; set; }

    /// <inheritdoc/>
    public string? Msg { get; set; }

    /// <inheritdoc/>
    object? IShopBaseResponse.Data => Data;
}

public class ShopBaseResponse<TData, TOtherData> : ShopBaseResponse<TData>
{
    public TOtherData? OtherData { get; set; }
}