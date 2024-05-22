namespace Mobius.Models.Identity.Response;

/// <summary>
/// 登录或注册接口响应模型
/// </summary>
[MPObj, MP2Obj(GenerateType.VersionTolerant, MP2SerializeLayout.Explicit)]
sealed partial class LoginOrRegisterResponse : ILoginResponse, IExplicitHasValue, ILoginOrRegisterResponse
{
    /// <inheritdoc/>
    Guid ILoginResponse.UserId => User?.Id ?? default;

    /// <inheritdoc/>
    [MPKey(0), MP2Key(0)]
    public JWTEntity? AuthToken { get; set; }

    /// <summary>
    /// 当前登录的用户信息
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public UserInfoModel? User { get; set; }

    /// <summary>
    /// 当前操作是登录(<see langword="true"/>)还是注册(<see langword="false"/>)
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public bool IsLoginOrRegister { get; set; }

    /// <inheritdoc/>
    [MPKey(3), MP2Key(3)]
    public string? PhoneNumber { get; set; }

    /// <inheritdoc cref="Enums.Identity.ExternalLoginChannel"/>
    [MPKey(4), MP2Key(4)]
    public ExternalLoginChannel? ExternalLoginChannel { get; set; }

    /// <inheritdoc/>
    bool IExplicitHasValue.ExplicitHasValue()
    {
        var hasToken = AuthToken != null;
        if (IsLoginOrRegister)
        {
            return hasToken;
        }
        else
        {
            return hasToken && User != null;
        }
    }
}
