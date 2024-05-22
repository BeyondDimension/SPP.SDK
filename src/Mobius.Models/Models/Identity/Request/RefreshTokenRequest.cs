namespace Mobius.Models.Identity.Request;

/// <summary>
/// 刷新 JWT 请求
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
sealed partial class RefreshTokenRequest : IDeviceId
{
    /// <summary>
    /// 刷新 Token
    /// </summary>
    [MP2Key(0)]
    public string? RefreshToken { get; set; }

    /// <inheritdoc/>
    [MP2Key(1)]
    public Guid DeviceIdG { get; set; }

    /// <inheritdoc/>
    [MP2Key(2)]
    public string? DeviceIdR { get; set; }

    /// <inheritdoc/>
    [MP2Key(3)]
    public string? DeviceIdN { get; set; }
}
