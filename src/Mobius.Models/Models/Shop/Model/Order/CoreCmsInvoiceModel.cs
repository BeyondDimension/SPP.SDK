namespace Mobius.Models.Shop;

/// <summary>
/// 发票模型
/// </summary>
public partial class CoreCmsInvoiceModel
{
    /// <summary>
    /// 序列
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 开票类型
    /// </summary>
    [JsonPropertyName("category")]
    public int Category { get; set; }

    /// <summary>
    /// 资源ID
    /// </summary>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; } = string.Empty;

    /// <summary>
    /// 所属用户ID
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 发票类型
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 发票抬头
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// 发票税号
    /// </summary>
    [JsonPropertyName("taxNumber")]
    public string TaxNumber { get; set; } = string.Empty;

    /// <summary>
    /// 发票金额
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    /// <summary>
    /// 开票状态
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 开票备注
    /// </summary>
    [JsonPropertyName("remarks")]
    public string Remarks { get; set; } = string.Empty;

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
    /// 发票下载地址
    /// </summary>
    [JsonPropertyName("fileUrl")]
    public string FileUrl { get; set; } = string.Empty;
}

public partial class CoreCmsInvoiceModel
{
    /// <summary>
    ///  分类名称
    /// </summary>
    [JsonPropertyName("categoryName")]
    public string CategoryName { get; set; } = string.Empty;

    /// <summary>
    ///  类型名称
    /// </summary>
    [JsonPropertyName("typeName")]
    public string TypeName { get; set; } = string.Empty;

    /// <summary>
    ///  状态名称
    /// </summary>
    [JsonPropertyName("statusName")]
    public string StatusName { get; set; } = string.Empty;

    /// <summary>
    ///  用户昵称
    /// </summary>
    [JsonPropertyName("userNickName")]
    public string UserNickName { get; set; } = string.Empty;
}