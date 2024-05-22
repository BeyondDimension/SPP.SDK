namespace Mobius.Enums.Text;

/// <summary>
/// 文本阅读器提供商
/// </summary>
public enum TextReaderProvider : byte
{
    /// <summary>
    /// 系统默认，例如 Win 上的记事本
    /// </summary>
    SystemDefault,

    /// <inheritdoc cref="SystemDefault"/>
    Notepad = SystemDefault,

    /// <summary>
    /// Visual Studio Code
    /// </summary>
    VSCode,
}
