namespace Mobius.Models.Plugin.Response;

/// <summary>
/// 插件分类DTO
/// </summary>
[MPObj, MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Explicit)]
public sealed partial class PluginCategoryModel
{
    /// <summary>
    /// 主键
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 分类编码
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string CategoryCode { get; set; } = "";

    /// <summary>
    /// 分类名称
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public string CategoryName { get; set; } = "";
}