namespace Mobius.Models.Authenticator.Request;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class UserAuthenticatorDeleteBackupRecoverRequest
{
    [MPKey(0), MP2Key(0)]
    [Required]
    public Guid[] Id { get; set; } = Array.Empty<Guid>();

    /// <summary>
    /// 问题答案
    /// </summary>
    [MPKey(1), MP2Key(1)]
    [Required]
    [StringLength(LengthConstants.Max_PwdQuestionAnswer)]
    public string Answer { get; set; } = string.Empty;
}