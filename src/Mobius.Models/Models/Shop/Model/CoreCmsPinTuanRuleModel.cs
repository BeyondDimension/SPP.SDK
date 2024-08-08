namespace Mobius.Models.Shop;

/// <summary>
/// 拼团规则表
/// </summary>
public partial class CoreCmsPinTuanRuleModel
{
    /// <summary>
    /// 构造函数
    /// </summary>
    public CoreCmsPinTuanRuleModel()
    {
    }

    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 活动名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

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
    /// 人数2-10人
    /// </summary>
    [JsonPropertyName("peopleNumber")]
    public int PeopleNumber { get; set; }

    /// <summary>
    /// 单位分钟
    /// </summary>
    [JsonPropertyName("significantInterval")]
    public int SignificantInterval { get; set; }

    /// <summary>
    /// 优惠金额
    /// </summary>
    [JsonPropertyName("discountAmount")]
    public decimal DiscountAmount { get; set; }

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
    /// 排序
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    /// <summary>
    /// 是否开启
    /// </summary>
    [JsonPropertyName("isStatusOpen")]
    public bool IsStatusOpen { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

/// <summary>
///     拼团规则表
/// </summary>
public partial class CoreCmsPinTuanRule
{
    /// <summary>
    ///     商品编码
    /// </summary>
    [JsonPropertyName("goods")]
    public int[]? Goods { get; set; }

    /// <summary>
    ///     判断拼团状态
    /// </summary>
    [JsonPropertyName("pinTuanStartStatus")]
    public int PinTuanStartStatus { get; set; } = 0;

    /// <summary>
    ///     剩余时间
    /// </summary>
    [JsonPropertyName("lastTime")]
    public int LastTime { get; set; }
}