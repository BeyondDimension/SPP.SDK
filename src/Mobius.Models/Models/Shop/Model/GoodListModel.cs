namespace Mobius.Models.Shop;

public class GoodListModel
{
    /// <summary>
    /// 商品ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 商品简介
    /// </summary>
    [JsonPropertyName("brief")]
    public string Brief { get; set; } = string.Empty;

    /// <summary>
    /// 缩略图
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// 视频
    /// </summary>
    [JsonPropertyName("video")]
    public string Video { get; set; } = string.Empty;

    /// <summary>
    /// 商品分类
    /// </summary>
    [JsonPropertyName("goodsCategoryId")]
    public int GoodsCategoryId { get; set; }

    /// <summary>
    /// 商品所有分类信息（含扩展）
    /// </summary>
    [JsonPropertyName("goodsAllCategorys")]
    public string GoodsAllCategorys { get; set; } = string.Empty;

    /// <summary>
    /// 商品类别
    /// </summary>
    [JsonPropertyName("goodsTypeId")]
    public int GoodsTypeId { get; set; }

    /// <summary>
    /// 品牌ID
    /// </summary>
    [JsonPropertyName("brandId")]
    public int BrandId { get; set; }

    /// <summary>
    /// 品牌名称
    /// </summary>
    [JsonPropertyName("brandName")]
    public string BrandName { get; set; } = string.Empty;

    /// <summary>
    /// 是否虚拟商品
    /// </summary>
    [JsonPropertyName("isNomalVirtual")]
    public bool IsNormalVirtual { get; set; }

    /// <summary>
    /// 商品单位
    /// </summary>
    [JsonPropertyName("unit")]
    public string Unit { get; set; } = string.Empty;

    /// <summary>
    /// 评论次数
    /// </summary>
    [JsonPropertyName("commentsCount")]
    public int CommentsCount { get; set; }

    /// <summary>
    /// 浏览次数
    /// </summary>
    [JsonPropertyName("viewCount")]
    public int ViewCount { get; set; }

    /// <summary>
    /// 购买次数
    /// </summary>
    [JsonPropertyName("buyCount")]
    public int BuyCount { get; set; }

    /// <summary>
    /// 商品排序
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    /// <summary>
    /// 标签ID逗号分隔
    /// </summary>
    [JsonPropertyName("labelIds")]
    public string LabelIds { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 是否推荐
    /// </summary>
    [JsonPropertyName("isRecommend")]
    public bool IsRecommend { get; set; }

    /// <summary>
    /// 是否热门
    /// </summary>
    [JsonPropertyName("isHot")]
    public bool IsHot { get; set; }

    /// <summary>
    /// 初始销量
    /// </summary>
    [JsonPropertyName("initialSales")]
    public int InitialSales { get; set; }

    /// <summary>
    /// 货品价格
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    /// <summary>
    /// 货品市场价
    /// </summary>
    [JsonPropertyName("mktprice")]
    public decimal MktPrice { get; set; }

    /// <summary>
    /// 积分可抵扣金额
    /// </summary>
    [JsonPropertyName("pointsDeduction")]
    public decimal PointsDeduction { get; set; }

    /// <summary>
    /// 赠送积分
    /// </summary>
    [JsonPropertyName("points")]
    public int Points { get; set; }

    /// <summary>
    /// 重量(千克)
    /// </summary>
    [JsonPropertyName("weight")]
    public decimal Weight { get; set; }

    /// <summary>
    /// 库存
    /// </summary>
    [JsonPropertyName("stock")]
    public int Stock { get; set; }

    /// <summary>
    /// 是否参与营销（优惠券，满减，秒杀，团购）
    /// </summary>
    [JsonPropertyName("isInActivity")]
    public bool IsInActivity { get; set; }

    /// <summary>
    /// 激活类型  道具 dlc 游戏
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 使用平台
    /// </summary>
    [JsonPropertyName("usePlatform")]
    public int UsePlatform { get; set; }
}
