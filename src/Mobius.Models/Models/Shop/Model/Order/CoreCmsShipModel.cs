namespace Mobius.Models.Shop;

/// <summary>
/// 配送方式
/// </summary>
public partial class CoreCmsShipModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 配送方式名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 是否货到付款
    /// </summary>
    [JsonPropertyName("isCashOnDelivery")]
    public bool IsCashOnDelivery { get; set; }

    /// <summary>
    /// 首重
    /// </summary>
    [JsonPropertyName("firstUnit")]
    public int FirstUnit { get; set; }

    /// <summary>
    /// 续重
    /// </summary>
    [JsonPropertyName("continueUnit")]
    public int ContinueUnit { get; set; }

    /// <summary>
    /// 是否按地区设置配送费用
    /// </summary>
    [JsonPropertyName("isDefaultAreaFee")]
    public bool IsDefaultAreaFee { get; set; }

    /// <summary>
    /// 地区类型
    /// </summary>
    [JsonPropertyName("areaType")]
    public int AreaType { get; set; }

    /// <summary>
    /// 首重费用
    /// </summary>
    [JsonPropertyName("firstUnitPrice")]
    public decimal FirstUnitPrice { get; set; }

    /// <summary>
    /// 续重费用
    /// </summary>
    [JsonPropertyName("continueUnitPrice")]
    public decimal ContinueUnitPrice { get; set; }

    /// <summary>
    /// 配送费用计算表达式
    /// </summary>
    [JsonPropertyName("exp")]
    public string Exp { get; set; } = string.Empty;

    /// <summary>
    /// 物流公司名称
    /// </summary>
    [JsonPropertyName("logiName")]
    public string LogiName { get; set; } = string.Empty;

    /// <summary>
    /// 物流公司编码
    /// </summary>
    [JsonPropertyName("logiCode")]
    public string LogiCode { get; set; } = string.Empty;

    /// <summary>
    /// 是否默认
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; }

    /// <summary>
    /// 配送方式排序
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    /// <summary>
    /// 状态1正常2停用
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 是否包邮
    /// </summary>
    [JsonPropertyName("isFreePostage")]
    public bool IsFreePostage { get; set; }

    /// <summary>
    /// 地区配送费用
    /// </summary>
    [JsonPropertyName("areaFee")]
    public string AreaFee { get; set; } = string.Empty;

    /// <summary>
    /// 商品总额满多少免运费
    /// </summary>
    [JsonPropertyName("goodsMoney")]
    public decimal GoodsMoney { get; set; }
}
