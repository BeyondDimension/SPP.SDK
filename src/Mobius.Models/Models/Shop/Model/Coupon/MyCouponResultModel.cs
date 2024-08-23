namespace Mobius.Models.Shop;

public class MyCouponResultModel
{
    /// <summary>
    ///     优惠券编码
    /// </summary>
    [JsonPropertyName("couponCode")]
    public string CouponCode { get; set; } = string.Empty;

    /// <summary>
    ///     优惠券名称
    /// </summary>
    [JsonPropertyName("couponName")]
    public string CouponName { get; set; } = string.Empty;

    /// <summary>
    ///     优惠券id
    /// </summary>
    [JsonPropertyName("promotionId")]
    public int PromotionId { get; set; }

    /// <summary>
    ///     是否使用
    /// </summary>
    [JsonPropertyName("isUsed")]
    public bool IsUsed { get; set; }

    /// <summary>
    ///     谁领取了
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    ///     被谁用了
    /// </summary>
    [JsonPropertyName("usedId")]
    public string UsedId { get; set; } = string.Empty;

    /// <summary>
    ///     创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    ///     更新时间
    /// </summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    ///     条件
    /// </summary>
    [JsonPropertyName("expression1")]
    public string Expression1 { get; set; } = string.Empty;

    /// <summary>
    ///     结果
    /// </summary>
    [JsonPropertyName("expression2")]
    public string Expression2 { get; set; } = string.Empty;

    /// <summary>
    ///     是否结束
    /// </summary>
    [JsonPropertyName("isExpire")]
    public bool IsExpire { get; set; }

    /// <summary>
    ///     开始时间
    /// </summary>
    [JsonPropertyName("startTime")]
    public DateTime StartTime { get; set; }

    /// <summary>
    ///     结束时间
    /// </summary>
    [JsonPropertyName("endTime")]
    public DateTime EndTime { get; set; }

    /// <summary>
    ///     开始时间缩写
    /// </summary>
    [JsonPropertyName("stime")]
    public string Stime { get; set; } = string.Empty;

    /// <summary>
    ///     结束时间缩写
    /// </summary>
    [JsonPropertyName("etime")]
    public string Etime { get; set; } = string.Empty;

    /// <summary>
    ///     条件集合
    /// </summary>
    [JsonPropertyName("conditions")]
    public List<string> Conditions { get; set; } = new();

    /// <summary>
    ///     结果集合
    /// </summary>
    [JsonPropertyName("results")]
    public List<string> Results { get; set; } = new();

    /// <summary>
    ///     原始数据条件集合
    /// </summary>
    [JsonPropertyName("promotionCondition")]
    public List<CoreCmsPromotionConditionModel> PromotionCondition { get; set; } = new();

    /// <summary>
    ///     原始数据结果集合
    /// </summary>
    [JsonPropertyName("promotionResult")]
    public List<CoreCmsPromotionResultModel> PromotionResult { get; set; } = new();
}
