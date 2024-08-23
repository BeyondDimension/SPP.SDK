namespace Mobius.Models.Shop.Request;

/// <summary>
/// 根据不同类型获取商品提交参数
/// </summary>
public class GoodByTypeRequest
{
    /// <summary>
    /// 类型
    /// </summary>
    [SystemTextJsonProperty("type")]
    public int Type { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    [SystemTextJsonProperty("num")]
    public int Num { get; set; } = 0;

    /// <summary>
    /// 排序方式
    /// </summary>
    [SystemTextJsonProperty("orderby")]
    public string OrderBy { get; set; } = string.Empty;

    /// <summary>
    /// 当前页码
    /// </summary>
    [SystemTextJsonProperty("page")]
    public int Page { get; set; } = 1;
}