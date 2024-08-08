namespace Mobius.Models.Shop.Response;

/// <summary>
/// 购物车信息
/// </summary>
public class ShopCartResponse
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; } = 0;

    /// <summary>
    /// 商品总金额
    /// </summary>
    [JsonPropertyName("goodsAmount")]
    public decimal GoodsAmount { get; set; }

    /// <summary>
    /// 总金额
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    /// <summary>
    /// 订单促销金额
    /// 单纯的订单促销的金额
    /// </summary>
    [JsonPropertyName("orderPromotionMoney")]
    public decimal OrderPromotionMoney { get; set; } = 0;

    /// <summary>
    /// 商品促销金额
    /// 所有的商品促销的总计
    /// </summary>
    [JsonPropertyName("goodsPromotionMoney")]
    public decimal GoodsPromotionMoney { get; set; } = 0;

    /// <summary>
    /// 优惠券优惠金额
    /// </summary>
    [JsonPropertyName("couponPromotionMoney")]
    public decimal CouponPromotionMoney { get; set; } = 0;

    /// <summary>
    /// 促销列表
    /// </summary>
    [JsonPropertyName("promotionList")]
    public Dictionary<int, WxNameTypeDto> PromotionList { get; set; } = new();

    /// <summary>
    /// 运费
    /// </summary>
    [JsonPropertyName("costFreight")]
    public decimal CostFreight { get; set; } = 0;

    /// <summary>
    /// 商品总重
    /// </summary>
    [JsonPropertyName("weight")]
    public decimal Weight { get; set; } = 0;

    /// <summary>
    /// 优惠券
    /// </summary>
    [JsonPropertyName("coupon")]
    public List<string> Coupon { get; set; } = new();

    /// <summary>
    /// 购物车类型
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; } = 1;

    /// <summary>
    /// 积分
    /// </summary>
    [JsonPropertyName("point")]
    public int Point { get; set; } = 0;

    /// <summary>
    /// 积分可以抵扣多少金额
    /// </summary>
    [JsonPropertyName("pointExchangeMoney")]
    public decimal PointExchangeMoney { get; set; } = 0;

    /// <summary>
    /// 购物车产品列表
    /// </summary>
    [JsonPropertyName("list")]
    public List<CartProducts> List { get; set; } = new();

    /// <summary>
    /// 消息回调
    /// </summary>
    [JsonPropertyName("error")]
    public WebApiCallBack Error { get; set; } = new();
}

public class CartProducts
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = 0;

    [JsonPropertyName("userId")]
    public int UserId { get; set; } = 0;

    [JsonPropertyName("productId")]
    public int ProductId { get; set; } = 0;

    [JsonPropertyName("nums")]
    public int Nums { get; set; } = 1;

    [JsonPropertyName("isCollection")]
    public bool IsCollection { get; set; } = false;

    [JsonPropertyName("isSelect")]
    public bool IsSelect { get; set; } = false;

    [JsonPropertyName("type")]
    public int Type { get; set; } = 1;

    [JsonPropertyName("weight")]
    public decimal Weight { get; set; } = 0;

    [JsonPropertyName("products")]
    public CoreCmsProductsModel Products { get; set; } = new();

    [JsonPropertyName("good")]
    public CoreCmsGoodsModel Good { get; set; } = new();
}