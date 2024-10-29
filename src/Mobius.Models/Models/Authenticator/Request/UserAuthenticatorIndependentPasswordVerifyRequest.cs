namespace Mobius.Models.Authenticator.Request;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class UserAuthenticatorIndependentPasswordVerifyRequest
{
    /// <summary>
    /// 问题答案
    /// </summary>
    /// </summary>
    [MPKey(0), MP2Key(0)]
    [Required]
    [StringLength(LengthConstants.Max_PwdQuestionAnswer)]
    public string Answer { get; set; } = string.Empty;
}