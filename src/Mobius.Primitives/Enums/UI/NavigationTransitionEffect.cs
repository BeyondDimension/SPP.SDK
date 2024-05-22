namespace Mobius.Enums.UI;

/// <summary>
/// 导航过渡效果
/// </summary>
public enum NavigationTransitionEffect
{
    /// <summary>
    /// 无效果
    /// </summary>
    None = 0,

    /// <summary>
    /// The exiting page leaves to the right of the panel and the entering page enters from the left.
    /// </summary>
    FromLeft,

    /// <summary>
    /// The exiting page leaves to the left of the panel and the entering page enters from the right.
    /// </summary>
    FromRight,

    /// <summary>
    /// The exiting page fades out and the entering page enters from the top.
    /// </summary>
    FromTop,

    /// <summary>
    /// The exiting page fades out and the entering page enters from the bottom.
    /// </summary>
    FromBottom,

    /// <summary>
    /// DrillIn
    /// </summary>
    DrillIn,

    /// <summary>
    /// Entrance
    /// </summary>
    Entrance,
}
