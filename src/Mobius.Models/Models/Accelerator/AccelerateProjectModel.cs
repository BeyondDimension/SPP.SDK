namespace Mobius.Models.Accelerator;

/// <summary>
/// 加速项目
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
[DebuggerDisplay("{DebuggerDisplay(),nq}")]
public sealed partial class AccelerateProjectModel : JsonModel<AccelerateProjectModel>
{
    /// <inheritdoc cref="DebuggerDisplayAttribute"/>
    public string DebuggerDisplay() => $"{Name}, {ForwardDomainNames}";

    /// <summary>
    /// 名称
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 端口号
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public ushort Port { get; set; }

    string mMatchDomainNames = string.Empty;
    Lazy<string[]>? lazyMatchDomainNames;

    /// <summary>
    /// 匹配域名地址，分号分割多个
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public string MatchDomainNames
    {
        get => mMatchDomainNames;
        set
        {
            if (mMatchDomainNames == value)
                return;

            mMatchDomainNames = value;
            if (string.IsNullOrWhiteSpace(mMatchDomainNames))
                lazyMatchDomainNames = null;
            else
                lazyMatchDomainNames = new(() => ApiConstants.GetSplitValues(mMatchDomainNames));
        }
    }

    /// <summary>
    /// 匹配域名地址数组
    /// </summary>
    [XmlIgnore, IgnoreDataMember, SystemTextJsonIgnore, NewtonsoftJsonIgnore, MPIgnore, MP2Ignore]
    public string[] DomainNamesArray => lazyMatchDomainNames == null ? [] : lazyMatchDomainNames.Value;

    string? _ForwardDomainName;

    /// <summary>
    /// 转发到域名地址
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public string ForwardDomainNames
    {
        get => _ForwardDomainName ?? string.Empty;
        set => _ForwardDomainName = value;
    }

    /// <summary>
    /// 忽略 SSL 证书验证
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public bool IgnoreSSLCertVerification { get; set; }

    /// <summary>
    /// 伪装 ServerName
    /// </summary>
    [MPKey(5), MP2Key(5)]
    public string? FakeServerName { get; set; }

    /// <summary>
    /// 代理类型
    /// </summary>
    [MPKey(6), MP2Key(6)]
    public ProxyType ProxyType { get; set; }

    string mListenDomainNames = string.Empty;
    Lazy<string[]>? lazyListenDomainNames;

    /// <summary>
    /// 监听域名，原 Hosts
    /// </summary>
    [MPKey(7), MP2Key(7)]
    public string ListenDomainNames
    {
        get => mListenDomainNames;
        set
        {
            if (mListenDomainNames == value)
                return;

            mListenDomainNames = value;
            if (string.IsNullOrWhiteSpace(mListenDomainNames))
                lazyListenDomainNames = null;
            else
                lazyListenDomainNames = new(() => ApiConstants.GetSplitValues(mListenDomainNames));
        }
    }

    /// <summary>
    /// 监听域名数组
    /// </summary>
    [XmlIgnore, IgnoreDataMember, SystemTextJsonIgnore, NewtonsoftJsonIgnore, MPIgnore, MP2Ignore]
    public string[] ListeningDomainNamesArray => lazyListenDomainNames == null ? [] : lazyListenDomainNames.Value;

    /// <summary>
    /// 是否选中
    /// </summary>
    [MPKey(8), MP2Key(8)]
    public bool Checked { get; set; }

    /// <summary>
    /// 服务端主键
    /// </summary>
    [MPKey(9), MP2Key(9)]
    public Guid Id { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    [MPKey(10), MP2Key(10)]
    public long Order { get; set; }

    /// <summary>
    /// 伪装 UserAgent
    /// </summary>
    [MPKey(11), MP2Key(11)]
    public string? FakeUserAgent { get; set; }

    /// <summary>
    /// 子级加速项目
    /// </summary>
    [MPKey(12), MP2Key(12)]
    public List<AccelerateProjectModel>? Items { get; set; }

    /// <summary>
    /// 版本号
    /// </summary>
    [MPKey(13), MP2Key(13)]
    public string Version { get; set; } = "";
}

partial class AccelerateProjectModel : IResponseConfig
{
    /// <inheritdoc/>
    HttpStatusCode IResponseConfig.StatusCode
        => ProxyType switch
        {
            ProxyType.DirectFailure => HttpStatusCode.NotFound,
            ProxyType.DirectSuccess => HttpStatusCode.OK,
            _ => default
        };

    /// <inheritdoc/>
    string IResponseConfig.ContentType
        => MediaTypeNames.TXT;

    /// <inheritdoc/>
    string? IResponseConfig.ContentValue
        => null;
}

partial class AccelerateProjectModel : IDomainConfig
{
    /// <inheritdoc/>
    bool IDomainConfig.TlsSni
        => !string.IsNullOrEmpty(FakeServerName);

    /// <inheritdoc/>
    string? IDomainConfig.TlsSniPattern
        => FakeServerName;

    /// <inheritdoc/>
    bool IDomainConfig.TlsIgnoreNameMismatch
        => IgnoreSSLCertVerification;

    /// <inheritdoc/>
    IPAddress? IDomainConfig.IPAddress
    {
        get
        {
            if (ProxyType == ProxyType.Local &&
                IPAddress2.TryParse(ForwardDomainNames, out var ip))
            {
                return ip;
            }
            return null;
        }
    }

    /// <inheritdoc/>
    string? IDomainConfig.ForwardDestination
    {
        get
        {
            if (ProxyType == ProxyType.Local &&
                !IPAddress2.TryParse(ForwardDomainNames, out var _))
            {
                return ForwardDomainNames;
            }
            return null;
        }
    }

    /// <inheritdoc/>
    TimeSpan? IDomainConfig.Timeout => null;

    /// <inheritdoc/>
    Uri? IDomainConfig.Destination
    {
        get
        {
            if (ProxyType == ProxyType.Redirect)
            {
                var b = new UriBuilder
                {
                    Scheme = Port == 443 ?
                        Uri.UriSchemeHttps :
                        Uri.UriSchemeHttp,
                    Host = ForwardDomainNames,
                    Port = Port,
                };
                return b.Uri;
            }
            return null;
        }
    }

    /// <inheritdoc/>
    string? IDomainConfig.UserAgent => FakeUserAgent;

    /// <inheritdoc/>
    IResponseConfig? IDomainConfig.Response => null;

    /// <inheritdoc/>
    IReadOnlyDictionary<DomainPattern, IDomainConfig>? IDomainConfig.Items
        => Items?.ToDictionary(x =>
            new DomainPattern(x.MatchDomainNames),
            y => (IDomainConfig)y);
}