namespace Mobius.Models.Identity;

/// <summary>
/// 当前登录用户模型，如需增加字段，还需要在 <see cref="Clone"/> 中赋值新添加字段
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
sealed partial class CurrentUser : IExplicitHasValue, IPhoneNumber
{
    /// <summary>
    /// 用户 Id
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid UserId { get; set; }

    /// <summary>
    /// 登录凭证
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public JWTEntity? AuthToken { get; set; }

    /// <inheritdoc/>
    [MPKey(2), MP2Key(2)]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// 商城登录凭证
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public JWTEntity? ShopAuthToken { get; set; }

    /// <inheritdoc/>
    bool IExplicitHasValue.ExplicitHasValue()
    {
        if (!AuthToken.HasValue()) return false;
        return true;
    }

    /// <summary>
    /// 创建作为当前实例副本的新对象，如果当前对象值无效，则返回 <see langword="null"/>。
    /// </summary>
    /// <returns></returns>
    public CurrentUser? Clone() => this.HasValue() ?
        new()
        {
            UserId = UserId,
            AuthToken = AuthToken,
            PhoneNumber = PhoneNumber,
            ShopAuthToken = ShopAuthToken,
        } : null;
}