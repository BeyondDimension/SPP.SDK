namespace Mobius.Models.Accelerator.YarpConfig.Abstractions;

/// <summary>
/// 域名配置
/// </summary>
public interface IDomainConfig
{
    /// <summary>
    /// 是否发送 SNI
    /// </summary>
    bool TlsSni { get; }

    /// <summary>
    /// 自定义 SNI 值的表达式
    /// </summary>
    string? TlsSniPattern { get; }

    /// <summary>
    /// 是否忽略服务器证书域名不匹配
    /// <para>当不发送 SNI 时服务器可能发回域名不匹配的证书</para>
    /// </summary>
    bool TlsIgnoreNameMismatch { get; }

    /// <summary>
    /// 使用的 IP 地址
    /// </summary>
    IPAddress? IPAddress { get; }

    /// <summary>
    /// 使用的域名
    /// </summary>
    string? ForwardDestination { get; }

    /// <summary>
    /// 请求超时时长
    /// </summary>
    TimeSpan? Timeout { get; }

    /// <summary>
    /// 目的地
    /// <para>格式为相对或绝对 <see cref="Uri"/></para>
    /// </summary>
    Uri? Destination { get; }

    /// <summary>
    /// User-Agent
    /// </summary>
    string? UserAgent { get; }

    /// <summary>
    /// 自定义响应
    /// </summary>
    IResponseConfig? Response { get; }

    /// <summary>
    /// 子匹配项
    /// </summary>
    IReadOnlyDictionary<DomainPattern, IDomainConfig>? Items { get; }
}