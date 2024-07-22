namespace Mobius.Enums.Devices;

/// <summary>
/// SppWebApi 定义的平台，用于旧接口兼容，新接口应使用 <see cref="DevicePlatform2"/>
/// </summary>
[Flags]
[Description(
"""
use DevicePlatform2 Or ClientPlatform replace on top of newly added content.
oldType: System.Runtime.Devices.Platform
""")]
public enum SppWebApiCompatDevicePlatform
{
    /// <summary>
    /// 未知
    /// </summary>
    Unknown = 1,

    /// <summary>
    /// Microsoft Windows(Win32)
    /// </summary>
    Windows = 4,

    /// <summary>
    /// Ubuntu / Debian / CentOS / Tizen
    /// </summary>
    Linux = 8,

    /// <summary>
    /// Android Phone / Android Pad / WearOS(Android Wear) / Android TV
    /// </summary>
    Android = 16,

    /// <summary>
    /// iOS / iPadOS / watchOS / tvOS / macOS
    /// </summary>
    Apple = 32,

    /// <summary>
    /// Universal Windows Platform
    /// </summary>
    [Description("use Win32")]
    UWP = 64,

    /// <summary>
    /// Windows UI 库 (WinUI) 3
    /// </summary>
    WinUI = 128,
}

/// <summary>
/// Enum 扩展 <see cref="SppWebApiCompatDevicePlatform"/>
/// </summary>
[Description(
"""
use DevicePlatform2 Or ClientPlatform replace on top of newly added content.
""")]
public static partial class SppWebApiCompatDevicePlatformEnumExtensions
{
    /// <summary>
    /// 值是否在定义的范围中，排除 <see cref="SppWebApiCompatDevicePlatform.Unknown"/>
    /// </summary>
    /// <param name="platform"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsDefined(this SppWebApiCompatDevicePlatform platform)
        => platform != SppWebApiCompatDevicePlatform.Unknown &&
            Enum.IsDefined(platform);

    /// <summary>
    /// 将 <see cref="DevicePlatform2"/> 转换为 <see cref="SppWebApiCompatDevicePlatform"/>
    /// </summary>
    /// <param name="devicePlatform"></param>
    /// <returns></returns>
    public static SppWebApiCompatDevicePlatform ToSppWebApiCompat(this DevicePlatform2 devicePlatform) => devicePlatform switch
    {
        DevicePlatform2.UWP => SppWebApiCompatDevicePlatform.UWP,
        DevicePlatform2.WindowsDesktopBridge or
        DevicePlatform2.Windows => SppWebApiCompatDevicePlatform.Windows,
        DevicePlatform2.WSA or
        DevicePlatform2.AndroidUnknown or
        DevicePlatform2.AndroidPhone or
        DevicePlatform2.AndroidTablet or
        DevicePlatform2.AndroidDesktop or
        DevicePlatform2.AndroidTV or
        DevicePlatform2.AndroidWatch or
        DevicePlatform2.AndroidVirtual => SppWebApiCompatDevicePlatform.Android,
        DevicePlatform2.iPadOS or
        DevicePlatform2.iOS or
        DevicePlatform2.tvOS or
        DevicePlatform2.macOS or
        DevicePlatform2.watchOS or
        DevicePlatform2.MacCatalyst => SppWebApiCompatDevicePlatform.Apple,
        DevicePlatform2.Linux or
        DevicePlatform2.ChromeOS => SppWebApiCompatDevicePlatform.Linux,
        DevicePlatform2.WinUI => SppWebApiCompatDevicePlatform.WinUI,
        _ => SppWebApiCompatDevicePlatform.Unknown,
    };
}
