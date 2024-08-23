namespace Mobius.Models.Shop;

/// <summary>
/// 提货单模型
/// </summary>
public partial class CoreCmsBillLadingModel
{
    /// <summary>
    /// 提货单号
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// 提货门店ID
    /// </summary>
    [JsonPropertyName("storeId")]
    public int StoreId { get; set; }

    /// <summary>
    /// 提货人姓名
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 提货手机号
    /// </summary>
    [JsonPropertyName("mobile")]
    public string Mobile { get; set; } = string.Empty;

    /// <summary>
    /// 处理店员ID
    /// </summary>
    [JsonPropertyName("clerkId")]
    public int ClerkId { get; set; }

    /// <summary>
    /// 提货时间
    /// </summary>
    [JsonPropertyName("pickUpTime")]
    public DateTime? PickUpTime { get; set; }

    /// <summary>
    /// 是否提货
    /// </summary>
    [JsonPropertyName("status")]
    public bool Status { get; set; }

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

    /// <summary>
    /// 删除时间
    /// </summary>
    [JsonPropertyName("isDel")]
    public bool IsDel { get; set; }
}

public partial class CoreCmsBillLadingModel
{
    /// <summary>
    /// 关联门店名称
    /// </summary>
    [JsonPropertyName("storeName")]
    public string StoreName { get; set; } = string.Empty;

    /// <summary>
    /// 状态中文描述
    /// </summary>
    [JsonPropertyName("statusName")]
    public string StatusName { get; set; } = string.Empty;

    /// <summary>
    /// 店员昵称
    /// </summary>
    [JsonPropertyName("clerkIdName")]
    public string ClerkIdName { get; set; } = string.Empty;

    /// <summary>
    /// 关联订单项目
    /// </summary>
    [JsonPropertyName("orderItems")]
    public List<CoreCmsOrderItemModel>? OrderItems { get; set; }
}