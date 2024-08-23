namespace Mobius.Models.Shop;

public class CoreCmsAdvertPositionModel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 位置编码
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// 添加时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 广告平台
    /// </summary>
    public int Platform { get; set; }

    /// <summary>
    /// 广告位类型
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// 是否启用
    /// </summary>
    public bool IsEnable { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Sort { get; set; }
}
