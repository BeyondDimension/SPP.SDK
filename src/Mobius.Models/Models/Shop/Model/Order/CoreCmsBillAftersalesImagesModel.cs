namespace Mobius.Models.Shop;

/// <summary>
/// 商品图片关联模型
/// </summary>
public class CoreCmsBillAftersalesImagesModel
{
    /// <summary>
    /// 售后单id
    /// </summary>
    [JsonPropertyName("aftersalesId")]
    public string AftersalesId { get; set; } = string.Empty;

    /// <summary>
    /// 图片地址
    /// </summary>
    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// 排序
    /// </summary>
    [JsonPropertyName("sortId")]
    public int SortId { get; set; }
}
