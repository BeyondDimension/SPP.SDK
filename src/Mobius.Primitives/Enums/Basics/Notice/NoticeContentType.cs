namespace Mobius.Enums.Basics.Notice;

/// <summary>
/// 通知内容类型
/// </summary>
public enum NoticeContentType : byte
{
    /// <summary>
    /// URL
    /// </summary>
    URL = 1,

    /// <summary>
    /// 文本
    /// </summary>
    Text = 4,

    /// <summary>
    /// 图片
    /// </summary>
    Picture = 8,
}

#if DEBUG
[Obsolete("use NoticeContentType", true)]
public enum NoticeType : byte
{
    /// <summary>
    /// URL
    /// </summary>
    URL = 1,

    /// <summary>
    /// 文本
    /// </summary>
    Text = 4,

    /// <summary>
    /// 图片
    /// </summary>
    Picture = 8,
}
#endif