namespace Mobius.Models.Shop.Request;

/// <summary>
/// 根据String类型id加where查询条件和order排序获取列表(一般用于直接id分页)
/// </summary>
public class PageByStringIdRequest
{
    [SystemTextJsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// 当前页码
    /// </summary>
    [SystemTextJsonProperty("page")]
    public int Page { get; set; } = 1;

    /// <summary>
    /// 每页数据量
    /// </summary>
    [SystemTextJsonProperty("limit")]
    public int Limit { get; set; } = 10;

    /// <summary>
    /// 排序
    /// </summary>
    [SystemTextJsonProperty("order")]
    public string Order { get; set; } = string.Empty;

    /// <summary>
    /// 判断条件
    /// </summary>
    [SystemTextJsonProperty("where")]
    public string Where { get; set; } = string.Empty;
}
