namespace Mobius.Models.Shop.Request;

/// <summary>
/// 优惠券相关提交验证实体
/// </summary>
public class CouponForUserRequest
{
    [SystemTextJsonProperty("page")]
    public int Page { get; set; } = 1;

    [SystemTextJsonProperty("limit")]
    public int Limit { get; set; } = 100;

    [SystemTextJsonProperty("display")]
    public string Display { get; set; } = "all";

    /// <summary>
    /// 购物车数据
    /// </summary>
    [SystemTextJsonProperty("ids")]
    public string? Ids { get; set; }
}

/// <summary>
///  优惠券相关提交验证实体
/// </summary>
public class CouponForKeyRequest
{
    [SystemTextJsonProperty("key")]
    public string Key { get; set; } = string.Empty;
}