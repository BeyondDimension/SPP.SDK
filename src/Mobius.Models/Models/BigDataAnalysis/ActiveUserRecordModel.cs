namespace Mobius.Models.BigDataAnalysis;

/// <summary>
/// (匿名)活跃用户记录，用于统计分析以改进体验，详情见使用协议声明
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class ActiveUserRecordModel : IExplicitHasValue, IDeviceId
{
    [MP2Key(0)]
    public ActiveUserAnonymousStatisticType Type { get; set; }

    /// <summary>
    /// 使用平台
    /// </summary>
    [MP2Key(1)]
#pragma warning disable CS0618 // 类型或成员已过时
    public SppWebApiCompatDevicePlatform Platform { get; set; }
#pragma warning restore CS0618 // 类型或成员已过时

    /// <summary>
    /// 设备类型
    /// </summary>
    [MP2Key(2)]
    public DeviceIdiom DeviceIdiom { get; set; }

    /// <summary>
    /// 系统版本号
    /// </summary>
    [MP2Key(3)]
    public string? OSVersion { get; set; }

    /// <summary>
    /// 屏幕总数
    /// </summary>
    [MP2Key(4)]
    public int ScreenCount { get; set; }

    /// <summary>
    /// 主屏幕像素密度
    /// </summary>
    [MP2Key(5)]
    public double PrimaryScreenPixelDensity { get; set; }

    /// <summary>
    /// 主屏幕宽度
    /// </summary>
    [MP2Key(6)]
    public int PrimaryScreenWidth { get; set; }

    /// <summary>
    /// 主屏幕高度
    /// </summary>
    [MP2Key(7)]
    public int PrimaryScreenHeight { get; set; }

    /// <summary>
    /// 总屏幕宽度
    /// </summary>
    [MP2Key(8)]
    public int SumScreenWidth { get; set; }

    /// <summary>
    /// 总屏幕高度
    /// </summary>
    [MPKey(9), MP2Key(9)]
    public int SumScreenHeight { get; set; }

    /// <summary>
    /// 当前进程 CPU 架构(处理器体系结构)
    /// </summary>
    [MP2Key(10)]
    public ArchitectureFlags ProcessArch { get; set; }

    /// <summary>
    /// 是否已登录账号
    /// </summary>
    [MP2Key(11)]
    public bool? IsAuthenticated { get; set; }

    /// <inheritdoc/>
    [MP2Key(12)]
    public Guid DeviceIdG { get; set; }

    /// <inheritdoc/>
    [MP2Key(13)]
    public string? DeviceIdR { get; set; }

    /// <inheritdoc/>
    [MP2Key(14)]
    public string? DeviceIdN { get; set; }

    /// <inheritdoc/>
    bool IExplicitHasValue.ExplicitHasValue()
    {
        return Type.IsDefined() &&
#pragma warning disable CS0618 // 类型或成员已过时
            Platform.IsDefined() &&
#pragma warning restore CS0618 // 类型或成员已过时
            DeviceIdiom.IsDefined() &&
            !string.IsNullOrWhiteSpace(OSVersion) &&
            ProcessArch.IsDefined();
    }
}
