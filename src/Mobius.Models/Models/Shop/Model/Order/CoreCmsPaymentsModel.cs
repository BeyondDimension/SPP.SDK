namespace Mobius.Models.Shop;

public partial class CoreCmsPaymentsModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 支付类型名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 支付类型编码
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// 是否线上支付
    /// </summary>
    [JsonPropertyName("isOnline")]
    public bool IsOnline { get; set; }

    /// <summary>
    /// 参数
    /// </summary>
    [JsonPropertyName("parameters")]
    public string Parameters { get; set; } = string.Empty;

    /// <summary>
    /// 排序
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    /// <summary>
    /// 方式描述
    /// </summary>
    [JsonPropertyName("memo")]
    public string Memo { get; set; } = string.Empty;

    /// <summary>
    /// 是否启用
    /// </summary>
    [JsonPropertyName("isEnable")]
    public bool IsEnable { get; set; }
}
