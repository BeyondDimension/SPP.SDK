namespace Mobius.Enums.UI;

/// <summary>
/// 切换开关值
/// </summary>
public enum ToggleSwitchValue : byte
{
    /// <summary>
    /// 切换
    /// </summary>
    Toggle,

    /// <summary>
    /// 开
    /// </summary>
    On,

    /// <summary>
    /// 关
    /// </summary>
    Off,
}

#if DEBUG
/// <summary>
/// OnOffToggle
/// </summary>
[Obsolete("use ToggleSwitchValue", true)]
public enum OnOffToggle : byte
{
    /// <summary>
    /// 切换
    /// </summary>
    Toggle,

    /// <summary>
    /// 开
    /// </summary>
    On,

    /// <summary>
    /// 关
    /// </summary>
    Off,
}

/// <summary>
/// EOnOff
/// </summary>
[Obsolete("use ToggleSwitchValue", true)]
public enum EOnOff : byte
{
    /// <summary>
    /// 切换
    /// </summary>
    Toggle,

    /// <summary>
    /// 开
    /// </summary>
    On,

    /// <summary>
    /// 关
    /// </summary>
    Off,
}
#endif