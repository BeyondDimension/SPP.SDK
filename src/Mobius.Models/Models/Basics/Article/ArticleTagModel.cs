namespace Mobius.Models.Basics.Article;

/// <summary>
/// 文章标签模型
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public partial class ArticleTagModel
{
    /// <summary>
    /// 文章 Id
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 文章标签名
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string Name { get; set; } = string.Empty;
}
