namespace Mobius.Enums.Komaasharu;

/// <summary>
/// 广告类型
/// </summary>
public enum KomaasharuType
{
    /// <summary>
    /// 横幅广告
    /// </summary>
    Banner = 1,

    /// <summary>
    /// 程序内弹窗广告
    /// </summary>
    Popup = 2,

    /// <summary>
    /// 系统消息广告
    /// </summary>
    News = 4,

    /// <summary>
    /// 内嵌广告
    /// </summary>
    Embedded = 8,

    /// <summary>
    /// 桌面端主页 Banner 图
    /// </summary>
    DeskTopHomeBanner = 16,
}

#if DEBUG
/// <inheritdoc cref="KomaasharuType"/>
[Obsolete("use KomaasharuType", true)]
public enum AdvertisementType
{
}
#endif