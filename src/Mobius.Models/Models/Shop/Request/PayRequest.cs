namespace Mobius.Models.Shop.Request;

public class PayRequest
{
    /// <summary>
    ///  订单号
    /// </summary>
    [JsonPropertyName("Ids")]
    public string Ids { get; set; } = string.Empty;

    /// <summary>
    ///  支付方式
    /// </summary>
    [JsonPropertyName("payment_code")]
    public string PaymentCode { get; set; } = string.Empty;

    /// <summary>
    ///  订单类型 1商品订单 2充值订单 5服务订单
    /// </summary>
    [JsonPropertyName("Payment_type")]
    public int PaymentType { get; set; } = 0;

    /// <summary>
    ///  附加参数
    /// </summary>
    [JsonPropertyName("params")]
    public JObject? Params { get; set; }
}