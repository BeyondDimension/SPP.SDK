namespace Mobius.Models.Shop.Abstractions;

/// <summary>
/// 商城响应基类接口
/// </summary>
public interface IShopBaseResponse
{
    /// <summary>
    /// 状态
    /// </summary>
    bool Status { get; }

    /// <summary>
    /// 数据
    /// </summary>
    object? Data { get; }

    /// <summary>
    /// 消息
    /// </summary>
    string? Msg { get; }
}
