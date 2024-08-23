namespace Mobius.Models.Shop;

/// <summary>
/// 支付单模型
/// </summary>
public partial class CoreCmsBillPaymentsModel
{
    /// <summary>
    /// 支付单号
    /// </summary>
    [JsonPropertyName("paymentId")]
    public string PaymentId { get; set; } = string.Empty;

    /// <summary>
    /// 资源编号
    /// </summary>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; } = string.Empty;

    /// <summary>
    /// 支付金额
    /// </summary>
    [JsonPropertyName("money")]
    public decimal Money { get; set; }

    /// <summary>
    /// 用户ID 关联user.id
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 单据类型
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 支付状态
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 支付类型编码 关联payments.code
    /// </summary>
    [JsonPropertyName("paymentCode")]
    public string PaymentCode { get; set; } = string.Empty;

    /// <summary>
    /// 支付单生成IP
    /// </summary>
    [JsonPropertyName("ip")]
    public string IP { get; set; } = string.Empty;

    /// <summary>
    /// 支付的时候需要的参数，存的是json格式的一维数组
    /// </summary>
    [JsonPropertyName("parameters")]
    public string Parameters { get; set; } = string.Empty;

    /// <summary>
    /// 支付回调后的状态描述
    /// </summary>
    [JsonPropertyName("payedMsg")]
    public string PayedMsg { get; set; } = string.Empty;

    /// <summary>
    /// 第三方平台交易流水号
    /// </summary>
    [JsonPropertyName("tradeNo")]
    public string TradeNo { get; set; } = string.Empty;

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

public partial class CoreCmsBillPaymentsModel
{
    /// <summary>
    /// 支付代码描述
    /// </summary>
    [JsonPropertyName("paymentCodeName")]
    public string PaymentCodeName { get; set; } = string.Empty;

    /// <summary>
    /// 状态中文描述
    /// </summary>
    [JsonPropertyName("statusName")]
    public string StatusName { get; set; } = string.Empty;

    /// <summary>
    /// 支付标题
    /// </summary>
    [JsonPropertyName("payTitle")]
    public string PayTitle { get; set; } = string.Empty;

    /// <summary>
    /// 用户昵称
    /// </summary>
    [JsonPropertyName("userNickName")]
    public string UserNickName { get; set; } = string.Empty;
}