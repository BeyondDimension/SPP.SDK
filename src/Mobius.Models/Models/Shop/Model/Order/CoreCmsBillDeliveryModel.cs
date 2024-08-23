namespace Mobius.Models.Shop;

/// <summary>
/// 发货单模型
/// </summary>
public partial class CoreCmsBillDeliveryModel
{
    /// <summary>
    /// 发货单序列
    /// </summary>
    [JsonPropertyName("deliveryId")]
    public string DeliveryId { get; set; } = string.Empty;

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; } = string.Empty;

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
    /// 第三方对接物流编码
    /// </summary>
    [JsonPropertyName("thirdPartyLogiCode")]
    public string ThirdPartyLogiCode { get; set; } = string.Empty;

    /// <summary>
    /// 快递物流信息
    /// </summary>
    [JsonPropertyName("logiInformation")]
    public string LogiInformation { get; set; } = string.Empty;

    /// <summary>
    /// 快递是否不更新
    /// </summary>
    [JsonPropertyName("logiStatus")]
    public bool LogiStatus { get; set; }

    /// <summary>
    /// 收货地区ID
    /// </summary>
    [JsonPropertyName("shipAreaId")]
    public int ShipAreaId { get; set; }

    /// <summary>
    /// 收货详细地址
    /// </summary>
    [JsonPropertyName("shipAddress")]
    public string ShipAddress { get; set; } = string.Empty;

    /// <summary>
    /// 收货人姓名
    /// </summary>
    [JsonPropertyName("shipName")]
    public string ShipName { get; set; } = string.Empty;

    /// <summary>
    /// 收货电话
    /// </summary>
    [JsonPropertyName("shipMobile")]
    public string ShipMobile { get; set; } = string.Empty;

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
    /// 确认收货时间
    /// </summary>
    [JsonPropertyName("confirmTime")]
    public DateTime? ConfirmTime { get; set; }

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

public partial class CoreCmsBillDeliveryModel
{
    /// <summary>
    /// 物流名称
    /// </summary>
    [JsonPropertyName("logiName")]
    public string LogiName { get; set; } = string.Empty;

    /// <summary>
    /// 所属区域**全名
    /// </summary>
    [JsonPropertyName("shipAreaIdName")]
    public string ShipAreaIdName { get; set; } = string.Empty;
}