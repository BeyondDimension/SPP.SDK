namespace Mobius.Models.Shop.Abstractions;

/// <summary>
/// 商城请求基类接口
/// </summary>
public interface IShopBaseRequest
{
    /// <summary>
    /// Int32 Id
    /// </summary>
    int Id { get; }

    /// <summary>
    /// 数据
    /// </summary>
    object? Data { get; }
}
