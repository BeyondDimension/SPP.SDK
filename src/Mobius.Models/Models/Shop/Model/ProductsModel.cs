namespace Mobius.Models.Shop;

/// <summary>
/// 获取子规格
/// </summary>
public class ItemSpesDescModel
{
    /// <summary>
    /// 子规格名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 是否为默认规格
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; } = false;

    /// <summary>
    /// 关联商品ID
    /// </summary>
    [JsonPropertyName("productId")]
    public int ProductId { get; set; } = 0;
}

/// <summary>
/// 获取相应规格
/// </summary>
public class DefaultSpesDescModel
{
    /// <summary>
    /// 规格名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 是否为默认规格
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; } = false;

    /// <summary>
    /// 关联商品ID
    /// </summary>
    [JsonPropertyName("productId")]
    public int ProductId { get; set; } = 0;

    /// <summary>
    /// 规格图片
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;
}

/// <summary>
/// 获取商品sku列表传递
/// </summary>
public class FMGetSkuModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; } = 0;

    /// <summary>
    /// 是否计算优惠
    /// </summary>
    [JsonPropertyName("isPromotion")]
    public bool IsPromotion { get; set; } = false;

    /// <summary>
    /// 获取类型
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "goods";

    /// <summary>
    /// 团购或秒杀传递的业务序列
    /// </summary>
    [JsonPropertyName("groupId")]
    public int GroupId { get; set; } = 0;
}

/// <summary>
///     wx返回Name/Type格式实体
/// </summary>
public class WxNameTypeDto
{
    [SystemTextJsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [SystemTextJsonProperty("type")]
    public int Type { get; set; }
}

/// <summary>
/// 微信接口回调Json实体
/// </summary>
public class WebApiCallBack
{
    /// <summary>
    /// 请求接口返回说明
    /// </summary>
    [SystemTextJsonProperty("methodDescription")]
    public string MethodDescription { get; set; } = "";

    /// <summary>
    /// 提交数据
    /// </summary>
    [SystemTextJsonProperty("otherData")]
    public object? OtherData { get; set; }

    /// <summary>
    /// 状态码
    /// </summary>
    [SystemTextJsonProperty("status")]
    public bool Status { get; set; } = false;

    /// <summary>
    /// 信息说明
    /// </summary>
    [SystemTextJsonProperty("msg")]
    public string Msg { get; set; } = "接口响应成功";

    /// <summary>
    /// 返回数据
    /// </summary>
    [SystemTextJsonProperty("data")]
    public object? Data { get; set; }

    /// <summary>
    /// 返回编码
    /// </summary>
    [SystemTextJsonProperty("code")]
    public int Code { get; set; } = 0;
}

/// <summary>
/// 新的sku返回接口对象
/// </summary>
public class CoreCmsProductsViewModel
{
    /// <summary>
    /// 产品编号
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 缩略图
    /// </summary>
    [JsonPropertyName("goods_thumb")]
    public string GoodsThumb { get; set; } = string.Empty;

    /// <summary>
    /// 编码
    /// </summary>
    [JsonPropertyName("sn")]
    public string Sn { get; set; } = string.Empty;

    /// <summary>
    /// 销售价格
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    /// <summary>
    /// 成本价
    /// </summary>
    [JsonPropertyName("costprice")]
    public decimal Costprice { get; set; }

    /// <summary>
    /// 市场价
    /// </summary>
    [JsonPropertyName("mktprice")]
    public decimal Mktprice { get; set; }

    /// <summary>
    /// 库存
    /// </summary>
    [JsonPropertyName("stock")]
    public int Stock { get; set; }

    /// <summary>
    /// 冻结库存
    /// </summary>
    [JsonPropertyName("freezeStock")]
    public int FreezeStock { get; set; }

    /// <summary>
    /// 重量
    /// </summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    /// <summary>
    /// 拼团数量
    /// </summary>
    [JsonPropertyName("buyPinTuanCount")]
    public int BuyPinTuanCount { get; set; }

    /// <summary>
    /// 促销数量
    /// </summary>
    [JsonPropertyName("buyPromotionCount")]
    public int BuyPromotionCount { get; set; }

    /// <summary>
    /// SKU列表
    /// </summary>
    [JsonPropertyName("sku_list")]
    public List<Product_Sku_listItemModel> SkuList { get; set; } = new List<Product_Sku_listItemModel>();

    /// <summary>
    /// 规格列表
    /// </summary>
    [JsonPropertyName("spec_list")]
    public List<Product_Spec_listItemModel> SpecList { get; set; } = new List<Product_Spec_listItemModel>();
}

public class Product_Sku_listItemModel
{
    /// <summary>
    /// SKU编号
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// 商品ID
    /// </summary>
    [JsonPropertyName("goods_id")]
    public string GoodsId { get; set; } = string.Empty;

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("goods_name")]
    public string GoodsName { get; set; } = string.Empty;

    /// <summary>
    /// 图片
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// 价格
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    /// <summary>
    /// 市场价
    /// </summary>
    [JsonPropertyName("mktprice")]
    public decimal Mktprice { get; set; }

    /// <summary>
    /// SKU名称数组
    /// </summary>
    [JsonPropertyName("sku_name_arr")]
    public List<string> SkuNameArr { get; set; } = new List<string>();

    /// <summary>
    /// 库存
    /// </summary>
    [JsonPropertyName("stock")]
    public decimal Stock { get; set; }

    /// <summary>
    /// SKU标签
    /// </summary>
    [JsonPropertyName("spesTags")]
    public string SpesTags { get; set; } = string.Empty;
}

public class Product_Spec_listItemModel
{
    /// <summary>
    /// 规格值列表
    /// </summary>
    [JsonPropertyName("list")]
    public List<Product_Sku_listModel> List { get; set; } = new List<Product_Sku_listModel>();

    /// <summary>
    /// 规格名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class Product_Sku_listModel
{
    /// <summary>
    /// 规格名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}
