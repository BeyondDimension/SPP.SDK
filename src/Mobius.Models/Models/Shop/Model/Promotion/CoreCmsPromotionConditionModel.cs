namespace Mobius.Models.Shop;

/// <summary>
/// 促销条件表
/// </summary>
public class CoreCmsPromotionConditionModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 促销ID
    /// </summary>
    [JsonPropertyName("promotionId")]
    public int PromotionId { get; set; }

    /// <summary>
    /// 促销条件编码
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// 支付配置参数序列号存储
    /// </summary>
    [JsonPropertyName("parameters")]
    public string Parameters { get; set; } = string.Empty;
}
