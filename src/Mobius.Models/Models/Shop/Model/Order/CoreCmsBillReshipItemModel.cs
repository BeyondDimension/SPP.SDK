namespace Mobius.Models.Shop;

/// <summary>
/// 退货单明细表
/// </summary>
public partial class CoreCmsBillReshipItemModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 退款单单id
    /// </summary>
    [JsonPropertyName("reshipId")]
    public string ReshipId { get; set; } = string.Empty;

    /// <summary>
    /// 订单明细ID 关联order_items.id
    /// </summary>
    [JsonPropertyName("orderItemsId")]
    public int OrderItemsId { get; set; }

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
    public string SN { get; set; } = string.Empty;

    /// <summary>
    /// 商品编码
    /// </summary>
    [JsonPropertyName("bn")]
    public string BN { get; set; } = string.Empty;

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

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
    /// 货品明细序列号存储
    /// </summary>
    [JsonPropertyName("addon")]
    public string Addon { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }

    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}
