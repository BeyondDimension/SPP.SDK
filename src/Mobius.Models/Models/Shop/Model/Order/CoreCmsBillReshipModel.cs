namespace Mobius.Models.Shop;

/// <summary>
/// 退货单模型
/// </summary>
public partial class CoreCmsBillReshipModel
{
    /// <summary>
    /// 退货单号
    /// </summary>
    [JsonPropertyName("reshipId")]
    public string ReshipId { get; set; } = string.Empty;

    /// <summary>
    /// 订单序列
    /// </summary>
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// 售后单序列
    /// </summary>
    [JsonPropertyName("aftersalesId")]
    public string AftersalesId { get; set; } = string.Empty;

    /// <summary>
    /// 用户ID 关联user.id
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 物流公司编码
    /// </summary>
    [JsonPropertyName("logiCode")]
    public string LogiCode { get; set; } = string.Empty;

    /// <summary>
    /// 物流单号
    /// </summary>
    [JsonPropertyName("logiNo")]
    public string LogiNo { get; set; } = string.Empty;

    /// <summary>
    /// 状态
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 备注
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

public partial class CoreCmsBillReshipModel
{
    /// <summary>
    /// 物流名称
    /// </summary>
    [JsonPropertyName("logiName")]
    public string LogiName { get; set; } = string.Empty;

    /// <summary>
    /// 状态中文描述
    /// </summary>
    [JsonPropertyName("statusName")]
    public string StatusName { get; set; } = string.Empty;

    /// <summary>
    /// 退货明细
    /// </summary>
    [JsonPropertyName("items")]
    public List<CoreCmsBillReshipItemModel>? Items { get; set; }

    /// <summary>
    /// 用户昵称
    /// </summary>
    [JsonPropertyName("userNickName")]
    public string UserNickName { get; set; } = string.Empty;
}