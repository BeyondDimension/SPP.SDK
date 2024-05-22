namespace Mobius.Models.Accelerator.YarpConfig;

/// <inheritdoc cref="IDomainConfig"/>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class DomainConfig : JsonModel<DomainConfig>, IDomainConfig
{
    /// <inheritdoc/>
    [MPKey(0), MP2Key(0)]
    public bool TlsSni { get; init; }

    /// <inheritdoc/>
    [MPKey(1), MP2Key(1)]
    public string? TlsSniPattern { get; init; }

    /// <inheritdoc/>
    [MPKey(2), MP2Key(2)]
    public bool TlsIgnoreNameMismatch { get; init; }

    /// <inheritdoc/>
    [MPKey(3), MP2Key(3)]
    [MessagePackFormatter(typeof(IPAddressFormatter))]
    [IPAddressFormatter]
    public IPAddress? IPAddress { get; init; }

    /// <inheritdoc/>
    [MPKey(4), MP2Key(4)]
    public TimeSpan? Timeout { get; init; }

    /// <inheritdoc/>
    [MPKey(5), MP2Key(5)]
    public Uri? Destination { get; init; }

    /// <inheritdoc cref="IDomainConfig.Response"/>
    [MPKey(6), MP2Key(6)]
    public ResponseConfig? Response { get; init; }

    /// <inheritdoc/>
    [MPKey(7), MP2Key(7)]
    public string? ForwardDestination { get; init; }

    /// <inheritdoc/>
    [MPKey(8), MP2Key(8)]
    public string? UserAgent { get; init; }

    /// <inheritdoc/>
    [MPKey(9), MP2Key(9)]
    public IReadOnlyDictionary<DomainPattern, IDomainConfig>? Items { get; init; }

    /// <inheritdoc/>
    IResponseConfig? IDomainConfig.Response => Response;
}

/// <summary>
/// 提供对 <see cref="IDomainConfig"/> 类型的扩展函数
/// </summary>
public static partial class DomainConfigExtensions
{
    /// <summary>
    /// 获取 <see cref="TlsSniPattern"/>
    /// </summary>
    /// <param name="domainConfig"></param>
    /// <returns></returns>
    public static TlsSniPattern GetTlsSniPattern(this IDomainConfig domainConfig)
    {
        if (domainConfig.TlsSni == false)
        {
            return TlsSniPattern.None;
        }
        if (string.IsNullOrEmpty(domainConfig.TlsSniPattern))
        {
            return TlsSniPattern.Domain;
        }
        return new TlsSniPattern(domainConfig.TlsSniPattern);
    }
}