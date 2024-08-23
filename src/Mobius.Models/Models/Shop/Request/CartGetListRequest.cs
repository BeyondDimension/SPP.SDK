namespace Mobius.Models.Shop.Request;

/// <summary>
/// 获取购物车列表提交实体
/// </summary>
public class CartGetListRequest
{
    /// <summary>
    /// 用户序列
    /// </summary>
    [SystemTextJsonProperty("userId")]
    public int UserId { get; set; } = 0;

    /// <summary>
    /// 购物车数据
    /// </summary>
    [SystemTextJsonProperty("ids")]
    public string Ids { get; set; } = string.Empty;

    /// <summary>
    /// 购物车类型
    /// </summary>
    [SystemTextJsonProperty("type")]
    public int Type { get; set; } = 1;

    /// <summary>
    /// 区域编码
    /// </summary>
    [SystemTextJsonProperty("areaId")]
    public int AreaId { get; set; } = 0;

    /// <summary>
    /// 积分
    /// </summary>
    [SystemTextJsonProperty("point")]
    public int Point { get; set; } = 0;

    /// <summary>
    /// 优惠券码
    /// </summary>
    [SystemTextJsonProperty("couponCode")]
    public string CouponCode { get; set; } = string.Empty;

    /// <summary>
    /// 配送方式是否包邮   1=快递配送（要去算运费）生成订单记录快递方式  2=门店自提（不需要计算运费）生成订单记录门店自提信息
    /// </summary>
    [SystemTextJsonProperty("receiptType")]
    public int ReceiptType { get; set; } = 1;

    /// <summary>
    /// 用户收货地址
    /// </summary>
    [SystemTextJsonProperty("userShipId")]
    public int UserShipId { get; set; } = 0;

    /// <summary>
    /// 关联非普通订单对象序列
    /// </summary>
    [SystemTextJsonProperty("objectId")]
    public int ObjectId { get; set; } = 0;
}
