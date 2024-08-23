namespace Mobius.Models.Shop;

/// <summary>
/// 促销表模型
/// </summary>
public class CoreCmsPromotionModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 促销名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 类型
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    /// <summary>
    /// 其它参数
    /// </summary>
    [JsonPropertyName("parameters")]
    public string Parameters { get; set; } = string.Empty;

    /// <summary>
    /// 每人限购数量
    /// </summary>
    [JsonPropertyName("maxNums")]
    public int MaxNums { get; set; }

    /// <summary>
    /// 每个商品活动数量
    /// </summary>
    [JsonPropertyName("maxGoodsNums")]
    public int MaxGoodsNums { get; set; }

    /// <summary>
    /// 最大领取数量
    /// </summary>
    [JsonPropertyName("maxReceiveNums")]
    public int MaxReceiveNums { get; set; }

    /// <summary>
    /// 开始时间
    /// </summary>
    [JsonPropertyName("startTime")]
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 结束时间
    /// </summary>
    [JsonPropertyName("endTime")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 是否排他
    /// </summary>
    [JsonPropertyName("isExclusive")]
    public bool IsExclusive { get; set; }

    /// <summary>
    /// 是否自动领取
    /// </summary>
    [JsonPropertyName("isAutoReceive")]
    public bool IsAutoReceive { get; set; }

    /// <summary>
    /// 是否开启
    /// </summary>
    [JsonPropertyName("isEnable")]
    public bool IsEnable { get; set; }

    /// <summary>
    /// 是否删除
    /// </summary>
    [JsonPropertyName("isDel")]
    public bool IsDel { get; set; }

    /// <summary>
    /// 有效天数
    /// </summary>
    [JsonPropertyName("effectiveDays")]
    public int EffectiveDays { get; set; }

    /// <summary>
    /// 有效小时
    /// </summary>
    [JsonPropertyName("effectiveHours")]
    public int EffectiveHours { get; set; }

    /// <summary>
    /// 口令
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; } = string.Empty;
}
