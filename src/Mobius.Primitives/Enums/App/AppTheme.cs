namespace Mobius.Enums.App;

/// <summary>
/// 应用程序主题
/// </summary>
public enum AppTheme : byte
{
    /// <summary>
    /// 跟随系统
    /// </summary>
    FollowingSystem,

    /// <summary>
    /// 亮色/浅色主题
    /// </summary>
    Light,

    /// <summary>
    /// 暗色/深色主题
    /// </summary>
    Dark,

    /// <summary>
    /// 高对比度主题
    /// </summary>
    HighContrast,

    /// <summary>
    /// 自定义主题
    /// </summary>
    [Obsolete("In development…")]
    Custom,
}