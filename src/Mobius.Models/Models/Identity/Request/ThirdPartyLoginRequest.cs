namespace Mobius.Models.Identity.Request;

/// <summary>
/// 第三方平台快速登录请求
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
sealed partial class ThirdPartyLoginRequest : IExplicitHasValue
{
    /// <summary>
    /// 端口号
    /// </summary>
    [MP2Key(0)]
    public ushort Port { get; set; }

    /// <summary>
    /// S 密钥
    /// </summary>
    [MP2Key(1)]
    public byte[]? SKey { get; set; }

    /// <summary>
    /// S 密钥填充
    /// </summary>
    [MP2Key(2)]
    public string? SKeyPadding { get; set; }

    /// <summary>
    /// 接口版本号
    /// </summary>
    [MP2Key(3)]
    public string? Version { get; set; }

    /// <summary>
    /// 是否为绑定第三方平台账号
    /// </summary>
    [MP2Key(4)]
    public bool IsBind { get; set; }

    /// <summary>
    /// 访问 Token 有效期
    /// </summary>
    [MP2Key(5)]
    public DateTimeOffset AccessTokenExpires { get; set; }

    /// <summary>
    /// 访问 Token
    /// </summary>
    [MP2Key(6)]
    public string? AccessToken { get; set; }

    /// <inheritdoc/>
    public bool ExplicitHasValue()
    {
        if (!SKey.Any_Nullable() ||
            string.IsNullOrWhiteSpace(AccessToken) ||
            AccessTokenExpires == default ||
            string.IsNullOrWhiteSpace(SKeyPadding) ||
            string.IsNullOrWhiteSpace(Version))
            return false;
        return true;
    }
}