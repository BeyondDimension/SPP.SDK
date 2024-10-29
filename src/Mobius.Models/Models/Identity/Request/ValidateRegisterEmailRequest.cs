namespace Mobius.Models.Identity.Request;

/// <summary>
/// 账号注册（通过邮箱）接口请求模型
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class ValidateRegisterEmailRequest
{
    [MPKey(0), MP2Key(0)]
    public string Email { get; set; } = string.Empty;
}