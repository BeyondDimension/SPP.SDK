namespace Mobius.Models.Shop;

/// <summary>
/// 订单明细模型
/// </summary>
public partial class CoreCmsOrderItemModel
{
    /// <summary>
    /// 序号
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 订单ID 关联order.id
    /// </summary>
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// 商品ID 关联goods.id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public int GoodsId { get; set; }

    /// <summary>
    /// 货品ID 关联products.id
    /// </summary>
    [JsonPropertyName("productId")]
    public int ProductId { get; set; }

    /// <summary>
    /// 货品编码
    /// </summary>
    [JsonPropertyName("sn")]
    public string Sn { get; set; } = string.Empty;

    /// <summary>
    /// 商品编码
    /// </summary>
    [JsonPropertyName("bn")]
    public string Bn { get; set; } = string.Empty;

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 货品价格单价
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    /// <summary>
    /// 货品***单价
    /// </summary>
    [JsonPropertyName("costprice")]
    public decimal CostPrice { get; set; }

    /// <summary>
    /// 市场价
    /// </summary>
    [JsonPropertyName("mktprice")]
    public decimal MktPrice { get; set; }

    /// <summary>
    /// 图片
    /// </summary>
    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// 数量
    /// </summary>
    [JsonPropertyName("nums")]
    public int Nums { get; set; }

    /// <summary>
    /// 总价
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    /// <summary>
    /// 商品优惠总金额
    /// </summary>
    [JsonPropertyName("promotionAmount")]
    public decimal PromotionAmount { get; set; }

    /// <summary>
    /// 促销信息
    /// </summary>
    [JsonPropertyName("promotionList")]
    public string PromotionList { get; set; } = string.Empty;

    /// <summary>
    /// 总重量
    /// </summary>
    [JsonPropertyName("weight")]
    public decimal Weight { get; set; }

    /// <summary>
    /// 发货数量
    /// </summary>
    [JsonPropertyName("sendNums")]
    public int SendNums { get; set; }

    /// <summary>
    /// 货品明细序列号存储
    /// </summary>
    [JsonPropertyName("addon")]
    public string Addon { get; set; } = string.Empty;

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
    /// 是否虚拟商品
    /// </summary>
    [JsonPropertyName("isNomalVirtual")]
    public bool IsNormalVirtual { get; set; }

    /// <summary>
    /// 是否评价
    /// </summary>
    [JsonPropertyName("isComment")]
    public bool IsComment { get; set; } = false;

    /// <summary>
    /// 渠道来源
    /// </summary>
    [JsonPropertyName("channel")]
    public int Channel { get; set; }
}

public partial class CoreCmsOrderItemModel<TPromotionObj>
{
    /// <summary>
    /// 退货商品数量
    /// </summary>
    [JsonPropertyName("reshipNums")]
    public int ReshipNums { get; set; } = 0;

    /// <summary>
    /// 已发货的退货商品
    /// </summary>
    [JsonPropertyName("reshipedNums")]
    public int ReshipedNums { get; set; } = 0;

    /// <summary>
    /// 当前退货数量
    /// </summary>
    [JsonPropertyName("atPresentReshipNums")]
    public int AtPresentReshipNums { get; set; } = 0;

    [JsonPropertyName("promotionObj")]
    public TPromotionObj? PromotionObj { get; set; }

    /// <summary>
    /// 已提取的CDKey列表
    /// </summary>
    [JsonPropertyName("extractCDKeys")]
    public List<string>? ExtractCDKeys { get; set; }

    /// <summary>
    /// 关联商品 key 激活类型  道具 dlc 游戏
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 关联商品使用平台
    /// </summary>
    [JsonPropertyName("usePlatform")]
    public int UsePlatform { get; set; }

    /// <summary>
    /// Agiso 订单Id带时间戳
    /// </summary>
    [JsonPropertyName("agisoOrderIdWithTimestamp")]
    public bool AgisoOrderIdWithTimestamp { get; set; }
}