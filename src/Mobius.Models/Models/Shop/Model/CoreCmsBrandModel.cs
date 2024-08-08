namespace Mobius.Models.Shop;

/// <summary>
/// 品牌表
/// </summary>
public partial class CoreCmsBrandModel
{
    /// <summary>
    /// 品牌ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 品牌名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 品牌LOGO
    /// </summary>
    [JsonPropertyName("logoImageUrl")]
    public string LogoImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// 品牌排序
    /// </summary>
    [JsonPropertyName("sort")]
    public int? Sort { get; set; }

    /// <summary>
    /// 是否显示
    /// </summary>
    [JsonPropertyName("isShow")]
    public bool IsShow { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }
}
