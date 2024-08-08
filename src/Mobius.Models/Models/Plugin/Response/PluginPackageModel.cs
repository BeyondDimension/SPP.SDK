namespace Mobius.Models.Plugin.Response;

/// <summary>
/// 插件包详情
/// </summary>
[MPObj, MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Explicit)]
public sealed partial class PluginPackageModel
{
    /// <summary>
    /// 主键
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 版本号
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string VersionNumber { get; set; } = "";

    /// <summary>
    /// 更新日志
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public string Changelog { get; set; } = "";

    /// <summary>
    /// 插件包 Hash
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public string PluginPackageHash { get; set; } = "";

    /// <summary>
    /// 静态资源 Id
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public Guid StaticResourceId { get; set; }

    /// <summary>
    /// 下载地址
    /// </summary>
    [MPKey(5), MP2Key(5)]
    public string DownloadAddress { get; set; } = "";

    /// <summary>
    /// 程序最低支持版本
    /// </summary>
    [MPKey(6), MP2Key(6)]
    public string MinimumSupportedAppVersion { get; set; } = "";

    /// <summary>
    /// 支持的平台
    /// </summary>
    [MPKey(7), MP2Key(7)]
    public ClientPlatform SupportedPlatform { get; set; }
}
