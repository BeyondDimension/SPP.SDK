namespace Mobius.Models.Shop;

/// <summary>
///  支付确认页面返回实体
/// </summary>
public class CheckPayModel
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; } = 0;

    [JsonPropertyName("money")]
    public decimal Money { get; set; } = 0;

    [JsonPropertyName("rel")]
    public List<Rel> Rel { get; set; } = new();
}

public class Rel
{
    /// <summary>
    /// 关联资源序列
    /// </summary>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; } = string.Empty;

    /// <summary>
    /// 金额
    /// </summary>
    [JsonPropertyName("money")]
    public decimal Money { get; set; }
}