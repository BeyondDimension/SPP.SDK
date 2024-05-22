namespace Mobius.Models.Accelerator;

/// <summary>
/// 加速项目
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
[DebuggerDisplay("{DebuggerDisplay(),nq}")]
public sealed partial class AccelerateProjectGroupModel : JsonModel<AccelerateProjectGroupModel>
{
    /// <inheritdoc cref="DebuggerDisplayAttribute"/>
    public string DebuggerDisplay() => $"{Name}, {IconUrl}";

    /// <summary>
    /// 名称
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 当前组中所有的加速项目集合
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public List<AccelerateProjectModel>? Items { get; set; } = [];

    /// <summary>
    /// 图标 Url
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public string? IconUrl { get; set; }

    /// <summary>
    /// 是否选中
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public bool Checked { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public long Order { get; set; }
}
