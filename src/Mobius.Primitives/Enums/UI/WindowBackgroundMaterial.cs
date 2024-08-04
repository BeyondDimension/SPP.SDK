namespace Mobius.Enums.UI;

/// <summary>
/// 窗口背景材质
/// </summary>
public enum WindowBackgroundMaterial : byte
{
    /// <summary>
    /// 无
    /// </summary>
    None = 0,

    /// <summary>
    /// 模糊
    /// </summary>
    Blur = 2,

    /// <summary>
    /// 亚克力模糊
    /// </summary>
    AcrylicBlur = 3,

    /// <summary>
    /// Win11 Mica（云母）
    /// </summary>
    Mica = 5,
}

#if PROJ_MOBIUS
/// <summary>
/// 对枚举 <see cref="WindowBackgroundMaterial"/> 的扩展
/// </summary>
public static class WindowTransparencyLevelExtensions
{
    /// <summary>
    /// <see cref="WindowBackgroundMaterial"/> => <see cref="WindowTransparencyLevel"/>?
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static WindowTransparencyLevel? ToWindowTransparencyLevel(
        this WindowBackgroundMaterial value)
    {
        return value switch
        {
            WindowBackgroundMaterial.None => WindowTransparencyLevel.None,
            WindowBackgroundMaterial.Blur => WindowTransparencyLevel.Blur,
            WindowBackgroundMaterial.AcrylicBlur => WindowTransparencyLevel.AcrylicBlur,
            WindowBackgroundMaterial.Mica => WindowTransparencyLevel.Mica,
            _ => null,
        };
    }
}
#endif