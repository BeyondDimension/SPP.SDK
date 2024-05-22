namespace Mobius.Models.Identity.Abstractions;

/// <summary>
/// 登录响应内容
/// </summary>
interface ILoginResponse :
    IReadOnlyAuthToken, IReadOnlyPhoneNumber
{
    /// <summary>
    /// 用户 Id
    /// </summary>
    Guid UserId { get; }
}