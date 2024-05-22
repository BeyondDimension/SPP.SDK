namespace Mobius.Models.Abstractions;

/// <inheritdoc cref="IPageQueryRequest"/>
public abstract class BasePageQueryRequest : IPageQueryRequest
{
    /// <inheritdoc/>
    public int Current { get; set; }

    /// <inheritdoc/>
    public int PageSize { get; set; } = 15;
}