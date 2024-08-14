namespace Mobius.Models.Shop;

public partial class CoreCmsGoodsModel
{
    /// <summary>
    /// 商品ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 商品条码
    /// </summary>
    [JsonPropertyName("bn")]
    public string Bn { get; set; } = "";

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    /// <summary>
    /// 商品简介
    /// </summary>
    [JsonPropertyName("brief")]
    public string Brief { get; set; } = "";

    /// <summary>
    /// 缩略图
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; } = "";

    /// <summary>
    /// 图集
    /// </summary>
    [JsonPropertyName("images")]
    public string Images { get; set; } = "";

    /// <summary>
    /// 视频
    /// </summary>
    [JsonPropertyName("video")]
    public string Video { get; set; } = "";

    /// <summary>
    /// 佣金分配方式
    /// </summary>
    [JsonPropertyName("productsDistributionType")]
    public int ProductsDistributionType { get; set; }

    /// <summary>
    /// 商品分类
    /// </summary>
    [JsonPropertyName("goodsCategoryId")]
    public int GoodsCategoryId { get; set; }

    /// <summary>
    /// 商品类别
    /// </summary>
    [JsonPropertyName("goodsTypeId")]
    public int GoodsTypeId { get; set; }

    /// <summary>
    /// sku序列
    /// </summary>
    [JsonPropertyName("goodsSkuIds")]
    public string GoodsSkuIds { get; set; } = "";

    /// <summary>
    /// 参数序列
    /// </summary>
    [JsonPropertyName("goodsParamsIds")]
    public string GoodsParamsIds { get; set; } = "";

    /// <summary>
    /// 品牌
    /// </summary>
    [JsonPropertyName("brandId")]
    public int BrandId { get; set; }

    /// <summary>
    /// 是否虚拟商品
    /// </summary>
    [JsonPropertyName("isNomalVirtual")]
    public bool IsNomalVirtual { get; set; }

    /// <summary>
    /// 是否上架
    /// </summary>
    [JsonPropertyName("isMarketable")]
    public bool IsMarketable { get; set; }

    /// <summary>
    /// 商品单位
    /// </summary>
    [JsonPropertyName("unit")]
    public string Unit { get; set; } = "";

    /// <summary>
    /// 商品详情
    /// </summary>
    [JsonPropertyName("intro")]
    public string Intro { get; set; } = "";

    /// <summary>
    /// 商品规格序列号存储
    /// </summary>
    [JsonPropertyName("spesDesc")]
    public string SpesDesc { get; set; } = "";

    /// <summary>
    /// 参数序列化
    /// </summary>
    [JsonPropertyName("parameters")]
    public string Parameters { get; set; } = "";

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
    /// 上架时间
    /// </summary>
    [JsonPropertyName("uptime")]
    public DateTime? Uptime { get; set; }

    /// <summary>
    /// 下架时间
    /// </summary>
    [JsonPropertyName("downtime")]
    public DateTime? Downtime { get; set; }

    /// <summary>
    /// 商品排序
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    /// <summary>
    /// 标签id逗号分隔
    /// </summary>
    [JsonPropertyName("labelIds")]
    public string LabelIds { get; set; } = "";

    /// <summary>
    /// 自定义规格名称
    /// </summary>
    [JsonPropertyName("newSpec")]
    public string NewSpec { get; set; } = "";

    /// <summary>
    /// 开启规则
    /// </summary>
    [JsonPropertyName("openSpec")]
    public int OpenSpec { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }

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
    /// 是否删除
    /// </summary>
    [JsonPropertyName("isDel")]
    public bool IsDel { get; set; }

    /// <summary>
    /// 初始销量
    /// </summary>
    [JsonPropertyName("initialSales")]
    public int InitialSales { get; set; }

    /// <summary>
    /// key 激活类型  道具 dlc 游戏
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 使用平台
    /// </summary>
    [JsonPropertyName("usePlatform")]
    public int UsePlatform { get; set; }

    /// <summary>
    /// 所有分类信息（含扩展） ,分类id:分类名称,
    /// </summary>
    [JsonPropertyName("goodsAllCategorys")]
    public string GoodsAllCategorys { get; set; } = "";
}

public partial class CoreCmsGoodsModel
{
    /// <summary>
    /// 货品编码
    /// </summary>
    [JsonPropertyName("sn")]
    public string Sn { get; set; } = "";

