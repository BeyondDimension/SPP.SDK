namespace Mobius.Models.Shop;

/// <summary>
/// 用户地址表模型
/// </summary>
public partial class CoreCmsUserShipModel
{
    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 用户id 关联user.id
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 收货地区ID
    /// </summary>
    [JsonPropertyName("areaId")]
    public int AreaId { get; set; }

    /// <summary>
    /// 收货详细地址
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// 收货人姓名
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 收货电话
    /// </summary>
    [JsonPropertyName("mobile")]
    public string Mobile { get; set; } = string.Empty;

    /// <summary>
    /// 是否默认
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; }

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
    /// 经度
    /// </summary>
    [JsonPropertyName("longitude")]
    public string Longitude { get; set; } = string.Empty;

    /// <summary>
    /// 纬度
    /// </summary>
    [JsonPropertyName("latitude")]
    public string Latitude { get; set; } = string.Empty;

    /// <summary>
    /// 街道
    /// </summary>
    [JsonPropertyName("street")]
    public string Street { get; set; } = string.Empty;
}

public partial class CoreCmsUserShipModel
{
    /// <summary>
    /// 区域名称
    /// </summary>
    [JsonPropertyName("areaName")]
    public string AreaName { get; set; } = string.Empty;
}