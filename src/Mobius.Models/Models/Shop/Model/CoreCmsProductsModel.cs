namespace Mobius.Models.Shop;

/// <summary>
/// 货品表
/// </summary>
public partial class CoreCmsProductsModel
{
    /// <summary>
    /// 货品序列
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商品序列
    /// </summary>
    public int GoodsId { get; set; }

    /// <summary>
    /// 商品条码
    /// </summary>
    public string Barcode { get; set; } = "";

    /// <summary>
    /// 货品编码
    /// </summary>
    public string Sn { get; set; } = "";

    /// <summary>
    /// 货品价格
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// 货品成本价
    /// </summary>
    public decimal CostPrice { get; set; }

    /// <summary>
    /// 货品市场价
    /// </summary>
    public decimal MktPrice { get; set; }

    /// <summary>
    /// 是否上架
    /// </summary>
    public bool Marketable { get; set; }

    /// <summary>
    /// 积分可抵扣金额
    /// </summary>
    public decimal PointsDeduction { get; set; }

    /// <summary>
    /// 赠送积分
    /// </summary>
    public int Points { get; set; }

    /// <summary>
    /// 重量(千克)
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    /// 库存
    /// </summary>
    public int Stock { get; set; }

    /// <summary>
    /// 冻结库存
    /// </summary>
    public int FreezeStock { get; set; }

    /// <summary>
    /// 规格值
    /// </summary>
    public string SpesDesc { get; set; } = "";

    /// <summary>
    /// 规格值标签
    /// </summary>
    public string SpesTags { get; set; } = "";

    /// <summary>
    /// 是否默认货品
    /// </summary>
    public bool IsDefalut { get; set; }

    /// <summary>
    /// 规格图片
    /// </summary>
    public string Images { get; set; } = "";

    /// <summary>
    /// 是否删除
    /// </summary>
    public bool IsDel { get; set; }

    #region 外部平台CDKey商品绑定

    /// <summary>
    /// 外部平台类型
    /// </summary>
    public int ExternalPlatformType { get; set; }

    /// <summary>
    /// 外部平台货品Id
    /// </summary>
    public int ExternalPlatformProductId { get; set; }

    /// <summary>
    /// 提取规则 GlobalEnumVars.ProductCDKeyExtractRule
    /// </summary>
    public int ExtractRule { get; set; }

    #endregion
}

public partial class CoreCmsProductsModel
{
    /// <summary>
    /// 商品编码
    /// </summary>
    [JsonPropertyName("bn")]
    public string Bn { get; set; } = "";

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    /// <summary>
    /// 是否上架
    /// </summary>
    [JsonPropertyName("isMarketable")]
    public bool IsMarketable { get; set; } = false;

    /// <summary>
    /// 商品单位
    /// </summary>
    [JsonPropertyName("unit")]
    public string Unit { get; set; } = "";

    /// <summary>
    /// 原始总库存
    /// </summary>
    [JsonPropertyName("totalStock")]
    public int TotalStock { get; set; } = 0;

    /// <summary>
    /// 会员价格体系
    /// </summary>
    [JsonPropertyName("gradePrice")]
    public List<CoreCmsGoodsGradeModel> GradePrice { get; set; } = new();

    /// <summary>
    /// 关联会员级别
    /// </summary>
    [JsonPropertyName("gradeInfo")]
    public object? GradeInfo { get; set; }

    /// <summary>
    /// 初始化匹配sku
    /// </summary>
    [JsonPropertyName("defaultSpecificationDescription")]
    public Dictionary<string, Dictionary<string, DefaultSpesDescModel>> DefaultSpecificationDescription { get; set; } = new();

    /// <summary>
    /// 商品总价格,商品单价乘以数量
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; } = 0;

    /// <summary>
    /// 促销列表
    /// </summary>
    [JsonPropertyName("promotionList")]
    public Dictionary<int, WxNameTypeDto> PromotionList { get; set; } = new();

    /// <summary>
    /// 促销金额
    /// </summary>
    [JsonPropertyName("promotionAmount")]
    public decimal PromotionAmount { get; set; } = 0;

    /// <summary>
    /// 拼团购买数量
    /// </summary>
    [JsonPropertyName("buyPinTuanCount")]
    public int BuyPinTuanCount { get; set; } = 0;

    /// <summary>
    /// 促销购买件数
    /// </summary>
    [JsonPropertyName("buyPromotionCount")]
    public int BuyPromotionCount { get; set; } = 0;

    /// <summary>
    /// 是否参与拼团规则
    /// </summary>
    [JsonPropertyName("pinTuanRule")]
    public CoreCmsPinTuanRule? PinTuanRule { get; set; }

    /// <summary>
    /// 一级佣金
    /// </summary>
    [JsonPropertyName("levelOne")]
    public decimal LevelOne { get; set; } = 0;

    /// <summary>
    /// 二级佣金
    /// </summary>
    [JsonPropertyName("levelTwo")]
    public decimal LevelTwo { get; set; } = 0;

    /// <summary>
    /// 三级佣金
    /// </summary>
    [JsonPropertyName("levelThree")]
    public decimal LevelThree { get; set; } = 0;

    /// <summary>
    /// CDKey数量
    /// </summary>
    [JsonPropertyName("cdKeyCount")]
    public int CdKeyCount { get; set; }
}
