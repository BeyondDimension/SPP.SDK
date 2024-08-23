namespace Mobius.Models.Shop.Abstractions;

public interface IPageList<T> : IList<T>
{
    /// <summary>
    /// 当前页码
    /// </summary>
    int PageIndex { get; }

    /// <summary>
    /// 每页数量
    /// </summary>
    int PageSize { get; }

    /// <summary>
    /// 总数量
    /// </summary>
    int TotalCount { get; }

    /// <summary>
    /// 总页码
    /// </summary>
    int TotalPages { get; }

    /// <summary>
    /// 是否有上一页
    /// </summary>
    bool HasPreviousPage { get; }

    /// <summary>
    /// 是否有下一页
    /// </summary>
    bool HasNextPage { get; }
}
