namespace Mobius.Enums.UI;

/// <summary>
/// 描述如何调整内容大小以填充为其分配的空间。
/// <list type="bullet">
/// <item>Windows.UI.Xaml.Media.Stretch</item>
/// <item>System.Windows.Media.Stretch</item>
/// </list>
/// </summary>
public enum XamlMediaStretch : byte
{
    /// <summary>
    /// 内容保持其原始大小。
    /// </summary>
    None = 0,

    /// <summary>
    /// 调整内容大小以填充目标尺寸。 不保留纵横比。
    /// </summary>
    Fill = 1,

    /// <summary>
    /// 在保留内容原有纵横比的同时调整内容的大小，以适合目标尺寸。
    /// </summary>
    Uniform = 2,

    /// <summary>
    /// 在保留内容原有纵横比的同时调整内容的大小，以填充目标尺寸。 如果目标矩形的纵横比不同于源矩形的纵横比，则对源内容进行剪裁以适合目标尺寸。
    /// </summary>
    UniformToFill = 3,
}