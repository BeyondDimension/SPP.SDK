namespace Mobius.Models.Shop;

/// <summary>
/// 标签表
/// </summary>
public partial class CoreCmsLabelModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 标签名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 标签样式
    /// </summary>
    [JsonPropertyName("style")]
    public string Style { get; set; } = string.Empty;
}