    /// <summary>
    /// 销售价
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; } = 0;

    /// <summary>
    /// 成本价
    /// </summary>
    [JsonPropertyName("costprice")]
    public decimal Costprice { get; set; } = 0;

    /// <summary>
    /// 市场价
    /// </summary>
    [JsonPropertyName("mktprice")]
    public decimal Mktprice { get; set; } = 0;

    /// <summary>
    /// 库存
    /// </summary>
    [JsonPropertyName("stock")]
    public int Stock { get; set; } = 0;

    /// <summary>
    /// 冻结库存
    /// </summary>
    [JsonPropertyName("freezeStock")]
    public int FreezeStock { get; set; } = 0;

    /// <summary>
    /// 重量
    /// </summary>
    [JsonPropertyName("weight")]
    public decimal Weight { get; set; } = 0;

    /// <summary>
    /// 积分抵扣金额
    /// </summary>
    [JsonPropertyName("pointsDeduction")]
    public decimal PointsDeduction { get; set; } = 0;

    /// <summary>
    /// 赠送积分
    /// </summary>
    [JsonPropertyName("points")]
    public int Points { get; set; } = 0;

    /// <summary>
    /// 图集
    /// </summary>
    [JsonPropertyName("album")]
    public string[] Album { get; set; } = Array.Empty<string>();

    /// <summary>
    /// 品牌数据
    /// </summary>
    [JsonPropertyName("brand")]
    public CoreCmsBrandModel Brand { get; set; } = new();

    /// <summary>
    /// 关联参数
    /// </summary>
    [JsonPropertyName("product")]
    public CoreCmsProductsModel Product { get; set; } = new();

    /// <summary>
    /// 关联SKU
    /// </summary>
    [JsonPropertyName("sku")]
    public List<CoreCmsProductsModel> Sku { get; set; } = new();

    /// <summary>
    /// 商品规格
    /// </summary>
    [JsonPropertyName("specification")]
    public Dictionary<string, Dictionary<string, DefaultSpesDescModel>> Specification { get; set; } = new();

    /// <summary>
    /// 关联SKU
    /// </summary>
    [JsonPropertyName("skuList")]
    public CoreCmsProductsViewModel SkuList { get; set; } = new();

    /// <summary>
    /// 是否收藏
    /// </summary>
    [JsonPropertyName("isFav")]
    public bool IsFav { get; set; } = false;

    /// <summary>
    /// 关联拼团规则
    /// </summary>
    [JsonPropertyName("pinTuanRule")]
    public CoreCmsPinTuanRuleModel? PinTuanRule { get; set; }

    /// <summary>
    /// 拼团价格
    /// </summary>
    [JsonPropertyName("pinTuanPrice")]
    public decimal PinTuanPrice { get; set; } = 0;

    /// <summary>
    /// 拼团记录
    /// </summary>
    [JsonPropertyName("pinTuanRecord")]
    public List<CoreCmsPinTuanRecordModel> PinTuanRecord { get; set; } = new();

    /// <summary>
    /// 拼团记录数量
    /// </summary>
    [JsonPropertyName("pinTuanRecordNums")]
    public int PinTuanRecordNums { get; set; } = 0;

    /// <summary>
    /// 拼团总单数
    /// </summary>
    [JsonPropertyName("buyPinTuanCount")]
    public int BuyPinTuanCount { get; set; } = 0;

    /// <summary>
    /// 团购秒杀促销总单数
    /// </summary>
    [JsonPropertyName("buyPromotionCount")]
    public int BuyPromotionCount { get; set; } = 0;

    /// <summary>
    /// 标签列表
    /// </summary>
    [JsonPropertyName("labels")]
    public List<CoreCmsLabelModel> Labels { get; set; } = new();

    /// <summary>
    /// 所属团购秒杀
    /// </summary>
    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    /// <summary>
    /// 团购类型
    /// </summary>
    [JsonPropertyName("groupType")]
    public int GroupType { get; set; }

    /// <summary>
    /// 团购状态
    /// </summary>
    [JsonPropertyName("groupStatus")]
    public bool GroupStatus { get; set; }

    /// <summary>
    /// 团购时间
    /// </summary>
    [JsonPropertyName("groupTime")]
    public DateTime GroupTime { get; set; }

    /// <summary>
    /// 团购开始时间
    /// </summary>
    [JsonPropertyName("groupStartTime")]
    public DateTime GroupStartTime { get; set; }

    /// <summary>
    /// 团购结束时间
    /// </summary>
    [JsonPropertyName("groupEndTime")]
    public DateTime GroupEndTime { get; set; }

    /// <summary>
    /// 团购时间戳
    /// </summary>
    [JsonPropertyName("groupTimestamp")]
    public int GroupTimestamp { get; set; }

    /// <summary>
    /// sku最小价格
    /// </summary>
    [JsonPropertyName("minPrice")]
    public decimal MinPrice { get; set; } = 0;

    /// <summary>
    /// sku最大价格
    /// </summary>
    [JsonPropertyName("maxPrice")]
    public decimal MaxPrice { get; set; } = 0;
}
