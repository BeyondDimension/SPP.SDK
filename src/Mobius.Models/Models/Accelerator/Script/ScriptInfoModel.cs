namespace Mobius.Models.Accelerator.Script;

/// <summary>
/// 脚本信息
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class ScriptInfoModel : IKeyModel<Guid>
{
    /// <summary>
    /// 脚本 Id
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 版本号
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// 更新链接
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public string UpdateLink { get; set; } = string.Empty;

    /// <summary>
    /// 描述
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public string? Describe { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public DateTimeOffset UpdateTime { get; set; }
}
