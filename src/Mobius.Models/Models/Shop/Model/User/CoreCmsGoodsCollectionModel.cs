namespace Mobius.Models.Shop;

public partial class CoreCmsGoodsCollectionModel
{
    /// <summary>
    /// ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 商品id 关联goods.id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public int GoodsId { get; set; }

    /// <summary>
    /// 用户id
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("goodsName")]
    public string GoodsName { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }
}

public partial class CoreCmsGoodsCollectionModel
{
    /// <summary>
    /// 商品信息
    /// </summary>
    public CoreCmsGoodsModel? Goods { get; set; }

    /// <summary>
    /// 货品价格
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    /// <summary>
    /// 货品市场价格
    /// </summary>
    [JsonPropertyName("mktprice")]
    public decimal MarketPrice { get; set; }

    /// <summary>
    /// 商品品牌名称
    /// </summary>
    [JsonPropertyName("goodsBrandName")]
    public string GoodsBrandName { get; set; } = string.Empty;
}