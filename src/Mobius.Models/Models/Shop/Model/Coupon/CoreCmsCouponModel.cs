namespace Mobius.Models.Shop;

/// <summary>
///  优惠券模型
/// </summary>
public partial class CoreCmsCouponModel
{
    /// <summary>
    /// 序列
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 优惠券编码
    /// </summary>
    [JsonPropertyName("couponCode")]
    public string CouponCode { get; set; } = string.Empty;

    /// <summary>
    /// 优惠券id
    /// </summary>
    [JsonPropertyName("promotionId")]
    public int PromotionId { get; set; }

    /// <summary>
    /// 是否使用
    /// </summary>
    [JsonPropertyName("isUsed")]
    public bool IsUsed { get; set; }

    /// <summary>
    /// 谁领取了
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 被谁用了
    /// </summary>
    [JsonPropertyName("usedId")]
    public string UsedId { get; set; } = string.Empty;

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
    /// 说明
    /// </summary>
    [JsonPropertyName("remark")]
    public string Remark { get; set; } = string.Empty;

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
}

public partial class CoreCmsCouponModel
{
    /// <summary>
    /// 优惠券名称
    /// </summary>
    [JsonPropertyName("couponName")]
    public string CouponName { get; set; } = string.Empty;

    /// <summary>
    /// 领取用户姓名
    /// </summary>
    [JsonPropertyName("userNickName")]
    public string UserNickName { get; set; } = string.Empty;

    /// <summary>
    /// 关联优惠内容
    /// </summary>
    [JsonPropertyName("promotion")]
    public CoreCmsPromotionModel? Promotion { get; set; }

    /// <summary>
    /// 满足明细
    /// </summary>
    [JsonPropertyName("conditions")]
    public List<CoreCmsPromotionConditionModel>? Conditions { get; set; }

    /// <summary>
    /// 结果列表
    /// </summary>
    [JsonPropertyName("results")]
    public List<CoreCmsPromotionResultModel>? Results { get; set; }
}
