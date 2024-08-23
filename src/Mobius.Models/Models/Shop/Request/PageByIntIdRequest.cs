namespace Mobius.Models.Shop.Request;

public class PageByIntIdRequest
{
    public int OtherData { get; set; }

    [SystemTextJsonProperty("id")]
    public int Id { get; set; }

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