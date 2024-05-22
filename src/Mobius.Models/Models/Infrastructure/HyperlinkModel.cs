namespace Mobius.Models.Infrastructure;

/// <summary>
/// 超链接模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
sealed partial record class HyperlinkModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HyperlinkModel"/> class.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="url"></param>
    [MP2Constructor]
    public HyperlinkModel(string text, string url)
    {
        Text = text;
        Url = url;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="HyperlinkModel"/> class.
    /// </summary>
    /// <param name="text"></param>
    public HyperlinkModel(string text)
    {
        Text = text;
    }

    /// <summary>
    /// 文本内容
    /// </summary>
    [MP2Key(0)]
    public string? Text { get; }

    /// <summary>
    /// 超链接地址
    /// </summary>
    [MP2Key(1)]
    public string? Url { get; }
}

#if DEBUG
public partial record class HyperlinkModel { }
#endif
