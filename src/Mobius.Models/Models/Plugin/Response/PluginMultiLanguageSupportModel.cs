namespace Mobius.Models.Plugin.Response;

/// <summary>
/// 插件语言支持
/// </summary>
[MPObj, MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Explicit)]
public sealed partial class PluginMultiLanguageSupportModel
{
    /// <summary>
    /// 主键
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string Name { get; set; } = "";

    /// <summary>
    /// 简介
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public string BriefIntroduction { get; set; } = "";

    /// <summary>
    /// 语言 Code
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public string LanguageCode { get; set; } = "";

    /// <summary>
    /// 详细介绍
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public string DetailedIntroduction { get; set; } = "";
}