namespace Mobius.Models.Plugin.Response;

/// <summary>
/// 插件详情
/// </summary>
[MPObj, MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Explicit)]
public sealed partial class PluginModuleDetailModel
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
    /// 评分
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public byte Score { get; set; }

    /// <summary>
    /// 分类 Code
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public string CategoryCode { get; set; } = "";

    /// <summary>
    /// 分类 Name
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public string CategoryName { get; set; } = "";

    /// <summary>
    /// Logo 图标
    /// </summary>
    [MPKey(5), MP2Key(5)]
    public string LogoIcon { get; set; } = "";

    /// <summary>
    /// 发布者 Id
    /// </summary>
    [MPKey(6), MP2Key(6)]
    public Guid PublisherId { get; set; }

    /// <summary>
    /// 发布者显示名称
    /// </summary>
    [MPKey(7), MP2Key(7)]
    public string PublisherDisplayName { get; set; } = "";

    /// <summary>
    /// 浏览量
    /// </summary>
    [MPKey(8), MP2Key(8)]
    public long ViewCount { get; set; }

    /// <summary>
    /// 下载量
    /// </summary>
    [MPKey(9), MP2Key(9)]
    public long DownloadCount { get; set; }

    /// <summary>
    /// 购买量
    /// </summary>
    [MPKey(10), MP2Key(10)]
    public long PurchaseCount { get; set; }

    /// <summary>
    /// 发布时间
    /// </summary>
    [MPKey(11), MP2Key(11)]
    public DateTimeOffset PublishTime { get; set; }

    /// <summary>
    /// 插件搜索词数组
    /// </summary>
    [MPKey(12), MP2Key(12)]
    public string SearchTerms { get; set; } = "";

    /// <summary>
    /// 最新发布信息
    /// </summary>
    [MPKey(13), MP2Key(13)]
    public PluginPackageModel LatestPackage { get; set; } = new();

    /// <summary>
    /// 语言支持
    /// </summary>
    [MPKey(14), MP2Key(14)]
    public PluginMultiLanguageSupportModel MultiLanguageSupport { get; set; } = new();

    /// <summary>
    /// 价格
    /// </summary>
    [MPKey(15), MP2Key(15)]
    public List<string> Images { get; set; } = new();
}
