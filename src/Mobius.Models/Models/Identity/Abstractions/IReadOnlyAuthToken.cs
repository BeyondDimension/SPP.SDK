namespace Mobius.Models.Identity.Abstractions;

/// <summary>
/// 获取登录 JWT 凭证
/// </summary>
public interface IReadOnlyAuthToken
{
    /// <inheritdoc cref="IReadOnlyAuthToken"/>
    JWTEntity? AuthToken { get; }
}
