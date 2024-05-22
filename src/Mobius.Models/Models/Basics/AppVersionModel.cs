namespace Mobius.Models.Basics;

/// <summary>
/// 应用程序版本模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class AppVersionModel : IKeyModel<Guid>, IExplicitHasValue
{
    /// <summary>
    /// 版本 Id
    /// </summary>
    [MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 版本号
    /// </summary>
    [MP2Key(1)]
    public string Version { get; set; } = "";

    /// <summary>
    /// 版本说明
    /// </summary>
    [MP2Key(2)]
    public string ReleaseNote { get; set; } = "";

    /// <summary>
    /// (单选)支持的平台
    /// </summary>
    [MP2Key(3)]
#pragma warning disable CS0618 // 类型或成员已过时
    public SppWebApiCompatDevicePlatform Platform { get; set; }
#pragma warning restore CS0618 // 类型或成员已过时

    /// <summary>
    /// (多或单选)支持的 CPU 构架
    /// </summary>
    [MP2Key(4)]
    public ArchitectureFlags SupportedAbis { get; set; }

    /// <summary>
    /// 是否禁用自动化更新，当此值为 <see langword="true"/> 时，仅提供跳转官网的手动更新方式
    /// </summary>
    [MP2Key(5)]
    public bool DisableAutomateUpdate { get; set; }

    /// <summary>
    /// 下载类型与下载地址
    /// </summary>
    [MP2Key(6)]
    public List<AppVersionDownloadModel>? Downloads { get; set; }

    /// <inheritdoc/>
    bool IExplicitHasValue.ExplicitHasValue()
    {
        return !string.IsNullOrWhiteSpace(Version) &&
            !string.IsNullOrWhiteSpace(ReleaseNote) &&
            (DisableAutomateUpdate || (Downloads != null && Downloads.Any(x => x.HasValue())));
    }
}
