namespace Mobius.Models.Identity.Request;

/// <summary>
/// 发送短信验证码请求
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
sealed partial class SendSmsRequest : IReadOnlyPhoneNumber
{
    /// <inheritdoc/>
    [MPKey(0), MP2Key(0)]
    public string? PhoneNumber { get; set; }

    /// <inheritdoc cref="SmsCodeType"/>
    [MPKey(1), MP2Key(1)]
    public SmsCodeType Type { get; set; }
}