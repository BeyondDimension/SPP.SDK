namespace Mobius.Models.Plugin.Response;

/// <summary>
/// PluginModule - 分页查询模型
/// </summary>
[MPObj, MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Explicit)]
public sealed partial class PluginModuleItemModel
{
    /// <summary>
    /// 主键
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 插件唯一名称
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string UniqueName { get; set; } = "";

    /// <summary>
    /// 名称
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public string Name { get; set; } = "";

    /// <summary>
    /// 简介
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public string BriefIntroduction { get; set; } = "";

    /// <summary>
    /// 评分
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public byte Score { get; set; }

    /// <summary>
    /// 分类名称
    /// </summary>
    [MPKey(5), MP2Key(5)]
    public string CategoryName { get; set; } = "";

    /// <summary>
    /// Logo 图标
    /// </summary>
    [MPKey(6), MP2Key(6)]
    public string LogoIcon { get; set; } = "";

    /// <summary>
    /// 发布者显示名称
    /// </summary>
    [MPKey(7), MP2Key(7)]
    public string PublisherDisplayName { get; set; } = "";

    /// <summary>
    /// 发布时间
    /// </summary>
    [MPKey(8), MP2Key(8)]
    public DateTimeOffset PublishTime { get; set; }

    /// <summary>
    /// 插件搜索词数组
    /// </summary>
    [MPKey(9), MP2Key(9)]
    public string SearchTerms { get; set; } = "";

    /// <summary>
    /// 更新时间
    /// </summary>
    [MPKey(10), MP2Key(10)]
    public DateTimeOffset UpdateTime { get; set; }

    /// <summary>
    /// 费用类型
    /// </summary>
    [MPKey(11), MP2Key(11)]
    public PluginFeeType FeeType { get; set; }

    /// <summary>
    /// 是否免费
    /// </summary>
    [MPKey(12), MP2Key(12)]
    public bool IsFree => FeeType == PluginFeeType.Free;
}

