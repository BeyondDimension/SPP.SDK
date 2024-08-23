namespace Mobius.Models.Shop.Request;

/// <summary>
/// 获取订单不同状态的数量提交参数
/// </summary>
public class OrderStatusNumPostRequest
{
    /// <summary>
    /// 类型集合
    /// </summary>
    [SystemTextJsonProperty("ids")]
    public string Ids { get; set; } = string.Empty;

    /// <summary>
    /// 是否进行售后
    /// </summary>
    [SystemTextJsonProperty("isAfterSale")]
    public bool IsAfterSale { get; set; }
}