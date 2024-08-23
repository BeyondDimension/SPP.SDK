namespace Mobius.Models.Shop.Request;

/// <summary>
/// 创建订单提交参数
/// </summary>
public class CreateOrderRequest
{
    /// <summary>
    /// 区域序列
    /// </summary>
    [SystemTextJsonProperty("areaId")]
    public int AreaId { get; set; }

    /// <summary>
    /// 购物车序列
    /// </summary>
    [SystemTextJsonProperty("cartIds")]
    public string CartIds { get; set; } = string.Empty;

    /// <summary>
    /// 优惠券码
    /// </summary>
    [SystemTextJsonProperty("couponCode")]
    public string CouponCode { get; set; } = string.Empty;

    /// <summary>
    /// 买家留言
    /// </summary>
    [SystemTextJsonProperty("memo")]
    public string Memo { get; set; } = string.Empty;

    /// <summary>
    /// 积分
    /// </summary>
    [SystemTextJsonProperty("point")]
    public int Point { get; set; } = 0;

    /// <summary>
    /// 收货方式,1快递物流，2同城配送，3门店自提，4虚拟商品
    /// </summary>
    [SystemTextJsonProperty("receiptType")]
    public int ReceiptType { get; set; } = 1;

    /// <summary>
    /// 来源平台
    /// </summary>
    [SystemTextJsonProperty("source")]
    public int Source { get; set; } = 2;

    /// <summary>
    /// 发票税务编号
    /// </summary>
    [SystemTextJsonProperty("taxCode")]
    public string TaxCode { get; set; } = string.Empty;

    /// <summary>
    /// 发票抬头
    /// </summary>
    [SystemTextJsonProperty("taxName")]
    public string TaxName { get; set; } = string.Empty;

    /// <summary>
    /// 发票类型
    /// </summary>
    [SystemTextJsonProperty("taxType")]
    public int TaxType { get; set; } = 1;

    /// <summary>
    /// 用户地址库序列
    /// </summary>
    [SystemTextJsonProperty("ushipId")]
    public int UshipId { get; set; } = 0;

    /// <summary>
    /// 门店序列
    /// </summary>
    [SystemTextJsonProperty("storeId")]
    public int StoreId { get; set; } = 0;

    /// <summary>
    /// 订单类型[对应CoreCmsOrder表orderType字段]/也对应购物车cart订单类型
    /// </summary>
    [SystemTextJsonProperty("orderType")]
    public int OrderType { get; set; } = 1;

    /// <summary>
    /// 提货人姓名
    /// </summary>
    [SystemTextJsonProperty("ladingName")]
    public string LadingName { get; set; } = string.Empty;

    /// <summary>
    /// 提货人联系方式
    /// </summary>
    [SystemTextJsonProperty("ladingMobile")]
    public string LadingMobile { get; set; } = string.Empty;

    /// <summary>
    /// 非普通订单关联营销对象序列
    /// </summary>
    [SystemTextJsonProperty("objectId")]
    public int ObjectId { get; set; } = 0;

    /// <summary>
    /// 拼团订单分组序列
    /// </summary>
    [SystemTextJsonProperty("teamId")]
    public int TeamId { get; set; } = 0;

    /// <summary>
    /// 场景值（升级微信自定义交易组件后弃用）
    /// </summary>
    [SystemTextJsonProperty("scene")]
    public int Scene { get; set; } = 0;

    /// <summary>
    /// 是否需要推单，1:需要，0:不需要
    /// </summary>
    [SystemTextJsonProperty("requireOrder")]
    public int RequireOrder { get; set; } = 0;

    /// <summary>
    /// requireOrder = 1时生效，0，非二级商户号订单，1，二级商户号订单，2，两种方式皆可（后续只会存在1）
    /// </summary>
    [SystemTextJsonProperty("requiredFundType")]
    public int RequiredFundType { get; set; } = 0;

    /// <summary>
    ///  跟踪ID，有效期十分钟，会影响主播归因、分享员归因等，需创建订单前调用，调用生成订单 api 时需传入该参数
    /// </summary>
    [SystemTextJsonProperty("traceId")]
    public string TraceId { get; set; } = string.Empty;

    /// <summary>
    /// 订单项渠道来源
    /// </summary>
    [SystemTextJsonProperty("orderItemChannel")]
    public int OrderItemChannel { get; set; }
}
