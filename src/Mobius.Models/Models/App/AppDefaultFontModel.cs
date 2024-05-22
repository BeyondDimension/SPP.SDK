namespace Mobius.Models.App;

/// <summary>
/// 应用程序默认字体模型
/// </summary>
public sealed record class AppDefaultFontModel
{
    /// <summary>
    /// 默认字体名称
    /// </summary>
    public const string DefaultFontName = "HarmonyOS Sans SC";

    /// <summary>
    /// 默认文件名
    /// </summary>
    public const string DefaultFileName = "HarmonyOS_Sans_SC_Regular.ttf";

    /// <summary>
    /// 字体名称
    /// </summary>
    public string? FontName { get; set; } = DefaultFontName;

    /// <summary>
    /// 字体文件名
    /// </summary>
    public string? FileName { get; set; } = DefaultFileName;

    /// <summary>
    /// 字体文件完整路径（与 <see cref="FileName"/>）互斥
    /// </summary>
    public string? FilePath { get; set; }
}
