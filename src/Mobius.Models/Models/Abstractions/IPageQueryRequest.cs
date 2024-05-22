namespace Mobius.Models.Abstractions;

/// <summary>
/// 分页查询请求
/// </summary>
public interface IPageQueryRequest
{
    /// <summary>
    /// 当前页码或当前偏移量
    /// </summary>
    int Current { get; set; }

    /// <summary>
    /// 页大小
    /// </summary>
    int PageSize { get; set; }
}

/// <inheritdoc cref="IPageQueryRequest"/>
public interface IPageQueryRequest<T> : IPageQueryRequest
{
    /// <summary>
    /// 附加参数
    /// </summary>
    T? Params { get; set; }
}