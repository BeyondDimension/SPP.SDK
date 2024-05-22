namespace Mobius.Models.Komaasharu;

/// <summary>
/// 广告模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class KomaasharuModel
{
    /// <summary>
    /// 广告 Id
    /// </summary>
    [MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 排序值
    /// </summary>
    [MP2Key(1)]
    public long Order { get; set; }

    /// <summary>
    /// 广告描述
    /// </summary>
    [MP2Key(2)]
    public string? Desc { get; set; }

    /// <inheritdoc cref="KomaasharuType"/>
    [MP2Key(3)]
    public KomaasharuType Type { get; set; }

    /// <inheritdoc cref="KomaasharuOrientation"/>
    [MP2Key(4)]
    public KomaasharuOrientation Orientation { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    [MP2Key(5)]
    public string Name { get; set; } = string.Empty;
}
