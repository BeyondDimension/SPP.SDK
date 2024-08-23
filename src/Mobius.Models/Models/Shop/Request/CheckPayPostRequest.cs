namespace Mobius.Models.Shop.Request;

/// <summary>
/// 支付确认页面取信息提交参数集合
/// </summary>
public class CheckPayPostRequest
{
    /// <summary>
    /// 订单号集合
    /// </summary>
    [SystemTextJsonProperty("ids")]
    public string Ids { get; set; } = string.Empty;

    /// <summary>
    /// 支付的时候，有一些特殊的参数需要传递到支付里面，这里就是干这个事情的,key=>value格式的一维数组
    /// </summary>
    [SystemTextJsonProperty("params")]
    public JObject? Params { get; set; }

    /// <summary>
    /// 付款方式
    /// </summary>
    [SystemTextJsonProperty("paymentType")]
    public int PaymentType { get; set; }
}
