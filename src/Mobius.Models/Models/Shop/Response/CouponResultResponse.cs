namespace Mobius.Models.Shop.Response;

/// <summary>
/// 用户已领取的优惠券列表响应模型
/// </summary>
public class CouponResultResponse
{
    [JsonPropertyName("list")]
    public MyCouponResultModel? List { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("display")]
    public string Display { get; set; } = string.Empty;

    [JsonPropertyName("page")]
    public int Page { get; set; }
}
