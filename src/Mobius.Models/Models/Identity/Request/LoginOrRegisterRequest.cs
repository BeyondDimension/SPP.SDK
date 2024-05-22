namespace Mobius.Models.Identity.Request;

/// <summary>
/// 登录或注册接口请求模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
sealed partial class LoginOrRegisterRequest : IReadOnlyPhoneNumber, IReadOnlySmsCode, IDeviceId
{
    /// <inheritdoc/>
    [MP2Key(0)]
    public string? PhoneNumber { get; set; }

    /// <inheritdoc/>
    [MP2Key(1)]
    public string? SmsCode { get; set; }

    /// <inheritdoc cref="LoginChannel"/>
    [MP2Key(2)]
    public LoginChannel Channel { get; set; } = LoginChannel.Client;

    /// <inheritdoc/>
    [MP2Key(3)]
    public Guid DeviceIdG { get; set; }

    /// <inheritdoc/>
    [MP2Key(4)]
    public string? DeviceIdR { get; set; }

    /// <inheritdoc/>
    [MP2Key(5)]
    public string? DeviceIdN { get; set; }
}
