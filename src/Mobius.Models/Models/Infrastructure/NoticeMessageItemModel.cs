namespace Mobius.Models.Infrastructure;

/// <summary>
/// 通知消息模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
sealed partial record class NoticeMessageItemModel
{
    /// <summary>
    /// 标题
    /// </summary>
    [MP2Key(0)]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// 内容
    /// </summary>
    [MP2Key(1)]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 消息链接
    /// </summary>
    [MP2Key(2)]
    public string? MessageLink { get; set; }

    /// <summary>
    /// 推送时间/消息日期
    /// </summary>
    [MP2Key(3)]
    public DateTimeOffset PushTime { get; set; }
}

#if DEBUG
public partial record class NoticeMessageItemModel { }
#endif