namespace Mobius.Models.Authenticator.Request;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class UserAuthenticatorIndependentPasswordSetRequest
{
    /// <summary>
    /// 密码问题
    /// </summary>
    [MPKey(0), MP2Key(0)]
    [Required]
    [StringLength(LengthConstants.Max_PwdQuestion)]
    public string PwdQuestion { get; set; } = string.Empty;

    /// <summary>
    /// 问题答案
    /// </summary>
    /// </summary>
    [MPKey(1), MP2Key(1)]
    [Required]
    [StringLength(LengthConstants.Max_PwdQuestionAnswer)]
    public string Answer { get; set; } = string.Empty;
}