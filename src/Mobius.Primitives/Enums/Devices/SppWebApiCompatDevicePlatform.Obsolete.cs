#if DEBUG
namespace Mobius.Enums.Devices;

/// <inheritdoc cref="SppWebApiCompatDevicePlatform"/>
[Flags]
[Obsolete("use SppWebApiCompatDevicePlatform.", true)]
public enum Platform
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
    [Obsolete("use Win32")]
    UWP = 64,

    /// <summary>
    /// Windows UI 库 (WinUI) 3
    /// </summary>
    WinUI = 128,
}
#endif