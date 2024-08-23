namespace Mobius.Models.Shop.Request;

/// <summary>
/// 获取订单列表提交参数
/// </summary>
public class OrderListPostRequest
{
    /// <summary>
    /// 每页数量
    /// </summary>
    [SystemTextJsonProperty("limit")]
    public int Limit { get; set; } = 5;

    /// <summary>
    /// 页码
    /// </summary>
    [SystemTextJsonProperty("page")]
    public int Page { get; set; } = 1;

    /// <summary>
    /// 状态
    /// </summary>
    [SystemTextJsonProperty("status")]
    public int Status { get; set; } = 0;
}