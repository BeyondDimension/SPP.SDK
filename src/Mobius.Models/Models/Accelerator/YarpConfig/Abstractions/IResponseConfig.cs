namespace Mobius.Models.Accelerator.YarpConfig.Abstractions;

/// <summary>
/// 响应配置
/// </summary>
public interface IResponseConfig
{
    /// <inheritdoc cref="HttpStatusCode"/>
    HttpStatusCode StatusCode { get; }

    /// <summary>
    /// 内容类型
    /// </summary>
    string ContentType { get; }

    /// <summary>
    /// 内容的值
    /// </summary>
    string? ContentValue { get; }
}