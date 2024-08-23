namespace Mobius.Models.Shop;

/// <summary>
/// 退款单模型
/// </summary>
public partial class CoreCmsBillRefundModel
{
    /// <summary>
    /// 退款单ID
    /// </summary>
    [JsonPropertyName("refundId")]
    public string RefundId { get; set; } = string.Empty;

    /// <summary>
    /// 售后单id
    /// </summary>
    [JsonPropertyName("aftersalesId")]
    public string AftersalesId { get; set; } = string.Empty;

    /// <summary>
    /// 退款金额
    /// </summary>
    [JsonPropertyName("money")]
    public decimal Money { get; set; }

    /// <summary>
    /// 用户ID 关联user.id
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 资源id，根据type不同而关联不同的表
    /// </summary>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; } = string.Empty;

    /// <summary>
    /// 资源类型1=订单,2充值单
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 退款支付类型编码 默认原路返回 关联支付单表支付编码
    /// </summary>
    [JsonPropertyName("paymentCode")]
    public string PaymentCode { get; set; } = string.Empty;

    /// <summary>
    /// 第三方平台交易流水号
    /// </summary>
    [JsonPropertyName("tradeNo")]
    public string TradeNo { get; set; } = string.Empty;

    /// <summary>
    /// 状态
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 退款失败原因
    /// </summary>
    [JsonPropertyName("memo")]
    public string Memo { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

public partial class CoreCmsBillRefundModel
{
    /// <summary>
    ///  支付代码描述
    /// </summary>
    [JsonPropertyName("paymentCodeName")]
    public string PaymentCodeName { get; set; } = string.Empty;

    /// <summary>
    ///  状态中文描述
    /// </summary>
    [JsonPropertyName("statusName")]
    public string StatusName { get; set; } = string.Empty;

    /// <summary>
    ///  用户昵称
    /// </summary>
    [JsonPropertyName("userNickName")]
    public string UserNickName { get; set; } = string.Empty;
}