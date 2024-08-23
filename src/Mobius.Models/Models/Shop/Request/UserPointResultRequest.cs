namespace Mobius.Models.Shop.Request;

/// <summary>
///  获取用户积分提交
/// </summary>
public class UserPointResultRequest
{
    /// <summary>
    /// 订单金额
    /// </summary>
    [SystemTextJsonProperty("orderMoney")]
    public decimal OrderMoney { get; set; }

    /// <summary>
    /// 购物车序列号
    /// </summary>
    [SystemTextJsonProperty("ids")]
    public string Ids { get; set; } = string.Empty;

    /// <summary>
    /// 购物车类型
    /// </summary>
    [SystemTextJsonProperty("cartType")]
    public int CartType { get; set; }
}
