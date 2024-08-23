namespace Mobius.Models.Shop;

public partial class WeChatTransactionComponentOrderModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 交易组件订单ID
    /// </summary>
    [JsonPropertyName("orderId")]
    public long? OrderId { get; set; }

    /// <summary>
    /// 商家自定义订单ID
    /// </summary>
    [JsonPropertyName("outOrderId")]
    public string OutOrderId { get; set; } = string.Empty;

    /// <summary>
    /// 用户openId
    /// </summary>
    [JsonPropertyName("openid")]
    public string OpenId { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 支付单序列
    /// </summary>
    [JsonPropertyName("paymentId")]
    public string PaymentId { get; set; } = string.Empty;
}
