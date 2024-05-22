namespace Mobius.Models.Basics.Article;

/// <summary>
/// 文章分类模型
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public partial class ArticleCategoryModel
{
    /// <summary>
    /// 文章 Id
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 分类名
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string Name { get; set; } = string.Empty;
}

/// <summary>
/// 文章分类树状模型
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public partial class ArticleCategoryTreeModel : ArticleCategoryModel
{
    /// <summary>
    /// 文章分类子节点
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public ArticleCategoryTreeModel[]? Child { get; set; }
}