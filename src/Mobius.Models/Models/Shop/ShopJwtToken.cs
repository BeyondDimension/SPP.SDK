namespace Mobius.Models.Shop;

/// <summary>
/// 商城登录凭证
/// </summary>
sealed class ShopJwtToken
{
    /// <summary>
    /// 有效期
    /// </summary>
    [SystemTextJsonProperty("expires_in")]
    public double ExpiresIn { get; set; }

    /// <summary>
    /// 访问凭证
    /// </summary>
    [SystemTextJsonProperty("token")]
    public string AccessToken { get; set; } = string.Empty;
}
