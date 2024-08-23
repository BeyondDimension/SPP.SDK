namespace Mobius.Models.Shop;

/// <summary>
/// 门店模型
/// </summary>
public partial class CoreCmsStoreModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 门店名称
    /// </summary>
    [JsonPropertyName("storeName")]
    public string StoreName { get; set; } = string.Empty;

    /// <summary>
    /// 门店电话/手机号
    /// </summary>
    [JsonPropertyName("mobile")]
    public string Mobile { get; set; } = string.Empty;

    /// <summary>
    /// 门店联系人
    /// </summary>
    [JsonPropertyName("linkMan")]
    public string LinkMan { get; set; } = string.Empty;

    /// <summary>
    /// 门店logo
    /// </summary>
    [JsonPropertyName("logoImage")]
    public string LogoImage { get; set; } = string.Empty;

    /// <summary>
    /// 门店地区id
    /// </summary>
    [JsonPropertyName("areaId")]
    public int AreaId { get; set; }

    /// <summary>
    /// 门店详细地址
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// 坐标位置
    /// </summary>
    [JsonPropertyName("coordinate")]
    public string Coordinate { get; set; } = string.Empty;

    /// <summary>
    /// 纬度
    /// </summary>
    [JsonPropertyName("latitude")]
    public string Latitude { get; set; } = string.Empty;

    /// <summary>
    /// 经度
    /// </summary>
    [JsonPropertyName("longitude")]
    public string Longitude { get; set; } = string.Empty;

    /// <summary>
    /// 是否默认
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; }

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
    /// 距离
    /// </summary>
    [JsonPropertyName("distance")]
    public decimal Distance { get; set; }
}

public partial class CoreCmsStoreModel
{
    /// <summary>
    /// 全名详细地址
    /// </summary>
    [JsonPropertyName("allAddress")]
    public string AllAddress { get; set; } = string.Empty;

    /// <summary>
    /// 距离说明
    /// </summary>
    [JsonPropertyName("distanceStr")]
    public string DistanceStr { get; set; } = string.Empty;
}
