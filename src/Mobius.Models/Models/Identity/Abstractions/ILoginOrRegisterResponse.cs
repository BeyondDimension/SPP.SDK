namespace Mobius.Models.Identity.Abstractions;

/// <summary>
/// 登录或注册响应内容
/// </summary>
interface ILoginOrRegisterResponse :
    ILoginResponse, IExplicitHasValue
{
    /// <inheritdoc cref="Enums.Identity.ExternalLoginChannel"/>
    ExternalLoginChannel? ExternalLoginChannel { get; set; }
}