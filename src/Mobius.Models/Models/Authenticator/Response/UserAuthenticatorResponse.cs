namespace Mobius.Models.Authenticator.Response;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class UserAuthenticatorResponse
{
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 令牌名
    /// </summary>
    [MPKey(1), MP2Key(1)]
    [MaxLength(LengthConstants.Max_AuthenticatorName)]
    public string Name { get; set; } = "";

    /// <summary>
    /// 令牌类型
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public UserAuthenticatorTokenType TokenType { get; set; }

    /// <summary>
    /// 令牌序列化储存内容
    /// </summary>
    [MPKey(3), MP2Key(3)]
    [Required]
    [MaxLength(LengthConstants.Max_AuthenticatorToken)]
    public byte[]? Token { get; set; } = null!;

    /// <summary>
    /// 备注
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public string? Remarks { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    [MPKey(5), MP2Key(5)]
    public long Order { get; set; }
}