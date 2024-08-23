namespace Mobius.Models.Shop;

public class CoreCmsAdvertisementModel
{
    public int Id { get; set; }

    /// <summary>
    /// 位置序列
    /// </summary>
    public int PositionId { get; set; }

    /// <summary>
    /// 广告名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 广告图片id
    /// </summary>
    public string ImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// 属性值
    /// </summary>
    public string Val { get; set; } = string.Empty;

    /// <summary>
    /// 属性值说明
    /// </summary>
    public string ValDes { get; set; } = string.Empty;

    /// <summary>
    /// 排序
    /// </summary>
    public int Sort { get; set; }

    /// <summary>
    /// 添加时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 广告位置编码
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// 类型
    /// </summary>
    public int Type { get; set; }
}
