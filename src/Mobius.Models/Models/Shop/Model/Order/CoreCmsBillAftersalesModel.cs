namespace Mobius.Models.Shop;

public partial class CoreCmsBillAftersalesModel
{
    /// <summary>
    /// 售后单Id
    /// </summary>
    [JsonPropertyName("aftersalesId")]
    public string AftersalesId { get; set; } = string.Empty;

    /// <summary>
    /// 订单Id
    /// </summary>
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// 用户Id
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 售后类型
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 退款金额
    /// </summary>
    [JsonPropertyName("refundAmount")]
    public decimal RefundAmount { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 退款原因
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = string.Empty;

    /// <summary>
    /// 卖家备注，如果审核失败了，会显示到前端
    /// </summary>
    [JsonPropertyName("mark")]
    public string Mark { get; set; } = string.Empty;

    /// <summary>
    /// 提交时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

public partial class CoreCmsBillAftersalesModel
{
    /// <summary>
    /// 商品子集
    /// </summary>
    [JsonPropertyName("items")]
    public List<CoreCmsBillAftersalesItemModel> Items { get; set; } = new();

    /// <summary>
    /// 图片子集
    /// </summary>
    [JsonPropertyName("images")]
    public List<CoreCmsBillAftersalesImagesModel> Images { get; set; } = new();

    /// <summary>
    /// 退款单
    /// </summary>
    [JsonPropertyName("billRefund")]
    public CoreCmsBillRefundModel? BillRefund { get; set; }

    /// <summary>
    /// 退货单
    /// </summary>
    [JsonPropertyName("billReship")]
    public CoreCmsBillReshipModel? BillReship { get; set; }

    /// <summary>
    /// 状态说明
    /// </summary>
    [JsonPropertyName("statusName")]
    public string StatusName { get; set; } = string.Empty;

    /// <summary>
    /// 用户昵称
    /// </summary>
    [JsonPropertyName("userNickName")]
    public string UserNickName { get; set; } = string.Empty;

    /// <summary>
    /// 关联订单数据
    /// </summary>
    [JsonPropertyName("order")]
    public CoreCmsOrderModel? Order { get; set; }
}